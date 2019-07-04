using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductVariantAttributeModelCollection
    {
        /// <summary>A collection of attribute values</summary>
        [JsonProperty("data")]
        public ICollection<ProductVariantAttributeModel> Data { get; set; } =
            new Collection<ProductVariantAttributeModel>();
    }
}