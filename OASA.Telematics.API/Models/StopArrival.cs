namespace OASA.Telematics.API.Models
{
    using Newtonsoft.Json;

    public class StopArrival
    {
        [JsonProperty("route_code")]
        public string RouteCode { get; set; }

        [JsonProperty("veh_code")]
        public string VehicleCode { get; set; }

        [JsonProperty("btime2")]
        public string BTime2 { get; set; }
    }
}