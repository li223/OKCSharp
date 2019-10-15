using Newtonsoft.Json;

namespace OKCSharp.Search
{
    public class Cursors
    {
        [JsonProperty("before")]
        public string Before { get; private set; }

        [JsonProperty("current")]
        public string Current { get; private set; }

        [JsonProperty("after")]
        public string After { get; private set; }
    }
}