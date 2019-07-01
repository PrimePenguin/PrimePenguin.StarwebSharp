using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductWebhookResult : WebhookResult
    {
        [JsonProperty("productId", NullValueHandling = NullValueHandling.Ignore)]
        public int ProductId { get; set; }
    }
}