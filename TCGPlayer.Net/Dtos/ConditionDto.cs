using Newtonsoft.Json;

namespace TCGPlayer.Net.Dtos
{
    public class ConditionDto
    {
        [JsonProperty("conditionId")]
        public int ConditionId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }
    }
}
