using Newtonsoft.Json;

namespace TCGPlayer.Net.Dtos
{
    public class GroupMediaDto
    {
        [JsonProperty("mediaType")]
        public string MediaType { get; set; }

        [JsonProperty("contentList")]
        public GroupMediaContentListDto[] ContentList { get; set; }
    }

    public class GroupMediaContentListDto
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("displayOrder")]
        public int FisplayOrder { get; set; }
    }
}
