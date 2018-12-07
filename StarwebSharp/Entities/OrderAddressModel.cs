using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class OrderAddressModel
    {
        [JsonProperty("originalInvoice",
            NullValueHandling = NullValueHandling.Ignore)]
        public AddressModel OriginalInvoice { get; set; } = new AddressModel();

        [JsonProperty("originalDelivery",
            NullValueHandling = NullValueHandling.Ignore)]
        public AddressModel OriginalDelivery { get; set; } = new AddressModel();

        [JsonProperty("customerInvoice",
            NullValueHandling = NullValueHandling.Ignore)]
        public AddressModel CustomerInvoice { get; set; } = new AddressModel();

        [JsonProperty("customerDelivery",
            NullValueHandling = NullValueHandling.Ignore)]
        public AddressModel CustomerDelivery { get; set; } = new AddressModel();

        [JsonProperty("paymentMethodInvoice",
            NullValueHandling = NullValueHandling.Ignore)]
        public AddressModel PaymentMethodInvoice { get; set; } = new AddressModel();

        [JsonProperty("paymentMethodDelivery",
            NullValueHandling = NullValueHandling.Ignore)]
        public AddressModel PaymentMethodDelivery { get; set; } = new AddressModel();
    }
}