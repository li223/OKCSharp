using Newtonsoft.Json;

namespace OKCSharp
{
    public class StatusExtras
    {
        [JsonProperty("likesRemaining")]
        public int LikesRemaining { get; set; }

        [JsonProperty("likesCapResetTime")]
        public ulong LikesCapResetTime { get; set; }

        [JsonProperty("shouldTrackHitLikesCap")]
        public bool ShouldTrackHitLikesCap { get; set; }
    }
}