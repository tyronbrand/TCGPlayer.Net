using Newtonsoft.Json;

namespace TCGPlayer.Net.Dtos
{
    public class CategoryLanguageDto
    {
        [JsonProperty("languageId")]
        public int LanguageId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("abbr")]
        public string Abbr { get; set; }
    }
}
