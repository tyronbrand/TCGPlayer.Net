using Newtonsoft.Json;

namespace TCGPlayer.Net.Dtos
{
    public class ProductMediaTypeDto
    {
        [JsonProperty("mediaType")]
        public string MediaType { get; set; }

        [JsonProperty("contentList")]
        public ProductMediacontentListTypeDto[] ContentList { get; set; }
    }

    public class ProductMediacontentListTypeDto
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("displayOrder")]        
        public int DisplayOrder { get; set; }
    }
}
