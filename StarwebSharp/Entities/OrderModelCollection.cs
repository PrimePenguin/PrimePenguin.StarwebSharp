using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class OrderModelCollection
    {
        /// <summary>A list of orders</summary>
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<OrderModel> Data { get; set; } =
            new Collection<OrderModel>();

        [JsonProperty("meta",
            NullValueHandling = NullValueHandling.Ignore)]
        public Meta Meta { get; set; } = new Meta();
    }
}