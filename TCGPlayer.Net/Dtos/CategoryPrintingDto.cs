using Newtonsoft.Json;

namespace TCGPlayer.Net.Dtos
{
    public class CategoryPrintingDto
    {
        [JsonProperty("printingId")]
        public int PrintingId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }

        [JsonProperty("modifiedOn")]
        public string ModifiedOn { get; set; }
    }
}
