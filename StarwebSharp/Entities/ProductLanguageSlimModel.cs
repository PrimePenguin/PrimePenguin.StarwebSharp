using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductLanguageSlimModel
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

        /// <summary>The permalink for this product and language</summary>
        [JsonProperty("permalink")]
        [StringLength(128)]
        public string Permalink { get; set; }

        /// <summary>The products long description</summary>
        [JsonProperty("longDescription")]
        [StringLength(65535)]
        public string LongDescription { get; set; }

        /// <summary>Page title</summary>
        [JsonProperty("pageTitle")]
        public string PageTitle { get; set; }

        /// <summary>Page meta description</summary>
        [JsonProperty("pageMetaDescription")]
        public string PageMetaDescription { get; set; }

        /// <summary>
        /// Product language links
        /// </summary>
        [JsonProperty("links")]
        public EntityLink[] Links { get; set; }
    }
}