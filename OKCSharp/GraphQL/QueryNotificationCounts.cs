using Newtonsoft.Json;

namespace OKCSharp.GraphQL
{
    public class QueryNotificationCounts
    {
        [JsonProperty("likesIncoming")]
        public int LikesIncoming { get; private set; }

        [JsonProperty("__typename")]
        public string TypeName { get; private set; }
    }
}