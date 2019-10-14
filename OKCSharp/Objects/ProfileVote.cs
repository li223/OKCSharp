using Newtonsoft.Json;

namespace OKCSharp.Objects
{
    public class ProfileVote
    {
        [JsonProperty("userid")]
        public ulong UserId { get; internal set; }

        [JsonProperty("like")]
        public bool IsLike { get; internal set; }

        [JsonProperty("time_from_request")]
        public int TimeFromRequest { get; private set; } = 0;
    }
}