using Newtonsoft.Json;

namespace OKCSharp.Search
{
    public class SearchPaging
    {
        [JsonProperty("cursors")]
        public Cursors Cursors { get; private set; }

        [JsonProperty("end")]
        public bool IsEnd { get; private set; }
    }
}