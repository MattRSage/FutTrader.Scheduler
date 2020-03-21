using System.Text.Json.Serialization;

namespace FutTrader.Domain.EaFutApi.Models
{
    public class FUTAttribute
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
