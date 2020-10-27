using Newtonsoft.Json;

namespace TCGPlayer.Net.Dtos
{
    public class CategoryDto
    {
        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("modifiedOn")]
        public string ModifiedOn { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("seoCategoryName")]
        public string SeoCategoryName { get; set; }

        [JsonProperty("sealedLabel")]
        public string SealedLabel { get; set; }

        [JsonProperty("nonSealedLabel")]
        public string NonSealedLabel { get; set; }

        [JsonProperty("conditionGuideUrl")]
        public string ConditionGuideUrl { get; set; }

        [JsonProperty("isScannable")]
        public bool IsScannable { get; set; }

        [JsonProperty("popularity")]
        public int Popularity { get; set; }
    }
}
