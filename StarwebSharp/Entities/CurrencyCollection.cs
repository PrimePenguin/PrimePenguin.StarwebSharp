﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class CurrencyCollection
    {
        /// <summary>A collection of currencies</summary>
        [JsonProperty("data")]
        public ICollection<CurrencyModel> Data { get; set; }
    }
}