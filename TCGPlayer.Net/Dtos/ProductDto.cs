using Newtonsoft.Json;

namespace TCGPlayer.Net.Dtos
{
    public class ProductDto
    {
        [JsonProperty("productId")]
        public int ProductId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("cleanName")]
        public string CleanName { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }

        [JsonProperty("groupId")]
        public int GroupId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("modifiedOn")]
        public string ModifiedOn { get; set; }

        [JsonProperty("imageCount")]
        public int ImageCount { get; set; }

        [JsonProperty("skus")]
        public ProductSkuDto[] Skus { get; set; }

        [JsonProperty("presaleInfo")]
        public ProductPresaleInfoDto[] PresaleInfo { get; set; }

        [JsonProperty("extendedData")]
        public ProductExtendedDataDto[] ExtendedData { get; set; }
    }

    public class ProductSkuDto
    {
        [JsonProperty("skuId")]
        public int SkuId { get; set; }

        [JsonProperty("productId")]
        public int ProductId { get; set; }

        [JsonProperty("languageId")]
        public int LanguageId { get; set; }

        [JsonProperty("printingId")]
        public int PrintingId { get; set; }

        [JsonProperty("conditionId")]
        public int ConditionId { get; set; }
    }

    public class ProductPresaleInfoDto
    {
        [JsonProperty("isPresale")]
        public bool IsPresale { get; set; }

        [JsonProperty("releasedOn")]
        public string ReleasedOn { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }
    }


    public class ProductExtendedDataDto
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
