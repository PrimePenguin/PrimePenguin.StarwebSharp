using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class OrderStatusModel
    {
        /// <summary>The id of the order status</summary>
        [JsonProperty("statusId", NullValueHandling = NullValueHandling.Ignore)]
        public int StatusId { get; set; }

        /// <summary>Should an order status update email be sent out when an order gets this status</summary>
        [JsonProperty("shouldSendEmail", NullValueHandling = NullValueHandling.Ignore)]
        public bool ShouldSendEmail { get; set; }

        /// <summary>Standard order statuses has an idCode as well. These are: created, picking, completed, canceled</summary>
        [JsonProperty("idCode", NullValueHandling = NullValueHandling.Ignore)]
        public string IdCode { get; set; }

        [JsonProperty("languages", NullValueHandling = NullValueHandling.Ignore)]
        public OrderStatusLanguageModelCollection Languages { get; set; } = new OrderStatusLanguageModelCollection();
    }
}