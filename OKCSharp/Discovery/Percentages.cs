using Newtonsoft.Json;

namespace OKCSharp.DiscoveryObjects
{
    public struct Percentages
    {
        [JsonProperty("match")]
        public int Match { get; private set; }

        [JsonProperty("enemy")]
        public int Enemy { get; private set; }
    }
}