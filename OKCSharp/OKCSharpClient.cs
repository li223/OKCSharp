using Newtonsoft.Json;
using OKCSharp.DiscoveryObjects;
using OKCSharp.Objects;
using OKCSharp.User;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace OKCSharp
{
    public class OKCSharpClient
    {
        private HttpClient Http { get; set; }
        private LoginData? UserLoginData { get; set; }
        private string UserEmail { get; set; }
        private string UserPassword { get; set; }
        private string BaseAddress { get; set; } = "https://www.okcupid.com";

        public OKCSharpClient(string email, string password)
        {
            this.Http = new HttpClient();
            this.UserEmail = email;
            this.UserPassword = password;
            this.UserLoginData = this.AuthoriseAsync().ConfigureAwait(false).GetAwaiter().GetResult();
            if (this.UserLoginData == null) throw new Exception("Unable to authorise login, please check your email and password are correct");
            this.Http.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", $"Bearer {this.UserLoginData.OAuthAccessToken}");
            this.BaseAddress += "/1/apitun";
        }

        /// <summary>
        /// Authorises login with the given username and password. This method is called in the Ctor.
        /// </summary>
        /// <returns>LoginData</returns>
        private async Task<LoginData?> AuthoriseAsync()
        {
            var req = new HttpRequestMessage(HttpMethod.Post, new Uri($"{BaseAddress}/login"))
            {
                Content = new StringContent($"okc_api=1&password={HttpUtility.UrlEncode(this.UserPassword)}&username={HttpUtility.UrlEncode(this.UserEmail)}")
            };
            var res = await this.Http.SendAsync(req).ConfigureAwait(false);
            var cont = await res.Content.ReadAsStringAsync().ConfigureAwait(false);
            var obj = JsonConvert.DeserializeObject<LoginData>(cont);
            return (obj.ScreenName == null) ? null : obj;
        }

        /// <summary>
        /// Get the state of messages
        /// </summary>
        /// <returns>MessageState Object</returns>
        public async Task<MessageState?> GetMessageStateAsync()
        {
            var res = await this.Http.GetAsync($"{this.BaseAddress}/messages/global_messaging/state").ConfigureAwait(false);
            var cont = await res.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (res.IsSuccessStatusCode) return JsonConvert.DeserializeObject<MessageState>(cont);
            else return null;
        }

        /// <summary>
        /// Get users from Discovery
        /// </summary>
        /// <param name="section">Which section to get users from</param>
        /// <param name="limit">The number of users to get</param>
        /// <returns></returns>
        public async Task<IEnumerable<DiscoveryMatch>?> GetDiscoveryMatchesAsync(DiscoverySection section, int limit = 20)
        {
            var req = new HttpRequestMessage(HttpMethod.Post, new Uri($"{BaseAddress}/discovery/section"))
            {
                Content = new StringContent(JsonConvert.SerializeObject(new DiscoveryPayload()
                {
                    Section = section.ToString(),
                    Limit = limit
                }))
            };
            var res = await this.Http.SendAsync(req).ConfigureAwait(false);
            var cont = await res.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (res.IsSuccessStatusCode) return (JsonConvert.DeserializeObject<DiscoveryApiResponse>(cont))?.Results?.Rows?.First().ApiData;
            else return null;
        }

        /// <summary>
        /// Either pass or like a user
        /// </summary>
        /// <param name="type">Pass or Like</param>
        /// <param name="user_id">The id of the user to perform the action on</param>
        /// <returns>UserLikeStatus Object</returns>
        public async Task<UserLikeStatus?> SwipeAsync(SwipeType type, ulong user_id)
        {
            var obj = new CardActionPayload()
            {
                Votes = new List<ProfileVote>()
                {
                    new ProfileVote()
                    {
                        IsLike = type == SwipeType.Like,
                        UserId = user_id
                    }
                }
            };

            var req = new HttpRequestMessage(HttpMethod.Post, new Uri($"{this.BaseAddress}/likes/batch"))
            {
                Content = new StringContent(JsonConvert.SerializeObject(obj))
            };
            var res = await this.Http.SendAsync(req).ConfigureAwait(false);
            var cont = await res.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (res.IsSuccessStatusCode) return JsonConvert.DeserializeObject<UserLikeStatus>(cont);
            else return null;
        }

        /// <summary>
        /// Get a user's profile
        /// </summary>
        /// <param name="id">Id of the user to get the profile for</param>
        /// <param name="thumb_limit">Unknown</param>
        /// <returns>UserProfile Object</returns>
        public async Task<UserProfile?> GetUserProfileAsync(ulong id, int thumb_limit = 1)
        {
            var res = await this.Http.GetAsync(new Uri($"{BaseAddress}/profile/{id}/fields?action=quickview&fields=thumbs.limit({thumb_limit}),userinfo,percentages,online,detail_tags")).ConfigureAwait(false);
            var cont = await res.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (res.IsSuccessStatusCode) return JsonConvert.DeserializeObject<UserProfile>(cont);
            else return null;
        }




        //GraphQL doesnt wanna work and I hate it
        internal async Task<IEnumerable<UserLike>?> GetUserLikesAsync(string? after = null)
        {
            using var stream = Assembly.GetExecutingAssembly()?.GetManifestResourceStream("OKCSharp.Schema.UserLikes.graphql");
            if (stream == null) throw new NullReferenceException("Could not find resource");
            using var sr = new StreamReader(stream);
            var schema = await sr.ReadToEndAsync().ConfigureAwait(false);
            var gqlpay = new GraphQLPayload()
            {
                OperationName = "userrowsIncomingLikes",//"userrowsOutgoingLikes",
                Query = schema,
                Variables = new Dictionary<string, string>()
                {
                    {
                        "userid",
                        this.UserLoginData?.UserId.ToString() ?? ""
                    }
                }
            };

            if (after != null) gqlpay.Variables.Add("after", after);
            var req = new HttpRequestMessage(HttpMethod.Post, new Uri($"https://www.okcupid.com/graphql"))
            {
                Content = new StringContent(JsonConvert.SerializeObject(gqlpay), Encoding.Default, "application/json")
            };
            var res = await this.Http.SendAsync(req).ConfigureAwait(false);
            var cont = await res.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (res.IsSuccessStatusCode) return (JsonConvert.DeserializeObject<ApiResponse<UserLikesNotification>>(cont)).ApiData?.NotificationData?.Likes?.Data;
            else return null;
        }

        internal async Task<CurrentUserProfile?> GetCurrentUserProfileAsync()
        {
            using var stream = Assembly.GetExecutingAssembly()?.GetManifestResourceStream("OKCSharp.Schema.UserProfile.graphql");
            if (stream == null) throw new NullReferenceException("Could not find resource");
            using var sr = new StreamReader(stream);
            var schema = await sr.ReadToEndAsync().ConfigureAwait(false);
            var gqlpay = new GraphQLPayload()
            {
                OperationName = "profileEditDesktop",
                Query = schema,
                Variables = new Dictionary<string, string>()
                {
                    {
                        "id",
                        this.UserLoginData?.UserId.ToString() ?? ""
                    }
                }
            };

            var jsonbody = JsonConvert.SerializeObject(gqlpay, Formatting.Indented);

            var req = new HttpRequestMessage(HttpMethod.Post, new Uri($"https://www.okcupid.com/graphql"))
            {
                Content = new StringContent(jsonbody, Encoding.Default, "application/json")
            };
            var res = await this.Http.SendAsync(req).ConfigureAwait(false);
            var cont = await res.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (res.IsSuccessStatusCode) return (JsonConvert.DeserializeObject<ApiResponse<CurrentUserProfile>>(cont)).ApiData;
            else return null;
        }
    }
}
