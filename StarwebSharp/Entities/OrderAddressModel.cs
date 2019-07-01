using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class OrderAddressModel
    {
        [JsonProperty("originalInvoice", NullValueHandling = NullValueHandling.Ignore)]
        public AddressModel OriginalInvoice { get; set; }

        [JsonProperty("originalDelivery", NullValueHandling = NullValueHandling.Ignore)]
        public AddressModel OriginalDelivery { get; set; }

        [JsonProperty("customerInvoice", NullValueHandling = NullValueHandling.Ignore)]
        public AddressModel CustomerInvoice { get; set; }

        [JsonProperty("customerDelivery", NullValueHandling = NullValueHandling.Ignore)]
        public AddressModel CustomerDelivery { get; set; }

        [JsonProperty("paymentMethodInvoice", NullValueHandling = NullValueHandling.Ignore)]
        public AddressModel PaymentMethodInvoice { get; set; }

        [JsonProperty("paymentMethodDelivery", NullValueHandling = NullValueHandling.Ignore)]
        public AddressModel PaymentMethodDelivery { get; set; }


    }
}