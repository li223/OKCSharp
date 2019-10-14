using Newtonsoft.Json;
using OKCSharp.GraphQL;

namespace OKCSharp.User
{
    public class UserInfo
    {
        [JsonProperty("id")]
        public ulong Id { get; private set; }

        [JsonProperty("username")]
        public ulong Username{ get; private set; }

        [JsonProperty("displayname")]
        public string DisplayName { get; private set; }

        [JsonProperty("age")]
        public int Age { get; private set; }

        [JsonProperty("isOnline")]
        public bool IsOnline { get; private set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }
}
