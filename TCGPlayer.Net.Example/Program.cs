using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using TCGPlayer.Net.Models;

namespace TCGPlayer.Net.Example
{
    public class Program
    {
        public static async Task Main()
        {
            // Create Token
            var publicKey = "";
            var privateKey = "";
            var userAgent = "";

            var httpClient = new HttpClient();
            var tcgPlayerService = new TcgApiService(httpClient);
            await tcgPlayerService.Authorize(publicKey, privateKey, userAgent);

            // Create Request
            var @params = new ListAllGroupsDetailsGETRequestParams
            {
                CategoryId = 1
            };
            var result = await tcgPlayerService.Execute(TcgApiUrls.Catalog.ListAllGroupsDetails, @params);

            Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            Console.ReadKey();
        }
    }
}
