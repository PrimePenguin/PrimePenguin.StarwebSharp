using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductVariantAttributeModelUpdatable
    {
        [JsonProperty("attributeId",
            NullValueHandling = NullValueHandling.Ignore)]
        public int? AttributeId { get; set; }

        /// <summary>A collection of attribute languages</summary>
        [JsonProperty("languages",
            NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ProductVariantAttributeLanguageModel> Languages { get; set; } =
            new Collection<ProductVariantAttributeLanguageModel>();
    }
}