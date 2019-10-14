using Newtonsoft.Json;
using System.Collections.Generic;
using OKCSharp.GraphQL;

namespace OKCSharp.User
{
    public class UserLikesData
    {
        [JsonProperty("previousViewTime")]
        public ulong PreviewsViewTime { get; private set; }

        [JsonProperty("data")]
        public IEnumerable<UserLike>? Data { get; private set; }

        [JsonProperty("pageInfo")]
        public QueryPageInfo? PageInfo { get; private set; }

        [JsonProperty("__typename")]
        public string TypeName { get; private set; }
    }
}