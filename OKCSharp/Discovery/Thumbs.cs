using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace OKCSharp.DiscoveryObjects
{
    public class Thumbs
    {
        [JsonProperty("info")]
        public ThumbsInfo? Info { get; private set; }

        [JsonExtensionData]
        public IDictionary<string, JToken>? Sizes { get; private set; }
    }
}