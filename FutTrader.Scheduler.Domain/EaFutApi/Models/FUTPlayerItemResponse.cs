using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FutTrader.Domain.EaFutApi.Models
{
    public class FUTPlayerItemResponse
    {
        [JsonPropertyName("page")]
        public int Page { get; set; }

        [JsonPropertyName("totalPages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("totalResults")]
        public int TotalResults { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("items")]
        public List<FUTPlayerItem> Items { get; set; }

    }
}
