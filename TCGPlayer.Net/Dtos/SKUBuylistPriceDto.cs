using Newtonsoft.Json;

namespace TCGPlayer.Net.Dtos
{
    public class SKUBuylistPriceDto
    {
        [JsonProperty("skuId")]
        public int SkuId { get; set; }

        [JsonProperty("prices")]
        public SKUBuylistPricesDto Prices { get; set; }
    }

    public class SKUBuylistPricesDto
    {
        [JsonProperty("high")]
        public double? High { get; set; }

        [JsonProperty("market")]
        public double? Market { get; set; }
    }
}
