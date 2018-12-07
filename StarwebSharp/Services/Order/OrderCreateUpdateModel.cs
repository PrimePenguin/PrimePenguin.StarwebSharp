using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using StarwebSharp.Entities;

namespace StarwebSharp.Services.Order
{
    public class OrderCreateUpdateModel
    {
        /// <summary>The orders ID</summary>
        [JsonProperty("orderId", NullValueHandling = NullValueHandling.Ignore)]
        public int? OrderId { get; set; }

        /// <summary>A timestamp of when the order was created. The time should be formatted using ISO-8601</summary>
        [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>The ID of the orders customer</summary>
        [JsonProperty("customerId", NullValueHandling = NullValueHandling.Ignore)]
        public int? CustomerId { get; set; }

        /// <summary>The ID of the orders status</summary>
        [JsonProperty("statusId", NullValueHandling = NullValueHandling.Ignore)]
        public int? StatusId { get; set; }

        /// <summary>Set this to false to prevent sending email to customer on changes to statusId and new orders for a single call</summary>
        [JsonProperty("onOrderStatusChangeSendEmail", NullValueHandling = NullValueHandling.Ignore)]
        public bool OnOrderStatusChangeSendEmail { get; set; } = true;

        /// <summary>
        ///     Set this to false to prevent processing payment on changes to statusId. Only applies to payment methods that
        ///     support processing payments. For example charging a reserved amount or cancel a created invoice
        /// </summary>
        [JsonProperty("onOrderStatusChangeProcessPayment", NullValueHandling = NullValueHandling.Ignore)]
        public bool OnOrderStatusChangeProcessPayment { get; set; } = true;

        /// <summary>The ID of the orders shipping method</summary>
        [JsonProperty("shippingMethodId", NullValueHandling = NullValueHandling.Ignore)]
        public int? ShippingMethodId { get; set; }

        /// <summary>The ID of the orders payment method</summary>
        [JsonProperty("paymentMethodId", NullValueHandling = NullValueHandling.Ignore)]
        public int? PaymentMethodId { get; set; }

        /// <summary>Title of the orders payment method</summary>
        [JsonProperty("paymentMethodName", NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(30)]
        public string PaymentMethodName { get; set; }

        /// <summary>Payment fee</summary>
        [JsonProperty("paymentFee", NullValueHandling = NullValueHandling.Ignore)]
        [Range(0, int.MaxValue)]
        public double PaymentFee { get; set; }

        /// <summary>The VAT rate of the paymentFee in percent</summary>
        [JsonProperty("paymentVatRate", NullValueHandling = NullValueHandling.Ignore)]
        public double PaymentVatRate { get; set; }

        /// <summary>Title of the orders shipping method</summary>
        [JsonProperty("shippingMethodName", NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(30)]
        public string ShippingMethodName { get; set; }

        /// <summary>Shipping cost</summary>
        [JsonProperty("shippingCost", NullValueHandling = NullValueHandling.Ignore)]
        [Range(0, int.MaxValue)]
        public double ShippingCost { get; set; }

        /// <summary>The VAT rate of the shippingCost in percent</summary>
        [JsonProperty("shippingVatRate", NullValueHandling = NullValueHandling.Ignore)]
        public double ShippingVatRate { get; set; }

        /// <summary>Custom info saved to an order. Can be linked to fields on the checkout page for additional data collection</summary>
        [JsonProperty("customInfo1", NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string CustomInfo1 { get; set; }

        /// <summary>Custom info saved to an order. Can be linked to fields on the checkout page for additional data collection</summary>
        [JsonProperty("customInfo2", NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string CustomInfo2 { get; set; }

        /// <summary>Custom info saved to an order. Can be linked to fields on the checkout page for additional data collection</summary>
        [JsonProperty("customInfo3", NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string CustomInfo3 { get; set; }

        /// <summary>Custom info saved to an order. Can be linked to fields on the checkout page for additional data collection</summary>
        [JsonProperty("customInfo4", NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string CustomInfo4 { get; set; }

        /// <summary>The code ID of a discount code that was used for this order</summary>
        [JsonProperty("discountCode", NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(20)]
        public string DiscountCode { get; set; }

        /// <summary>The amount paid via the payment method for this order</summary>
        [JsonProperty("amountPaid", NullValueHandling = NullValueHandling.Ignore)]
        public double AmountPaid { get; set; }

        /// <summary>Is the order completed (that is, is it completely saved and has the payment method processed and confirmed it)</summary>
        [JsonProperty("isComplete", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsComplete { get; set; }

        /// <summary>The currency code of the currency that was used for this order. Has to be a valid ISO 4217 currency code</summary>
        [JsonProperty("currencyCode", NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(3, MinimumLength = 3)]
        public string CurrencyCode { get; set; }

        /// <summary>
        ///     The exchange rate between this orders currency and the shops base currency. Ff, for example, the shop base
        ///     currency is SEK and this order was placed in NOK, where 1 SEK = 0.97 NOK - this value would be 0.97
        /// </summary>
        [JsonProperty("currencyExchangeRate", NullValueHandling = NullValueHandling.Ignore)]
        public double CurrencyExchangeRate { get; set; }

        /// <summary>The number of decimals to display</summary>
        [JsonProperty("currencyPrecision", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurrencyPrecision { get; set; }

        /// <summary>
        ///     Language Code (ISO 639-1) used for placing this order. Has to be a valid lang code that the shop has setup.
        ///     Used for order update emails, etc.
        /// </summary>
        [JsonProperty("langCode", NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(2, MinimumLength = 2)]
        public string LangCode { get; set; }

        /// <summary>Reference to the payment methods payment transaction</summary>
        [JsonProperty("paymentReference", NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(80)]
        public string PaymentReference { get; set; }

        /// <summary>Status of the payment methods payment transaction</summary>
        [JsonProperty("paymentStatus", NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(20)]
        public string PaymentStatus { get; set; }

        /// <summary>An order is read when an administrator has read it via the admin GUI</summary>
        [JsonProperty("isRead", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsRead { get; set; }

        /// <summary>An internal comment placed by an administrator. Not available to the customer</summary>
        [JsonProperty("internalComment", NullValueHandling = NullValueHandling.Ignore)]
        public string InternalComment { get; set; }

        /// <summary>The ID of the tracking number type. Types are available via: GET /shipping-tracker-types</summary>
        [JsonProperty("shippingTrackerType", NullValueHandling = NullValueHandling.Ignore)]
        public int? ShippingTrackerType { get; set; }

        /// <summary>
        ///     The shipping tracking number. Has to be in the format that is used for the chosen tracking type (please
        ///     contact the freight forwarder regarding this).
        /// </summary>
        [JsonProperty("shippingTrackingNo", NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(50)]
        public string ShippingTrackingNo { get; set; }

        /// <summary>The email address of the customer at the point of order creation</summary>
        [JsonProperty("originalCustomerEmail", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalCustomerEmail { get; set; }

        /// <summary>The national id number of the customer at the point of order creation</summary>
        [JsonProperty("originalCustomerNationalIdNo", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalCustomerNationalIdNo { get; set; }

        /// <summary>The VAT number of the customer at the point of order creation</summary>
        [JsonProperty("originalCustomerVatNo", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalCustomerVatNo { get; set; }

        /// <summary>Custom customer info at the point of order creation</summary>
        [JsonProperty("originalCustomerCustomInfo1", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalCustomerCustomInfo1 { get; set; }

        /// <summary>Custom customer info at the point of order creation</summary>
        [JsonProperty("originalCustomerCustomInfo2", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalCustomerCustomInfo2 { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<OrderItemModel> Items { get; set; }

        [JsonProperty("addresses", NullValueHandling = NullValueHandling.Ignore)]
        public OrderAddressModel Addresses { get; set; }
    }
}
