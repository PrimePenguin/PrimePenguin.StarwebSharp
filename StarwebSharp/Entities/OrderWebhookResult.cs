using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class OrderWebhookResult : WebhookResult
    {
        [JsonProperty("orderId", NullValueHandling = NullValueHandling.Ignore)]
        public int OrderId { get; set; }
        [JsonProperty("shippingMethodId", NullValueHandling = NullValueHandling.Ignore)]
        public int ShippingMethodId { get; set; }
        [JsonProperty("paymentMethodId", NullValueHandling = NullValueHandling.Ignore)]
        public int PaymentMethodId { get; set; }
        [JsonProperty("orderStatusId", NullValueHandling = NullValueHandling.Ignore)]
        public int OrderStatusId { get; set; }
        [JsonProperty("orderStatusIdCode", NullValueHandling = NullValueHandling.Ignore)]
        public object OrderStatusIdCode { get; set; }
        [JsonProperty("totalAmount", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalAmount { get; set; }
        [JsonProperty("currencyCode", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrencyCode { get; set; }
    }
}
