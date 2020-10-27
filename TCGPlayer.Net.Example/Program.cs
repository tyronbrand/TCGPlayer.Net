using Newtonsoft.Json;
using System;
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

            var token = await TcgApiService.Authorize(publicKey, privateKey, userAgent);

            // Create ApiService
            var apiService = TcgApiService.CreateDefaultApi(token);

            // Create Request
            var @params = new ListAllGroupsDetailsGETRequestParams
            {
                CategoryId = 1
            };
            var result = await apiService.Execute(TcgApiUrls.Catalog.ListAllGroupsDetails, @params);

            Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            Console.ReadKey();
        }
    }
}
