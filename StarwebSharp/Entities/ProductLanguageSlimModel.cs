using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductLanguageSlimModel
    {
        /// <summary>The langCode for this language. Supported language codes are: sv, en, no, da, fi, de, fr, es</summary>
        [JsonProperty("langCode", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        public string LangCode { get; set; }

        /// <summary>The products name</summary>
        [JsonProperty("name", Required = Required.Always)]
        [Required(AllowEmptyStrings = true)]
        [StringLength(150)]
        public string Name { get; set; }

        /// <summary>The products short description</summary>
        [JsonProperty("shortDescription",
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(65535)]
        public string ShortDescription { get; set; }

        /// <summary>The permalink for this product and language</summary>
        [JsonProperty("permalink",
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(128)]
        public string Permalink { get; set; }
    }
}