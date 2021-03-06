using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductVariantAttributeValueModel
    {
        /// <summary>The id for this attribute value</summary>
        [JsonProperty("attributeValueId")]
        public int AttributeValueId { get; set; }

        /// <summary>The external id of this attribute value</summary>
        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        /// <summary>
        /// The external type of this attribute value, used to provide context for the externalId
        /// </summary>
        [JsonProperty("externalIdType")]
        public string ExternalIdType { get; set; }

        /// <summary>The suggested suffix for new Variants using this attribute value</summary>
        [JsonProperty("skuSuffix")]
        public string SkuSuffix { get; set; }

        /// <summary>The sort order for this attribute value</summary>
        [JsonProperty("sortIndex")]
        [Range(0, int.MaxValue)]
        public int? SortIndex { get; set; }

        /// <summary>A collection of attribute value languages</summary>
        [JsonProperty("languages")]
        public ProductVariantAttributeValueLanguageModelCollection Languages { get; set; } =
            new ProductVariantAttributeValueLanguageModelCollection();
        
        /// <summary>
        /// product attribute link
        /// </summary>
        [JsonProperty("links")]
        public EntityLink[] Links { get; set; }
    }
}