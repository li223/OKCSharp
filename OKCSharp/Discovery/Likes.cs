using Newtonsoft.Json;

namespace OKCSharp.DiscoveryObjects
{
    public class Likes
    {
        [JsonProperty("mutual_like_vote")]
        public int MutualLikeVote { get; private set; }

        [JsonProperty("recycled")]
        public int Recycled { get; private set; }

        [JsonProperty("passed_on")]
        public int PassedOn { get; private set; }

        [JsonProperty("they_like")]
        public object? TheyLike { get; private set; }

        [JsonProperty("you_like")]
        public object? YouLike { get; private set; }

        [JsonProperty("via_spotlight")]
        public object? ViaSpotlight { get; private set; }

        [JsonProperty("mutual_like")]
        public int MutualLike { get; private set; }

        [JsonProperty("vote")]
        public object? Vote { get; private set; }

    }
}