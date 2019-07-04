using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductBundleProductPriceModelCollection
    {
        /// <summary>A collection of bundled product prices</summary>
        [JsonProperty("data")]
        public ICollection<ProductBundleProductPriceModel> Data { get; set; }
    }
}