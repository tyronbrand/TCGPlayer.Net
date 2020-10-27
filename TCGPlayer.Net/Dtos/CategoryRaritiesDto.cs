using Newtonsoft.Json;

namespace TCGPlayer.Net.Dtos
{
    public class CategoryRaritiesDto
    {
        [JsonProperty("rarityId")]
        public int RarityId { get; set; }

        [JsonProperty("displayText")]
        public string DisplayText { get; set; }

        [JsonProperty("dbValue")]
        public string DbValue { get; set; }
    }
}
