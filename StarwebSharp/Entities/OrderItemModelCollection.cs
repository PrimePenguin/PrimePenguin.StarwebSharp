using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class OrderItemModelCollection
    {
        /// <summary>A list of order items</summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<OrderItemModel> Data { get; set; }
    }
}