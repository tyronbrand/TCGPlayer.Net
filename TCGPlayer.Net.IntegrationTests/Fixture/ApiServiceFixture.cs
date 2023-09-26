using System.Net.Http;
using System.Threading.Tasks;

namespace TCGPlayer.Net.IntegrationTests.Fixture
{
    public class ApiServiceFixture
    {
        public ITcgApiService _apiService;

        public async Task CreateApiServiceAsync()
        {
            if (_apiService == null)
            {
                var publicKey = "";
                var privateKey = "";
                var userAgent = "";

                var httpClient = new HttpClient();
                var tcgPlayerService = new TcgApiService(httpClient);
                await tcgPlayerService.Authorize(publicKey, privateKey, userAgent);

                _apiService = tcgPlayerService;
            }
        }
    }
}
