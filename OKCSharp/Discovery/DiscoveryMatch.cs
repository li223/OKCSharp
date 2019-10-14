using Newtonsoft.Json;
using OKCSharp.User;
using System.Collections.Generic;

namespace OKCSharp.DiscoveryObjects
{
    public class DiscoveryMatch
    {
        [JsonProperty("userinfo")]
        public UserInfo? UserInfo { get; private set; }

        [JsonProperty("likes")]
        public Likes? Likes { get; private set; }

        [JsonProperty("percentages")]
        public Percentages Percentages { get; private set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; private set; }

        [JsonProperty("userid")]
        public ulong UserId { get; private set; }

        [JsonProperty("username")]
        public ulong Username { get; private set; }

        [JsonProperty("staff")]
        public bool IsStaff { get; private set; }

        [JsonProperty("thumbs")]
        public IEnumerable<Thumbs>? Thumbnails { get; private set; }

        [JsonProperty("isAdmin")]
        public bool IsAdmin { get; private set; }

        [JsonProperty("last_contacts")]
        public LastContact? LastContacts { get; private set; }
    }
}