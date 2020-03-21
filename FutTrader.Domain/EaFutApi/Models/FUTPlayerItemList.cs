using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Crawler.Models
{
    public class FUTPlayerItemList
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("totalResults")]
        public int TotalResults { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("items")]
        public List<FUTPlayerItem> Items { get; set; }

    }
}
