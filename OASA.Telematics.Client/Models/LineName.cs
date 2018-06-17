namespace OASA.Telematics.Client.Models
{
    using Newtonsoft.Json;

    public class LineName
    {
        [JsonProperty("line_descr")]
        public string LineNameGreek { get; set; }

        [JsonProperty("line_descr_eng")]
        public string LineNameEnglish { get; set; }
    }
}
