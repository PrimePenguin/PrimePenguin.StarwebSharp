using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductVariantModelCollection
    {
        /// <summary>A collection of product variants</summary>
        [JsonProperty("data")]
        public ICollection<ProductVariantModel> Data { get; set; } =
            new Collection<ProductVariantModel>();
    }
}