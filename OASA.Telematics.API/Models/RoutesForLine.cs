namespace OASA.Telematics.Client.Models
{
    using Newtonsoft.Json;

    public class RoutesForLine
    {
        [JsonProperty("route_code")]
        public string RouteCode { get; set; }

        [JsonProperty("route_id")]
        public string RouteId { get; set; }

        [JsonProperty("route_descr")]
        public string RouteDescriptionGreek { get; set; }

        [JsonProperty("route_active")]
        public string RouteActive { get; set; }

        [JsonProperty("route_descr_eng")]
        public string RouteDescriptionEnglish { get; set; }
    }
}
