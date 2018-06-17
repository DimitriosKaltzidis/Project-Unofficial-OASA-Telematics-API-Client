namespace OASA.Telematics.API.Models
{
    using Newtonsoft.Json;

    public class ScheduleDaysMasterLine
    {
        [JsonProperty("sdc_descr")]
        public string ScheduleDescriptionGreek { get; set; }

        [JsonProperty("sdc_descr_eng")]
        public string ScheduleDescriptionEnglish { get; set; }

        [JsonProperty("sdc_code")]
        public string ScheduleCode { get; set; }

        [JsonProperty("")]
        public string SomeFlagPossibly { get; set; }
    }
}
