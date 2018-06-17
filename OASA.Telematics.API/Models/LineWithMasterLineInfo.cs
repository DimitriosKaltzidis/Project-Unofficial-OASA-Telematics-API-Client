namespace OASA.Telematics.Client.Models
{
    using Newtonsoft.Json;

    public class LineWithMasterLineInfo
    {
        [JsonProperty("ml_code")]
        public string MasterLineCode { get; set; }

        [JsonProperty("sdc_code")]
        public string SdcCode { get; set; }

        [JsonProperty("line_code")]
        public string LineCode { get; set; }

        [JsonProperty("line_id")]
        public string LineId { get; set; }

        [JsonProperty("line_descr")]
        public string LineDescriptionGreek { get; set; }

        [JsonProperty("line_descr_eng")]
        public string LineDescriptionEnglish { get; set; }
    }
}
