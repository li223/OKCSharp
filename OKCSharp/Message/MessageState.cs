using Newtonsoft.Json;

namespace OKCSharp.Objects
{
    public class MessageState
    {
        [JsonProperty("conversationData")]
        public object? ConversationData { get; private set; }

        [JsonProperty("conversationOrder")]
        public object? ConversationOrder { get; private set; }

        [JsonProperty("enterToSend")]
        public bool PressEnterToSend { get; private set; }

        [JsonProperty("messagePledge")]
        public MessagePledge? MessagePledge { get; private set; }

        [JsonProperty("needsPhoneVerification")]
        public bool NeedsPhoneVerification { get; private set; }
    }
}