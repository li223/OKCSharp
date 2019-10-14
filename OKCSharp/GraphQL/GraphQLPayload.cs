using Newtonsoft.Json;
using System.Collections.Generic;

namespace OKCSharp
{
    public class GraphQLPayload
    {
        [JsonProperty("operationName")]
        public string OperationName { get; set; }

        [JsonProperty("variables")]
        public Dictionary<string, string>? Variables { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }
    }
}