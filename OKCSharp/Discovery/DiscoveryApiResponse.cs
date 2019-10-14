using Newtonsoft.Json;
using OKCSharp.Objects;
using System.Collections.Generic;

namespace OKCSharp.DiscoveryObjects
{
    public class DiscoveryApiResponse
    {
        [JsonProperty("section_header")]
        public object? SectionHeader { get; private set; }

        [JsonProperty("section_id")]
        public DiscoverySection SectionId { get; private set; }

        [JsonProperty("metadata")]
        public DiscoveryMetadata Metadata { get; private set; }

        [JsonProperty("title")]
        public string Title { get; private set; }

        [JsonProperty("header_component")]
        public object? HeaderComponent { get; private set; }
        
        [JsonProperty("footer_component")]
        public object? FooterComponent { get; private set; }

        [JsonProperty("results")]
        public DiscoveryResult? Results { get; private set; }
    }
}
