using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class OrderExternalServiceModelCollection
    {
        /// <summary>A list of order external services</summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<OrderExternalServiceModel> Data { get; set; }
    }
}