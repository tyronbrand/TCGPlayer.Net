using Newtonsoft.Json;

namespace TCGPlayer.Net.Dtos
{
    public class ProductListDto
    {
        [JsonProperty("productListId")]
        public int ProductListId { get; set; }

        [JsonProperty("productListKey")]
        public string ProductListKey { get; set; }

        [JsonProperty("createdOn")]
        public string CreatedOn { get; set; }

        [JsonProperty("productListItems")]
        public ProductListItemDto[] ProductListItems { get; set; }
    }

    public class ProductListItemDto
    {
        [JsonProperty("productListItemId")]
        public int ProductListItemId { get; set; }
        
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("productCondition")]
        public ProductConditionDto ProductCondition { get; set; }
    }


    public class ProductConditionDto
    {
        [JsonProperty("productConditionId")]
        public int ProductConditionId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("isFoil")]
        public bool IsFoil { get; set; }
    }
}
