using Newtonsoft.Json;
using OKCSharp.GraphQL;

namespace OKCSharp
{
    public class Essay
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("groupId")]
        public ulong GroupId { get; set; }

        [JsonProperty("groupTitle")]
        public string GroupTitle { get; set; }

        [JsonProperty("isPassion")]
        public bool IsPassion { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("placeholder")]
        public string Placeholder { get; set; }

        [JsonProperty("rawContent")]
        public string RawContent { get; set; }

        [JsonProperty("processedContent")]
        public string ProcessedContent { get; set; }

        [JsonProperty("picture")]
        public QueryPhoto? Picture { get; set; }

        [JsonProperty("__typename")]
        public string TypeName { get; set; }
    }
}