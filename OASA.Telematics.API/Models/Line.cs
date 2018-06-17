namespace OASA.Telematics.Client.Models
{
    using Newtonsoft.Json;

    public class Line
    {
        [JsonProperty("LineCode")]
        public string LineCode { get; set; }

        [JsonProperty("LineID")]
        public string LineId{ get; set; }

        [JsonProperty("LineDescr")]
        public string LineDescriptionGreek { get; set; }

        [JsonProperty("LineDescrEng")]
        public string LineDescriptionEnglish { get; set; }
    }
}
