using Newtonsoft.Json;

namespace TCGPlayer.Net.Dtos
{
    public class ProductPriceDto
    {
        [JsonProperty("productId")]
        public int ProductId { get; set; }

        [JsonProperty("lowPrice")]
        public double? LowPrice { get; set; }

        [JsonProperty("midPrice")]
        public double? MidPrice { get; set; }

        [JsonProperty("highPrice")]
        public double? HighPrice { get; set; }

        [JsonProperty("marketPrice")]
        public double? MarketPrice { get; set; }

        [JsonProperty("directLowPrice")]
        public double? DirectLowPrice { get; set; }

        [JsonProperty("subTypeName")]
        public string SubTypeName { get; set; }
    }
}
