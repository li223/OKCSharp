using Newtonsoft.Json;

namespace OKCSharp.DiscoveryObjects
{
    public class ThumbsInfo
    {
        [JsonProperty("path")]
        public string Path { get; private set; }

        [JsonProperty("when_taken")]
        public ulong WhenTaken { get; private set; }

        [JsonProperty("type")]
        public int Type { get; private set; }

        [JsonProperty("lower_right_x")]
        public int LowerRightX { get; private set; }

        [JsonProperty("lower_right_y")]
        public int LowerRightY { get; private set; }

        [JsonProperty("ordinal")]
        public int Ordinal { get; private set; }

        [JsonProperty("caption")]
        public string Caption { get; private set; }

        [JsonProperty("width")]
        public int Width { get; private set; }

        [JsonProperty("height")]
        public int Height { get; private set; }

        [JsonProperty("has_photos")]
        public bool HasPhotos { get; private set; }

        [JsonProperty("upper_left_x")]
        public ulong UppperLeftX{ get; private set; }

        [JsonProperty("upper_left_y")]
        public int UppperLeftY { get; private set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; private set; }

        [JsonProperty("picid")]
        public ulong PicId { get; private set; }
    }
}