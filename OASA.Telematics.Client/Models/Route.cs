namespace OASA.Telematics.Client.Models
{
    using Newtonsoft.Json;

    public class Route
    {
        [JsonProperty("RouteCode")]
        public string RouteCode { get; set; }

        [JsonProperty("LineCode")]
        public string LineCode { get; set; }

        [JsonProperty("RouteDescr")]
        public string RouteDescriptionGreek { get; set; }

        [JsonProperty("RouteDescrEng")]
        public string RouteDescriptionEnglish { get; set; }

        [JsonProperty("RouteType")]
        public string RouteType { get; set; }

        [JsonProperty("RouteDistance")]
        public string RouteDistance { get; set; }

        #region RouteForStopFields

        [JsonProperty("LineID")]
        public string LineId { get; set; }

        [JsonProperty("LineDescr")]
        public string LineDescriptionGreek { get; set; }

        [JsonProperty("LineDescrEng")]
        public string LineDescriptionEnglish { get; set; }

        [JsonProperty("MasterLineCode")]
        public string MasterLineCode { get; set; }

        #endregion
    }
}
