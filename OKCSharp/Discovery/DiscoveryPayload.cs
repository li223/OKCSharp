using Newtonsoft.Json;

namespace OKCSharp.DiscoveryObjects
{
    public struct DiscoveryPayload
    {
        [JsonProperty("section")]
        public string Section { get; internal set; }

        [JsonProperty("limit")]
        public int Limit { get; internal set; }
    }
}
