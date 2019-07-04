using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class OrderStatusLanguageModelCollection
    {
        /// <summary>A list of customer tags</summary>
        [JsonProperty("data")]
        public ICollection<OrderStatusLanguageModel> Data { get; set; } =
            new Collection<OrderStatusLanguageModel>();
    }
}