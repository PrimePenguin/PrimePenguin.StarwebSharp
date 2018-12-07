using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductUnitLanguageModel
    {
        /// <summary>The language code for this language</summary>
        [JsonProperty("langCode",
            NullValueHandling = NullValueHandling.Ignore)]
        public string LangCode { get; set; }

        /// <summary>The name of this unit type</summary>
        [JsonProperty("name",
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(30)]
        public string Name { get; set; }

        /// <summary>The symbol to use when counting this unit. For example ”pcs.”</summary>
        [JsonProperty("symbol",
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(5)]
        public string Symbol { get; set; }
    }
}