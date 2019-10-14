using Newtonsoft.Json;
using System.Collections.Generic;

namespace OKCSharp.Objects
{
    public class CardActionPayload
    {
        [JsonProperty("source")]
        public string Score { get; private set; } = "PROFILE";

        [JsonProperty("votes")]
        public IEnumerable<ProfileVote> Votes { get; internal set; }
    }
}
