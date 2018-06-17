namespace OASA.Telematics.API.Models
{
    using Newtonsoft.Json;

    public class MasterLine
    {
        [JsonProperty("ml_code")]
        public string MasterLineCode { get; set; }

        [JsonProperty("ml_descr")]
        public string MasterLineDescriptionGreek { get; set; }

        [JsonProperty("ml_descr_eng")]
        public object MasterLineDescriptionEnglish { get; set; }

        [JsonProperty("ml_id")]
        public string MasterLineId { get; set; }

        [JsonProperty("sdc_code")]
        public string SdcCode { get; set; }

        [JsonProperty("line_code")]
        public string LineCode { get; set; }

        [JsonProperty("is_complex")]
        public string IsComplex { get; set; }
    }
}
