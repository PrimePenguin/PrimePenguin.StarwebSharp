using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductLanguageModel
    {
        /// <summary>The langCode for this language. Supported language codes are: sv, en, no, da, fi, de, fr, es</summary>
        [JsonProperty("langCode")]
        
        public string LangCode { get; set; }

        /// <summary>The products name</summary>
        [JsonProperty("name")]
        
        [StringLength(150)]
        public string Name { get; set; }

        /// <summary>The products short description</summary>
        [JsonProperty("shortDescription")]
        [StringLength(65535)]
        public string ShortDescription { get; set; }

        /// <summary>The products long description</summary>
        [JsonProperty("longDescription")]
        [StringLength(65535)]
        public string LongDescription { get; set; }

        /// <summary>The permalink for this product and language</summary>
        [JsonProperty("permalink")]
        [StringLength(128)]
        public string Permalink { get; set; }

        /// <summary>The page title for this product</summary>
        [JsonProperty("pageTitle")]
        [StringLength(90)]
        public string PageTitle { get; set; }

        /// <summary>The meta description for this product</summary>
        [JsonProperty("pageMetaDescription")]
        [StringLength(278)]
        public string PageMetaDescription { get; set; }
    }
}