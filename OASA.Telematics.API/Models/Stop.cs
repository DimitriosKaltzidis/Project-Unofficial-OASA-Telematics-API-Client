namespace OASA.Telematics.API.Models
{
    using Newtonsoft.Json;

    public class Stop
    {
        [JsonProperty("StopCode")]
        public string StopCode { get; set; }

        [JsonProperty("StopID")]
        public string StopId { get; set; }

        [JsonProperty("StopDescr")]
        public string StopDescriptionGreek { get; set; }

        [JsonProperty("StopDescrEng")]
        public string StopDescriptionEnglish { get; set; }

        [JsonProperty("StopStreet")]
        public string StopStreetGreek { get; set; }

        [JsonProperty("StopStreetEng")]
        public object StopStreetEnglish { get; set; }

        [JsonProperty("StopHeading")]
        public string Heading { get; set; }

        [JsonProperty("StopLat")]
        public string Latitude { get; set; }

        [JsonProperty("StopLng")]
        public string Longitude { get; set; }

        [JsonProperty("distance")]
        public string Distance { get; set; }
    }
}
