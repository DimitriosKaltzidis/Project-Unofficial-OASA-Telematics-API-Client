namespace OASA.Telematics.API.Models
{
    using Newtonsoft.Json;

    public class Localizations
    {
        [JsonProperty("lang_id")]
        public string LanguageId { get; set; }

        [JsonProperty("el")]
        public string Greek { get; set; }

        [JsonProperty("en")]
        public string English { get; set; }
    }
}
