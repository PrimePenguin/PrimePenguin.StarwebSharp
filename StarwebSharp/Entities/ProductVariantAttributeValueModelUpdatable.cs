using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductVariantAttributeValueModelUpdatable
    {
        /// <summary>A collection of attribute value languages</summary>
        [JsonProperty("languages",
            NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ProductVariantAttributeValueLanguageModel> Languages { get; set; } =
            new Collection<ProductVariantAttributeValueLanguageModel>();
    }
}