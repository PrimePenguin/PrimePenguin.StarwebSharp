using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductVariantVolumePriceModelCollection
    {
        /// <summary>A collection of variant volume prices</summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ProductVariantVolumePriceModel> Data { get; set; }
    }
}