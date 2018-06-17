namespace OASA.Telematics.Client.Models
{
    using Newtonsoft.Json;

    public class LinesAndRoutesForMasterLine
    {
        [JsonProperty("afetiria")]
        public string StartNameGreek { get; set; }

        [JsonProperty("afetiria_en")]
        public string StartNameEnglish { get; set; }

        [JsonProperty("line_code")]
        public string LineCode { get; set; }

        [JsonProperty("line_descr")]
        public string LineDescription { get; set; }

        [JsonProperty("line_descr_eng")]
        public string LineDescriptionEnglish { get; set; }

        [JsonProperty("line_id")]
        public string LineIdEnglish { get; set; }

        [JsonProperty("line_id_gr")]
        public string LineIdGreek { get; set; }

        [JsonProperty("sdc_code")]
        public string ScheduleCode { get; set; }

        [JsonProperty("terma")]
        public string FinishNameGreek { get; set; }

        [JsonProperty("terma_en")]
        public string FinishNameEnglish { get; set; }
    }
}
