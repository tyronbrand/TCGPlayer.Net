using Newtonsoft.Json;

namespace TCGPlayer.Net.Dtos
{
    public class CategorySearchManifestDto
    {
        [JsonProperty("sorting")]
        public CategorySearchManifestSortingDto[] Sorting { get; set; }

        [JsonProperty("filters")]
        public CategorySearchManifestFiltersDto[] Filters { get; set; }
    }

    public class CategorySearchManifestSortingDto
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CategorySearchManifestFiltersDto
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("inputType")]
        public string InputType { get; set; }

        [JsonProperty("items")]
        public CategorySearchManifestFilterItemsDto[] Items { get; set; }

    }

    public class CategorySearchManifestFilterItemsDto
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
