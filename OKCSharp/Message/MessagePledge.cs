using Newtonsoft.Json;

namespace OKCSharp.Objects
{
    public class MessagePledge
    {
        [JsonProperty("text")]
        public PledgeText? Text { get; private set; }

        [JsonProperty("understands")]
        public bool UnderstandsPledge { get; private set; }
    }
}