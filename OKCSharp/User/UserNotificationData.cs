using Newtonsoft.Json;
using OKCSharp.GraphQL;

namespace OKCSharp.User
{
    public class UserNotificationData
    {
        [JsonProperty("notificationCounts")]
        public QueryNotificationCounts? NotificationCounts { get; private set; }

        [JsonProperty("__typename")]
        public string TypeName { get; private set; }

        [JsonProperty("likes")]
        public UserLikesData? Likes { get; private set; }
    }
}