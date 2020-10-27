using Newtonsoft.Json;

namespace TCGPlayer.Net.Dtos
{
    public class CategoryGroupDto
    {
        [JsonProperty("groupId")]
        public int GroupId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }

        [JsonProperty("isSupplemental")]
        public bool IsSupplemental { get; set; }

        [JsonProperty("publishedOn")]
        public string PublishedOn { get; set; }

        [JsonProperty("modifiedOn")]
        public string ModifiedOn { get; set; } 
        
        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }
    }
}
