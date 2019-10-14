using Newtonsoft.Json;
using OKCSharp.DiscoveryObjects;
using System.Collections.Generic;

namespace OKCSharp.User
{
    public class UserLikeStatus
    {
        [JsonProperty("matches")]
        public IEnumerable<DiscoveryMatch>? Matches { get; private set; }

        [JsonProperty("extras")]
        public StatusExtras? Extras { get; private set; }
    }
}