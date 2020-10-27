using Newtonsoft.Json;

namespace TCGPlayer.Net.Dtos
{
    public class RelatedProductsDto
    {
        [JsonProperty("cardId")]
        public int CardId { get; set; }

        [JsonProperty("setName")]
        public string SetName { get; set; }

        [JsonProperty("cleanSetName")]
        public string CleanSetName { get; set; }

        [JsonProperty("productName")]
        public string ProductName { get; set; }

        [JsonProperty("purchasedProductName")]
        public string PurchasedProductName { get; set; }

        [JsonProperty("purchasedProductCleanName")]
        public string PurchasedProductCleanName { get; set; }

        [JsonProperty("purchasedCount")]
        public int PurchasedCount { get; set; }

        [JsonProperty("lowestPrice")]
        public double LowestPrice { get; set; }

        [JsonProperty("purchasedStoreProductId")]
        public int PurchasedStoreProductId { get; set; }

        [JsonProperty("addedDt")]
        public string AddedDt { get; set; }

        [JsonProperty("usesCdn")]
        public bool UsesCdn { get; set; }
    }
}
