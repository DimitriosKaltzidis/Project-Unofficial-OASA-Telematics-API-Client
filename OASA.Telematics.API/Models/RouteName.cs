namespace OASA.Telematics.Client.Models
{
    using Newtonsoft.Json;

    public class RouteName
    {
        [JsonProperty("route_descr")]
        public string RouteNameGreek { get; set; }

        [JsonProperty("route_departure_eng")]
        public string RouteNameEnglish { get; set; }
    }
}
