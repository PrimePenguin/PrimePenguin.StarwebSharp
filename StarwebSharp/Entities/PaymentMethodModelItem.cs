using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class PaymentMethodModelItem
    {
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public PaymentMethodModel Data { get; set; } = new PaymentMethodModel();
    }
}