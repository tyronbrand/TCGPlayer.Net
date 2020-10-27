using Newtonsoft.Json;

namespace TCGPlayer.Net.Dtos
{
    public class SKUMarketPriceDto
    {
        [JsonProperty("skuId")]
        public int SkuId { get; set; }

        [JsonProperty("lowPrice")]
        public double? LowPrice { get; set; }

        [JsonProperty("lowestShipping")]
        public double? LowestShipping { get; set; }

        [JsonProperty("lowestListingPrice")]
        public double? LowestListingPrice { get; set; }

        [JsonProperty("marketPrice")]
        public double? MarketPrice { get; set; }

        [JsonProperty("directLowPrice")]
        public double? DirectLowPrice { get; set; }
    }
}
