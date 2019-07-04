using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductCategoryLanguagesModel
    {
        /// <summary>Language Code (ISO 639-1) for this translation. Has to be a valid lang code that the shop supports. (required)</summary>
        [JsonProperty("langCode")]
        [StringLength(2, MinimumLength = 2)]
        public string LangCode { get; set; }

        /// <summary>The name of this product category (required)</summary>
        [JsonProperty("name")]
        [StringLength(90)]
        public string Name { get; set; }

        /// <summary>The page title for this product category</summary>
        [JsonProperty("pageTitle")]
        [StringLength(90)]
        public string PageTitle { get; set; }

        /// <summary>The main/top description of this product category</summary>
        [JsonProperty("description")]
        [StringLength(65535)]
        public string Description { get; set; }

        /// <summary>The extra/bottom description of this product category</summary>
        [JsonProperty("bottomDescription")]
        [StringLength(65535)]
        public string BottomDescription { get; set; }

        /// <summary>The page meta data description of this product category</summary>
        [JsonProperty("pageMetaDescription")]
        [StringLength(278)]
        public string PageMetaDescription { get; set; }

        /// <summary>The permalink to this product category. Will auto generate if left out</summary>
        [JsonProperty("permalink")]
        [StringLength(128)]
        public string Permalink { get; set; }
    }
}