using Newtonsoft.Json;
using OKCSharp.DiscoveryObjects;

namespace OKCSharp.User
{
    public class UserLike
    {
        [JsonProperty("matchPercent")]
        public int MatchPercent { get; private set; }

        [JsonProperty("senderLikeTime")]
        public ulong? SenderLikeTime { get; set; }

        [JsonProperty("targetLikeTime")]
        public ulong? TargetLikeTime { get; set; }

        [JsonProperty("likeTime")]
        public ulong? LikeTime { get; set; }

        [JsonProperty("senderMessageTime")]
        public ulong? SenderMessageTime { get; set; }

        [JsonProperty("targetMessageTime")]
        public ulong? TargetMessageTime { get; set; }

        [JsonProperty("targetLikeViaSpotlight")]
        public ulong? TargetLikeViaSpotlight { get; set; }

        [JsonProperty("senderPassed")]
        public bool SenderPassed { get; set; }

        [JsonProperty("user")]
        public UserInfo? User { get; set; }

        [JsonProperty("__typename")]
        public string TypeName { get; set; }
    }
}