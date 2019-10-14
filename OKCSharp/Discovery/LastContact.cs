using Newtonsoft.Json;

namespace OKCSharp.DiscoveryObjects
{
    public class LastContact
    {
        [JsonProperty("forward")]
        public ulong Forward { get; set; }

        [JsonProperty("reverse")]
        public ulong Reverse { get; set; }
    }
}