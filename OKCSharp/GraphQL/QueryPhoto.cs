using Newtonsoft.Json;
using System;

namespace OKCSharp.GraphQL
{
    public class QueryPhoto
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("square225")]
        public Uri? ImageUri { get; set; }

        [JsonProperty("original")]
        public Uri? OriginalImageUri { get; set; }

        [JsonProperty("__typename")]
        public string TypeName { get; set; }
    }
}