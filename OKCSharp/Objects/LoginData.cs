using Newtonsoft.Json;
using System;

namespace OKCSharp.Objects
{
    public class LoginData
    {
        /// <summary>
        /// Unknown
        /// </summary>
        [JsonProperty("actionable")]
        public bool Actionable { get; private set; }

        /// <summary>
        /// Int version of status
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; private set; }

        /// <summary>
        /// Page to navigate to on success
        /// </summary>
        [JsonProperty("success_page")]
        public string SuccessPage { get; private set; }

        /// <summary>
        /// Access Token for requests
        /// </summary>
        [JsonProperty("oauth_accesstoken")]
        public string OAuthAccessToken { get; private set; }
        
        /// <summary>
        /// User Id
        /// </summary>
        [JsonProperty("userid")]
        public ulong? UserId { get; private set; }

        /// <summary>
        /// Service status in human readable format
        /// </summary>
        [JsonProperty("status_str")]
        public string StatusString { get; private set; }

        /// <summary>
        /// Id of the user screenname
        /// </summary>
        [JsonProperty("screenname")]
        public ulong? ScreenName { get; private set; }

        /// <summary>
        /// Uri to thumbnail
        /// </summary>
        [JsonProperty("thumbnail")]
        public Uri? Thumbnail { get; private set; }

        /// <summary>
        /// Unknwon
        /// </summary>
        [JsonProperty("show_alist_box")]
        public object? ShowAListBox { get; private set; }
    }
}
