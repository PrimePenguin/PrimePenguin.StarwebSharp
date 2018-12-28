using System.Collections.Generic;
using Newtonsoft.Json;
using StarwebSharp.Entities;

namespace StarwebSharp.Services.OrderStatus
{
    public class OrderStatusCreateUpdateModel
    {
        /// <summary>The id of the order status</summary>
        [JsonProperty("statusId", NullValueHandling = NullValueHandling.Ignore)]
        public int? StatusId { get; set; }

        /// <summary>Should an order status update email be sent out when an order gets this status</summary>
        [JsonProperty("shouldSendEmail", NullValueHandling = NullValueHandling.Ignore)]
        public bool ShouldSendEmail { get; set; }

        [JsonProperty("languages", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<OrderStatusLanguageModel> Languages { get; set; }
    }
}