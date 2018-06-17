namespace OASA.Telematics.API.Models
{
    using Newtonsoft.Json;

    public class RouteDetails
    {
        [JsonProperty("routed_x")]
        public string Latitude { get; set; }

        [JsonProperty("routed_y")]
        public string Longitude { get; set; }

        [JsonProperty("routed_order")]
        public string Order { get; set; }
    }
}
