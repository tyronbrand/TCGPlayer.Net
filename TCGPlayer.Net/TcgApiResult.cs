using Newtonsoft.Json;
using System.Collections.Generic;

namespace TCGPlayer.Net
{
    public class TcgApiResult<TResult>
    {
        public TcgApiResult() {}

        internal TcgApiResult(TResult results)
        {
            this.Results = results;
        }

        [JsonProperty("results")]
        public TResult Results { get; set; }

        [JsonProperty("totalItems")]
        public int TotalItems { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("errors")]
        public List<string> Errors { get; set; }        
    }
}
