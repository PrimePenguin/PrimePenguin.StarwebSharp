using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductVariantAttributeValueLanguageModelCollection
    {
        /// <summary>A collection of attribute values</summary>
        [JsonProperty("data")]
        public ICollection<ProductVariantAttributeValueLanguageModel> Data { get; set; } =
            new Collection<ProductVariantAttributeValueLanguageModel>();
    }
}