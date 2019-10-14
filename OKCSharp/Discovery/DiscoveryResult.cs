using Newtonsoft.Json;
using OKCSharp.Objects;
using System.Collections.Generic;

namespace OKCSharp.DiscoveryObjects
{
    public class DiscoveryResult
    {
        [JsonProperty("layout")]
        public string Layout { get; private set; }

        //Not my proudest fap
        [JsonProperty("rows")]
        public IEnumerable<ApiResponse<IEnumerable<DiscoveryMatch>>>? Rows { get; private set; }
    }
}