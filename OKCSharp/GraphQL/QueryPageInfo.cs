using Newtonsoft.Json;

namespace OKCSharp.GraphQL
{
    public class QueryPageInfo
    {
        /// <summary>
        /// After token to get more data
        /// </summary>
        [JsonProperty("after")]
        public string After { get; private set; }

        /// <summary>
        /// If there is more data to get
        /// </summary>
        [JsonProperty("hasMore")]
        public bool HasMore { get; private set; }

        /// <summary>
        /// Type name of this object
        /// </summary>
        [JsonProperty("__typename")]
        public string TypeName { get; private set; }
    }
}