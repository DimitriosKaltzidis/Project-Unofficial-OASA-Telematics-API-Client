namespace OASA.Telematics.Client.Client
{
    using System.Threading.Tasks;

    public class PostCommand<TR> where TR : class
    {
        public PostCommand(string actionUrl)
        {
            this.ActionUrl = $"{Config.BaseUrl}{actionUrl}";
        }

        public string ActionUrl { get; private set; }

        public async Task<TR> Execute(string key = null)
        {
            return await ApiClient.Post<TR>(this.ActionUrl);
        }
    }
}
