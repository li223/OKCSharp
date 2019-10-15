using Newtonsoft.Json;

namespace OKCSharp.Search
{
    public class SearchPayload
    {
        [JsonProperty("order_by")]
        public string OrderBy { get; set; }

        [JsonProperty("gentation")]
        public int[] Gentation { get; private set; }

        [JsonProperty("gender_tags")]
        public string GenderTags { get; set; }

        [JsonProperty("orientation_tags")]
        public OrientationTags OrientationTags { get; set; }

        [JsonProperty("minimum_age")]
        public int MinimumAge { get; set; } = 18;

        [JsonProperty("maximum_age")]
        public int MaximumAge { get; set; }

        [JsonProperty("locid")]
        public int LocationId { get; set; } = 459348;

        [JsonProperty("radius")]
        public int Radius { get; set; } = 50;

        [JsonProperty("lquery")]
        public string LQuery { get; set; }

        [JsonProperty("location")]
        public SearchLocation Location { get; set; }

        [JsonProperty("located_anywhere")]
        private int Located_Anywhere { get; set; }

        [JsonIgnore]
        public bool LocatedAnywhere { get => this.Located_Anywhere == 1; set => this.Located_Anywhere = (value) ? 1 : 0; }

        [JsonProperty("last_login")]
        public ulong LastLoggedIn { get; set; } = 100;

        [JsonProperty("i_want")]
        public string IWant { get; set; }

        [JsonProperty("they_want")]
        public string TheyWant { get; set; }

        [JsonProperty("minimum_height")]
        public string MinimumHeight { get; set; }

        [JsonProperty("maximum_height")]
        public string MaximumHeight { get; set; }

        [JsonProperty("languages")]
        public int Languages { get; set; } = 0;

        [JsonProperty("speaks_my_language")]
        public bool SpeaksMyLanguage { get; set; } = false;

        [JsonProperty("ethnicity")]
        public string[] Ethnicity { get; set; }

        [JsonProperty("religion")]
        public string[] Religion { get; set; }

        [JsonProperty("availability")]
        public string Availability { get; set; } = "single";

        [JsonProperty("monogamy")]
        public string Monogamy { get; set; } = "unknown";

        [JsonProperty("looking_for")]
        public string[] LookingFor { get; set; }

        [JsonProperty("smoking")]
        public string[] Smoking { get; set; }

        [JsonProperty("drinking")]
        public string[] Drinking { get; set; }

        [JsonProperty("drugs")]
        public string[] Drugs { get; set; }

        [JsonProperty("answers")]
        public string[] Answers { get; set; }

        [JsonProperty("interest_ids")]
        public int[] InterestIds { get; private set; }

        [JsonProperty("education")]
        public string[] Education { get; set; }

        [JsonProperty("children")]
        public string[] Children { get; set; }

        [JsonProperty("cats")]
        public string[] Cats { get; set; }

        [JsonProperty("dogs")]
        public string[] Dogs { get; set; }

        [JsonProperty("tagOrder")]
        public string[] TagOrder { get; set; } = new[] { "availability", "order_by" };

        [JsonProperty("save_search")]
        public bool SaveSearch { get; private set; } = false;

        [JsonProperty("limit")]
        public int Limit { get; set; } = 20;

        [JsonProperty("fields")]
        public string Fields { get; private set; } = "userinfo,thumbs,percentages,likes,last_contacts,last_login,online";

    }
}
