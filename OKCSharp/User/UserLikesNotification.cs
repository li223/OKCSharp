using Newtonsoft.Json;

namespace OKCSharp.User
{
    public class UserLikesNotification
    {
        [JsonProperty("user")]
        public UserNotificationData? NotificationData { get; private set; }
    }
}