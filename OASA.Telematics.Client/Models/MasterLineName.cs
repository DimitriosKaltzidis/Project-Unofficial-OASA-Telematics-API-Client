namespace OASA.Telematics.Client.Models
{
    using Newtonsoft.Json;

    public class MasterLineName
    {
        [JsonProperty("ml_descr")]
        public string MasterLineNameGreek { get; set; }

        [JsonProperty("ml_descr_eng")]
        public object MasterLineNameEnglish { get; set; }
    }
}
