using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class PaymentMethodModelItem
    {
        [JsonProperty("data")]
        public PaymentMethodModel Data { get; set; } = new PaymentMethodModel();
    }
}