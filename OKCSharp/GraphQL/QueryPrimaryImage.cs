using Newtonsoft.Json;
using System;

namespace OKCSharp.GraphQL
{
    public class QueryPrimaryImage
    {
        [JsonProperty("square225")]
        public Uri? PhotoUri { get; set; }

        [JsonProperty("__typename")]
        public string TypeName { get; set; }
    }
}