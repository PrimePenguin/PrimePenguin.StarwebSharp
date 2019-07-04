using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductWebhookResult : WebhookResult
    {
        [JsonProperty("productId")]
        public int ProductId { get; set; }
    }
}
