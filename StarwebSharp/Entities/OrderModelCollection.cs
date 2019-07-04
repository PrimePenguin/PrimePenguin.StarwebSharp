using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class OrderModelCollection
    {
        /// <summary>A list of orders</summary>
        [JsonProperty("data")]
        public ICollection<OrderModel> Data { get; set; } =
            new Collection<OrderModel>();

        [JsonProperty("meta")]
        public Meta Meta { get; set; } = new Meta();
    }
}