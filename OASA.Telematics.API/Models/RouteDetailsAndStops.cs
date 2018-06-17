namespace OASA.Telematics.API.Models
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class RouteDetailsAndStops
    {
        [JsonProperty("details")]
        public List<RouteDetails> Details { get; set; }

        [JsonProperty("stops")]
        public List<Stop> Stops { get; set; }
    }
}
