using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductVariantPriceModelCollection
    {
        /// <summary>A collection of product variants</summary>
        [JsonProperty("data")]
        public ICollection<ProductVariantPriceModel> Data { get; set; } =
            new Collection<ProductVariantPriceModel>();
    }
}