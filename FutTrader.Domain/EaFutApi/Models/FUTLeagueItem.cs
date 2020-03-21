﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Text;

namespace Crawler.Models
{
    public class FUTLeagueItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("abbrName")]
        public string Abbreviation { get; set; }
    }
}
