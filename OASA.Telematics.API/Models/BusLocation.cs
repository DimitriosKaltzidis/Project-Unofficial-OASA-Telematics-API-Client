namespace OASA.Telematics.Client.Models
{
    using Newtonsoft.Json;

    public class BusLocation
    {
        [JsonProperty("VEH_NO")]
        public string VehicleNumber { get; set; }

        [JsonProperty("CS_DATE")]
        public string DateTime { get; set; }

        [JsonProperty("CS_LAT")]
        public string Latitude { get; set; }

        [JsonProperty("CS_LNG")]
        public string Longitude { get; set; }

        [JsonProperty("ROUTE_CODE")]
        public string RouteCode { get; set; }
    }
}
