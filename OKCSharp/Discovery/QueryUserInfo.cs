using Newtonsoft.Json;
using OKCSharp.GraphQL;

namespace OKCSharp.DiscoveryObjects
{
    public class QueryUserInfo
    {
        [JsonProperty("realname")]
        public string RealName { get; private set; }

        [JsonProperty("gender_letter")]
        public char GenderLetter { get; private set; }

        [JsonProperty("gender")]
        public string Gender { get; private set; }

        [JsonProperty("age")]
        public int Age { get; private set; }

        [JsonProperty("rel_status")]
        public string RelationshipStatus { get; private set; }

        [JsonProperty("location")]
        public QueryLocation? Location { get; private set; }

        [JsonProperty("user_data")]
        public string UserData { get; private set; }

        [JsonProperty("orientation")]
        public string SexualOrientation { get; private set; }

        [JsonProperty("staff_badge")]
        public object? StaffBadge { get; private set; }

        [JsonProperty("displayname")]
        public string DisplayName { get; private set; }
    }
}