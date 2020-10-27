using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TCGPlayer.Net.Models;

namespace TCGPlayer.Net
{
    public class TcgApiProxy : ITcgApiProxy
    {
        private readonly HttpClient _httpClient;
        private readonly ITcgToken _token;

        public TcgApiProxy(ITcgToken tcgToken)
        {
            _token = tcgToken;

            _httpClient = new HttpClient { BaseAddress = new Uri("https://api.tcgplayer.com") };
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            if(!string.IsNullOrEmpty(tcgToken.UserAgent))
                _httpClient.DefaultRequestHeaders.Add("User-Agent", tcgToken.UserAgent);
        }

        public Task<TcgApiResult<string>> Get(string action, IQueryStringParams parameters)
        {
            var query = string.Empty;

            if (action.Contains("{") && action.Contains("}"))
            {
                var pathParameters = GetActionPathParams(action);

                var queryParams = parameters?.ToQueryString() ?? string.Empty;
                var querySplit = queryParams.Split('&');

                foreach (var pathParameter in pathParameters)
                {
                    var actionParamValue = querySplit.Where(w => w.ToLower().Contains(pathParameter.ToLower())).FirstOrDefault();
                    action = AddPathParamsToAction(action, pathParameter, actionParamValue.Substring(actionParamValue.IndexOf('=') + 1));
                }
            }
            else
            {
                query = parameters?.ToQueryString() ?? string.Empty;
            }

            var request = new HttpRequestMessage(HttpMethod.Get, GetVersion(action) + (string.IsNullOrWhiteSpace(query) ? string.Empty : "?" + query));

            CorrectUri(request);

            return SendAndGetResponseAsync(request);
        }

        public Task<TcgApiResult<string>> Post(string action, IJsonQueryParams parameters) => SendAndGetResponseAsync(HttpMethod.Post, action, parameters);

        public Task<TcgApiResult<string>> Put(string action, IJsonQueryParams parameters) => SendAndGetResponseAsync(HttpMethod.Put, action, parameters);

        private Task<TcgApiResult<string>> SendAndGetResponseAsync(HttpMethod method, string action, IJsonQueryParams parameters)
        {
            var content = parameters?.ToJson() ?? string.Empty;

            if (action.Contains("{") && action.Contains("}"))
            {
                var pathParameters = GetActionPathParams(action);

                if (!string.IsNullOrEmpty(content))
                {
                    var contentDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(content);

                    foreach (var pathParameter in pathParameters)
                    {
                        var actionParamValue = contentDictionary.Where(w => w.Key.ToLower().Contains(pathParameter.ToLower())).FirstOrDefault();
                        action = AddPathParamsToAction(action, pathParameter, actionParamValue.Value);
                        contentDictionary.Remove(actionParamValue.Key);                        
                    }

                    content = JsonConvert.SerializeObject(contentDictionary);
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }

            var url = GetVersion(action);
            var request = new HttpRequestMessage(method, url)
            {
                Content = new StringContent(content, Encoding.UTF8, "application/json")
            };

            CorrectUri(request);

            return SendAndGetResponseAsync(request);
        }

        private async Task<TcgApiResult<string>> SendAndGetResponseAsync(HttpRequestMessage request)
        {
            request.Headers.Add("Authorization", $"bearer {_token.AccessToken}");

            var response = await _httpClient.SendAsync(request);
            var responseString = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new TcgApiException();
            }

            return new TcgApiResult<string>(responseString);
        }

        private static string GetVersion(string action) => "/v1.39.0/" + action;

        private static void CorrectUri(HttpRequestMessage request)
        {
            request.RequestUri = new Uri(request.RequestUri.OriginalString, UriKind.Relative);
        }

        private static string[] GetActionPathParams(string action)
        {
            var regex = new Regex("(?<=\\{)[^}]*(?=\\})");
            return regex.Matches(action)
                .OfType<Match>()
                .Select(m => m.Groups[0].Value)
                .ToArray();
        }

        private static string AddPathParamsToAction(string action, string pathParam, string pathParamValue)
        {
            if (!string.IsNullOrEmpty(pathParamValue))
            {
                return action.Replace($"{{{pathParam}}}", pathParamValue);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
