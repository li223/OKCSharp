using Newtonsoft.Json;
using OKCSharp.User;
using System.Collections;
using System.Collections.Generic;

namespace OKCSharp.Search
{
    public class SearchResult
    {
        [JsonProperty("total_matches")]
        public int TotalMatches { get; private set; }

        [JsonProperty("data")]
        public IEnumerable<UserProfile> Data { get; private set; }

        [JsonProperty("paging")]
        public SearchPaging Paging { get; set; }
    }
}