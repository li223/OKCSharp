using Newtonsoft.Json;
using OKCSharp.GraphQL;
using System.Collections.Generic;

namespace OKCSharp.User
{
    public class CurrentUserProfile : UserInfo
    {
        [JsonProperty("staffbadge")]
        public object? StaffBadge { get; private set; }

        [JsonProperty("hasPhotos")]
        public bool HasPhotos { get; set; }

        [JsonProperty("photos")]
        public QueryPhoto? Photos { get; set; }

        [JsonProperty("essaysWithDefaults")]
        public IEnumerable<Essay>? Essays { get; set; }
    }
}