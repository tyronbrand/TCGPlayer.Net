using Newtonsoft.Json;

namespace TCGPlayer.Net.Dtos
{
    public class ProductBuylistDto
    {
        [JsonProperty("productId")]
        public int ProductId { get; set; }

        [JsonProperty("prices")]
        public ProductBuylistPriceDto Prices { get; set; }

        [JsonProperty("skus")]
        public ProductBuylistSkuDto[] Skus { get; set; }
    }

    public class ProductBuylistSkuDto
    {
        [JsonProperty("skuId")]
        public int SkuId { get; set; }

        [JsonProperty("prices")]
        public ProductBuylistPriceDto Prices { get; set; }
    }

    public class ProductBuylistPriceDto
    {
        [JsonProperty("high")]
        public double? High { get; set; }

        [JsonProperty("market")]
        public double? Market { get; set; }
    }
}
