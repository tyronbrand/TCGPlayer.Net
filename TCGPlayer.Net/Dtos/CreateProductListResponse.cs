using Newtonsoft.Json;

namespace TCGPlayer.Net.Dtos
{
    public class CreateProductListResponse
    {        
        [JsonProperty("productListKey")]
        public string ProductListKey { get; set; }
    }
}
