using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class OrderAddressModel
    {
        [JsonProperty("originalInvoice")]
        public AddressModel OriginalInvoice { get; set; } = new AddressModel();

        [JsonProperty("originalDelivery")]
        public AddressModel OriginalDelivery { get; set; } = new AddressModel();

        [JsonProperty("customerInvoice")]
        public AddressModel CustomerInvoice { get; set; } = new AddressModel();

        [JsonProperty("customerDelivery")]
        public AddressModel CustomerDelivery { get; set; } = new AddressModel();

        [JsonProperty("paymentMethodInvoice")]
        public AddressModel PaymentMethodInvoice { get; set; } = new AddressModel();

        [JsonProperty("paymentMethodDelivery")]
        public AddressModel PaymentMethodDelivery { get; set; } = new AddressModel();
    }
}