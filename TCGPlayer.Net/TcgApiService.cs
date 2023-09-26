using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TCGPlayer.Net.Models;

namespace TCGPlayer.Net
{
    public class TcgApiService : ITcgApiService
    {
        private ITcgApiProxy _tcgApiProxy;
        private HttpClient _httpClient;

        public TcgApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.BaseAddress = new Uri("https://api.tcgplayer.com");
        }

        public async Task<TcgApiResult<TResult>> Execute<TParams, TResult>(ApiActionAttributes<TParams, TResult> apiAction, TParams @params)
        {
            switch (apiAction.Method)
            {
                case HttpMethods.GET:
                    {
                        var getQueryParams = @params as IQueryStringParams;
                        var serializedResult = await _tcgApiProxy.Get(apiAction.Action, getQueryParams);
                        return JsonConvert.DeserializeObject<TcgApiResult<TResult>>(serializedResult.Results);
                    }
                case HttpMethods.POST:
                    {
                        var postQueryParams = @params as IJsonQueryParams;
                        var serializedResult = await _tcgApiProxy.Post(apiAction.Action, postQueryParams);
                        return JsonConvert.DeserializeObject<TcgApiResult<TResult>>(serializedResult.Results);
                    }
                case HttpMethods.PUT:
                    {
                        var putQueryParams = @params as IJsonQueryParams;
                        var serializedResult = await _tcgApiProxy.Put(apiAction.Action, putQueryParams);
                        return JsonConvert.DeserializeObject<TcgApiResult<TResult>>(serializedResult.Results);
                    }
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public async Task Authorize(string publicKey, string privateKey, string userAgent = null)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, "https://api.tcgplayer.com/token")
            {
                Content = new StringContent(
                $"grant_type=client_credentials&client_id={publicKey}&client_secret={privateKey}",
                Encoding.UTF8,
                "application/json")
            };

            if (!string.IsNullOrEmpty(userAgent))
                _httpClient.DefaultRequestHeaders.Add("User-Agent", userAgent);

            var result = await _httpClient.SendAsync(request);

            if (result.IsSuccessStatusCode)
            {
                var respData = await result.Content.ReadAsStringAsync();
                JsonSerializerSettings settings = new JsonSerializerSettings
                {
                    MissingMemberHandling = MissingMemberHandling.Error
                };

                var token = JsonConvert.DeserializeObject<TcgToken>(respData, settings);

                if (!string.IsNullOrEmpty(userAgent))
                    token.UserAgent = userAgent;

                _tcgApiProxy = new TcgApiProxy(_httpClient, token);
            }
            else
            {
                throw new TcgApiException()
                {
                    StatusCode = result.StatusCode,
                    Headers = result.Headers,
                    ReasonPhrase = result.ReasonPhrase,
                    RequestMessage = result.RequestMessage,
                    IsSuccessStatusCode = result.IsSuccessStatusCode
                };
            }
        }
    }
}
