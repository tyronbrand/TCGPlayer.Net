using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace TCGPlayer.Net
{
    public class TcgApiException : Exception
    {
        public HttpStatusCode StatusCode;
        public HttpResponseHeaders Headers;
        public string ReasonPhrase;
        public HttpRequestMessage RequestMessage;
        public bool IsSuccessStatusCode;

        public override string ToString()
        {
            return
                $"Code: {StatusCode}\nReason: {ReasonPhrase}\nRequest: {RequestMessage}\nHeaders: {Headers}";
        }
    }
}
