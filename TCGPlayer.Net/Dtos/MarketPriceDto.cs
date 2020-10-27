using Newtonsoft.Json;

namespace TCGPlayer.Net.Dtos
{
    public class MarketPriceDto
    {
        [JsonProperty("productConditionId")]
        public int ProductConditionId { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("lowestRange")]
        public double LowestRange { get; set; }

        [JsonProperty("highestRange")]
        public double HighestRange { get; set; }
    }
}
