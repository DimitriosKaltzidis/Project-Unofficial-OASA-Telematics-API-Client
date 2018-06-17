namespace OASA.Telematics.API.Client
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    public class ApiClient
    {
        public static async Task<TR> Post<TR>(string url)
            where TR : class
        {
            var result = await GetPostResponse(url);
            var responseData = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (!((int)result.StatusCode >= 200 && (int)result.StatusCode < 300))
            {
                throw new ApplicationException(responseData);
            }

            return JsonConvert.DeserializeObject<TR>(responseData);
        }

        private static async Task<HttpResponseMessage> GetPostResponse(string url)
        {
            var client = new HttpClient();

            var uri = $"{url}";

            // Request body
            var response = await client.PostAsync(uri, null);

            return response;
        }
    }
}
