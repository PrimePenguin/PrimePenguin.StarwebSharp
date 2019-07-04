using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductVariantAttributeLanguageModel
    {
        /// <summary>The langCode for this language. Supported language codes are: sv, en, no, da, fi, de, fr, es</summary>
        [JsonProperty("langCode")]
        public string LangCode { get; set; }

        /// <summary>The name of this attribute</summary>
        [JsonProperty("name")]
        [StringLength(50)]
        public string Name { get; set; }
    }
}