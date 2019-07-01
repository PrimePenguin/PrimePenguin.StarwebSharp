using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class BundledProductsModel
    {
        /// <summary>Bundled product only valid for a single variant</summary>
        [JsonProperty("singleVariant", NullValueHandling = NullValueHandling.Ignore)]
        public bool SingleVariant { get; set; }

        /// <summary>The bundled products id</summary>
        [JsonProperty("bundledProductId", NullValueHandling = NullValueHandling.Ignore)]
        public int BundledProductId { get; set; }

        /// <summary>The sku of the variant the product is locked to in the variant</summary>
        [JsonProperty("variantSku", NullValueHandling = NullValueHandling.Ignore)]
        public string VariantSku { get; set; }

        /// <summary>The quantity for this bundled product</summary>
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        [Range(1, 100000000)]
        public int? Quantity { get; set; }

        /// <summary>The sort index of this bundled product.</summary>
        [JsonProperty("sortIndex", NullValueHandling = NullValueHandling.Ignore)]
        public int SortIndex { get; set; }

        /// <summary>A collection of bundled product prices</summary>
        [JsonProperty("prices", NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ProductBundleProductPriceModel> Prices { get; set; }
    }
}