using Newtonsoft.Json;

namespace OKCSharp.Search
{
    public class SearchLocation
    {
        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("nameid")]
        public int NameId { get; set; } = 4424282;

        [JsonProperty("display_state")]
        public int DisplayState { get; set; } = 0;

        [JsonProperty("locid")]
        public int LocationId { get; set; } = 459348;

        [JsonProperty("state_code")]
        public string StateCode { get; set; } = "00";

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("longitude")]
        public float Longitude { get; set; }

        [JsonProperty("latitude")]
        public float Latitude { get; set; }

        [JsonProperty("popularity")]
        public int Popularity { get; set; }

        [JsonProperty("state_name")]
        public string StateName { get; set; }

        [JsonProperty("default_radius")]
        public int DefaultRadius { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("city_name")]
        public string CityName { get; set; }

        [JsonProperty("density")]
        public int Density { get; set; } = 2503;

        [JsonProperty("metro_area")]
        public int MetroArea { get; set; } = 0;
    }
}
