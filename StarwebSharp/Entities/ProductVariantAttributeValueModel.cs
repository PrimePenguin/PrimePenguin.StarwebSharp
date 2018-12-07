using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductVariantAttributeValueModel
    {
        /// <summary>The id for this attribute value</summary>
        [JsonProperty("attributeValueId",
            NullValueHandling = NullValueHandling.Ignore)]
        public int AttributeValueId { get; set; }

        /// <summary>The suggested suffix for new Variants using this attribute value</summary>
        [JsonProperty("skuSuffix",
            NullValueHandling = NullValueHandling.Ignore)]
        public string SkuSuffix { get; set; }

        /// <summary>The sort order for this attribute value</summary>
        [JsonProperty("sortIndex",
            NullValueHandling = NullValueHandling.Ignore)]
        [Range(0, int.MaxValue)]
        public int? SortIndex { get; set; }

        /// <summary>A collection of attribute value languages</summary>
        [JsonProperty("languages",
            NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ProductVariantAttributeValueLanguageModel> Languages { get; set; } =
            new Collection<ProductVariantAttributeValueLanguageModel>();
    }
}