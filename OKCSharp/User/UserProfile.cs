using Newtonsoft.Json;
using OKCSharp.DiscoveryObjects;
using System.Collections.Generic;

namespace OKCSharp.User
{
    public class UserProfile
    {
        [JsonProperty("id")]
        public ulong Id { get; private set; }

        [JsonProperty("username")]
        public ulong Username { get; private set; }

        [JsonProperty("online")]
        public bool IsOnline { get; private set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; private set; }

        [JsonProperty("userinfo")]
        public UserInfo? UserInfo { get; private set; }

        [JsonProperty("percentages")]
        public Percentages? Percentages { get; private set; }

        [JsonProperty("detail_tags")]
        public string[] DetailTags { get; private set; }

        [JsonProperty("thumbs")]
        public IEnumerable<Thumbs>? Thumbnails { get; private set; }
    }
}