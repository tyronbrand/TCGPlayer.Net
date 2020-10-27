using Newtonsoft.Json;

namespace TCGPlayer.Net.Dtos
{
    public class CategoryMediaDto
    {
        [JsonProperty("mediaType")]
        public string MediaType { get; set; }

        [JsonProperty("contentList")]
        public CategoryMediaContentDto[] ContentList { get; set; }
    }

    public class CategoryMediaContentDto
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }
    }
}
