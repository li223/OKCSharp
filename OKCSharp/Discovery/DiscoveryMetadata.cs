using Newtonsoft.Json;
using OKCSharp.Objects;

namespace OKCSharp.DiscoveryObjects
{
    public struct DiscoveryMetadata
    {
        [JsonProperty("section")]
        public DiscoverySection Section { get; private set; }
    }
}