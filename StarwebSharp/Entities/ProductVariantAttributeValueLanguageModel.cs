using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductVariantAttributeValueLanguageModel
    {
        /// <summary>The langCode for this language. Supported language codes are: sv, en, no, da, fi, de, fr, es</summary>
        [JsonProperty("langCode",
            NullValueHandling = NullValueHandling.Ignore)]
        public string LangCode { get; set; }

        /// <summary>The name of this attribute value</summary>
        [JsonProperty("name",
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(50)]
        public string Name { get; set; }
    }
}