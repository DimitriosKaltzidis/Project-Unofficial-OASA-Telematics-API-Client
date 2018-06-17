namespace OASA.Telematics.API.Models
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class SchedLines
    {
        [JsonProperty("come")]
        public List<Come> Come { get; set; }


        [JsonProperty("go")]
        public List<Go> Go { get; set; }
    }
}
