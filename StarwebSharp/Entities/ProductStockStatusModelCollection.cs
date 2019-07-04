using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductStockStatusModelCollection
    {
        /// <summary>A list of product stock statuses</summary>
        [JsonProperty("data")]
        public ICollection<ProductStockStatusModel> Data { get; set; } =
            new Collection<ProductStockStatusModel>();
    }
}