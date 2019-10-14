using Newtonsoft.Json;

namespace OKCSharp.Objects
{
    public class PledgeText
    { 
        [JsonProperty("confirmation")]
        public string Confirmation { get; private set; }

        [JsonProperty("title")]
        public string Title { get; private set; }

        [JsonProperty("content")]
        public string Content { get; private set; }
    }
}