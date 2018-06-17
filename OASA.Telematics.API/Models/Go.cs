namespace OASA.Telematics.API.Models
{
    using Newtonsoft.Json;

    public class Go
    {
        [JsonProperty("line_id")]
        public string LineId { get; set; }

        [JsonProperty("sde_code")]
        public string SdeCode { get; set; }

        [JsonProperty("sdc_code")]
        public string SdcCode { get; set; }

        [JsonProperty("sds_code")]
        public string SdsCode { get; set; }

        [JsonProperty("sde_aa")]
        public string SdeAa { get; set; }

        [JsonProperty("sde_line1")]
        public string SdeLine1 { get; set; }

        [JsonProperty("sde_kp1")]
        public string Sdekp1 { get; set; }

        [JsonProperty("sde_start1")]
        public string SdeStart1 { get; set; }

        [JsonProperty("sde_end1")]
        public string SdeEnd1 { get; set; }

        [JsonProperty("sde_line2")]
        public string SdeLine2 { get; set; }

        [JsonProperty("sde_kp2")]
        public string Sdekp2 { get; set; }

        [JsonProperty("sde_start2")]
        public string SdeStart2 { get; set; }

        [JsonProperty("sde_end2")]
        public string SdeEnd2 { get; set; }

        [JsonProperty("sde_sort")]
        public string SdeDescription { get; set; }

        [JsonProperty("sde_descr1")]
        public string SdeDescription1 { get; set; }

        [JsonProperty("line_circle")]
        public string LineCircle { get; set; }

        [JsonProperty("line_descr")]
        public string LineDescriptionGreek { get; set; }

        [JsonProperty("line_descr_eng")]
        public string LineDescriptionEnglish { get; set; }
    }
}
