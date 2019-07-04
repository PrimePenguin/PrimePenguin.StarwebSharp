using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class OrderWebhookResult : WebhookResult
    {
        [JsonProperty("orderId")]
        public int OrderId { get; set; }
        [JsonProperty("shippingMethodId")]
        public int ShippingMethodId { get; set; }
        [JsonProperty("paymentMethodId")]
        public int PaymentMethodId { get; set; }
        [JsonProperty("orderStatusId")]
        public int OrderStatusId { get; set; }
        [JsonProperty("orderStatusIdCode")]
        public object OrderStatusIdCode { get; set; }
        [JsonProperty("totalAmount")]
        public string TotalAmount { get; set; }
        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }
    }
}
