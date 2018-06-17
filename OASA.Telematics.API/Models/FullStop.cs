namespace OASA.Telematics.API.Models
{
    using Newtonsoft.Json;

    public class FullStop
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
        public object StopStreetGreek { get; set; }

        [JsonProperty("StopStreetEng")]
        public object StopStreetEnglish { get; set; }

        [JsonProperty("StopHeading")]
        public string StopHeading { get; set; }

        [JsonProperty("StopLat")]
        public string Latitude { get; set; }

        [JsonProperty("StopLng")]
        public string Longitude { get; set; }

        [JsonProperty("RouteStopOrder")]
        public string RouteStopOrder { get; set; }

        [JsonProperty("StopType")]
        public string StopType { get; set; }

        [JsonProperty("StopAmea")]
        public string StopAmea { get; set; }
    }
}
