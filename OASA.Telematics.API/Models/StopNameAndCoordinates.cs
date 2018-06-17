namespace OASA.Telematics.Client.Models
{
    using Newtonsoft.Json;

    public class StopNameAndCoordinates
    {
        [JsonProperty("stop_descr")]
        public string StopDescriptionGreek { get; set; }

        [JsonProperty("stop_descr_matrix_eng")]
        public string StopDescriptionEnglish { get; set; }

        [JsonProperty("stop_lat")]
        public string Latitude { get; set; }

        [JsonProperty("stop_lng")]
        public string Longitude { get; set; }

        [JsonProperty("stop_heading")]
        public string Heading { get; set; }

        [JsonProperty("stop_id")]
        public string StopId { get; set; }
    }
}
