
using System.Text.Json.Serialization;

namespace FutTrader.Domain.FutApi.Models
{
    public class FUTLeagueItem
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("abbrName")]
        public string Abbreviation { get; set; }
    }
}
