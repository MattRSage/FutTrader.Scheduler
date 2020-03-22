using System.Text.Json.Serialization;

namespace FutTrader.Domain.FutApi.Models
{
    public class FUTAttribute
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("value")]
        public int Value { get; set; }
    }
}
