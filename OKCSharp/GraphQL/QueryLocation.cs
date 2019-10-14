using Newtonsoft.Json;

namespace OKCSharp.GraphQL
{
    public class QueryLocation
    {
        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("__typename")]
        public string TypeName { get; set; }
    }
}