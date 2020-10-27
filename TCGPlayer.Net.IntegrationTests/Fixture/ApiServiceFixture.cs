using System.Threading.Tasks;

namespace TCGPlayer.Net.IntegrationTests.Fixture
{
    public class ApiServiceFixture
    {
        public ITcgApiService _apiService;

        public string _publicKey = "";
        public string _privateKey = "";        

        public async Task CreateApiServiceAsync()
        {
            if(_apiService == null)
            {
                var token = await TcgApiService.Authorize(_publicKey, _privateKey);

                _apiService = TcgApiService.CreateDefaultApi(token);
            }
        }
    }
}
