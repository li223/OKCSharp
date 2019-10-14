using Newtonsoft.Json;

namespace OKCSharp.Objects
{
    public class ApiResponse<T> where T : class
    {
        [JsonProperty("data")]
        public T? ApiData { get; private set; }
    }
}
