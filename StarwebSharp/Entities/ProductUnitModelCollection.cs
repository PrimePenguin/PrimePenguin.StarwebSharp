using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductUnitModelCollection
    {
        /// <summary>A collection of product units</summary>
        [JsonProperty("data")]
        public ICollection<ProductUnitModel> Data { get; set; } =
            new Collection<ProductUnitModel>();
    }
}