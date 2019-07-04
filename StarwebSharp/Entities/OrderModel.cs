using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class OrderModel
    {
        /// <summary>The orders ID</summary>
        [JsonProperty("orderId")]
        public int OrderId { get; set; }

        /// <summary>A timestamp of when the order was modified. The time should be formatted using ISO-8601</summary>
        [JsonProperty("modifiedAt")]
        public string ModifiedAt { get; set; }

        /// <summary>The shops base currency code at the point of order creation</summary>
        [JsonProperty("baseCurrencyCode")]
        public string BaseCurrencyCode { get; set; }

        /// <summary>The shops country code at the point of order creation</summary>
        [JsonProperty("shopCountryCode")]
        public string ShopCountryCode { get; set; }

        /// <summary>The total order amount</summary>
        [JsonProperty("totalAmount")]
        public double TotalAmount { get; set; }

        /// <summary>The total order VAT amount</summary>
        [JsonProperty("totalVat")]
        public double TotalVat { get; set; }

        /// <summary>The total order amount to pay</summary>
        [JsonProperty("amountToPay")]
        public double AmountToPay { get; set; }

        /// <summary>The total order amount, in the shops base currency</summary>
        [JsonProperty("totalAmountInBaseCurrency")]
        public double TotalAmountInBaseCurrency { get; set; }

        /// <summary>The total VAT amount, in the shops base currency</summary>
        [JsonProperty("totalVatInBaseCurrency")]
        public double TotalVatInBaseCurrency { get; set; }

        /// <summary>The total amount to pay, in the shops base currency</summary>
        [JsonProperty("amountToPayInBaseCurrency")]
        public double AmountToPayInBaseCurrency { get; set; }

        /// <summary>A timestamp of when the order was created. The time should be formatted using ISO-8601</summary>
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        /// <summary>The ID of the orders customer</summary>
        [JsonProperty("customerId")]
        public int? CustomerId { get; set; }

        /// <summary>The ID of the orders status</summary>
        [JsonProperty("statusId")]
        public int? StatusId { get; set; }

        /// <summary>Set this to false to prevent sending email to customer on changes to statusId and new orders for a single call</summary>
        [JsonProperty("onOrderStatusChangeSendEmail")]
        public bool OnOrderStatusChangeSendEmail { get; set; } = true;

        /// <summary>
        ///     Set this to false to prevent processing payment on changes to statusId. Only applies to payment methods that
        ///     support processing payments. For example charging a reserved amount or cancel a created invoice
        /// </summary>
        [JsonProperty("onOrderStatusChangeProcessPayment")]
        public bool OnOrderStatusChangeProcessPayment { get; set; } = true;

        /// <summary>
        ///     Set this to false to prevent sending email to customer on changes to statusId and new orders for this and all
        ///     future calls
        /// </summary>
        [JsonProperty("sendEmailsOnStatusChange")]
        public bool SendEmailsOnStatusChange { get; set; } = true;

        /// <summary>The ID of the orders shipping method</summary>
        [JsonProperty("shippingMethodId")]
        public int? ShippingMethodId { get; set; }

        /// <summary>The ID of the orders payment method</summary>
        [JsonProperty("paymentMethodId")]
        public int? PaymentMethodId { get; set; }

        /// <summary>The ID code of the payment method.</summary>
        [JsonProperty("paymentMethodIdCode")]
        public string PaymentMethodIdCode { get; set; }

        /// <summary>Title of the orders payment method</summary>
        [JsonProperty("paymentMethodName")]
        [StringLength(30)]
        public string PaymentMethodName { get; set; }

        /// <summary>Payment fee</summary>
        [JsonProperty("paymentFee")]
        [Range(0, int.MaxValue)]
        public double PaymentFee { get; set; }

        /// <summary>The VAT rate of the paymentFee in percent</summary>
        [JsonProperty("paymentVatRate")]
        public double PaymentVatRate { get; set; }

        /// <summary>Title of the orders shipping method</summary>
        [JsonProperty("shippingMethodName")]
        [StringLength(30)]
        public string ShippingMethodName { get; set; }

        /// <summary>Shipping cost</summary>
        [JsonProperty("shippingCost")]
        [Range(0, int.MaxValue)]
        public double ShippingCost { get; set; }

        /// <summary>The VAT rate of the shippingCost in percent</summary>
        [JsonProperty("shippingVatRate")]
        public double ShippingVatRate { get; set; }

        /// <summary>The total weight of the order in kg. This field is a calculated summary of all order items</summary>
        [JsonProperty("totalWeight")]
        public double TotalWeight { get; set; }

        /// <summary>Custom info saved to an order. Can be linked to fields on the checkout page for additional data collection</summary>
        [JsonProperty("customInfo1")]
        [StringLength(255)]
        public string CustomInfo1 { get; set; }

        /// <summary>Custom info saved to an order. Can be linked to fields on the checkout page for additional data collection</summary>
        [JsonProperty("customInfo2")]
        [StringLength(255)]
        public string CustomInfo2 { get; set; }

        /// <summary>Custom info saved to an order. Can be linked to fields on the checkout page for additional data collection</summary>
        [JsonProperty("customInfo3")]
        [StringLength(255)]
        public string CustomInfo3 { get; set; }

        /// <summary>Custom info saved to an order. Can be linked to fields on the checkout page for additional data collection</summary>
        [JsonProperty("customInfo4")]
        [StringLength(255)]
        public string CustomInfo4 { get; set; }

        /// <summary>The code ID of a discount code that was used for this order</summary>
        [JsonProperty("discountCode")]
        [StringLength(20)]
        public string DiscountCode { get; set; }

        /// <summary>The amount paid via the payment method for this order</summary>
        [JsonProperty("amountPaid")]
        public double AmountPaid { get; set; }

        /// <summary>Same as amountPaid, but in the shops base currency</summary>
        [JsonProperty("amountPaidInBaseCurrency")]
        public double AmountPaidInBaseCurrency { get; set; }

        /// <summary>Is the order completed (that is, is it completely saved and has the payment method processed and confirmed it)</summary>
        [JsonProperty("isComplete")]
        public bool IsComplete { get; set; }

        /// <summary>The currency code of the currency that was used for this order. Has to be a valid ISO 4217 currency code</summary>
        [JsonProperty("currencyCode")]
        [StringLength(3, MinimumLength = 3)]
        public string CurrencyCode { get; set; }

        /// <summary>
        ///     The exchange rate between this orders currency and the shops base currency. Ff, for example, the shop base
        ///     currency is SEK and this order was placed in NOK, where 1 SEK = 0.97 NOK - this value would be 0.97
        /// </summary>
        [JsonProperty("currencyExchangeRate")]
        public double CurrencyExchangeRate { get; set; }

        /// <summary>The number of decimals to display</summary>
        [JsonProperty("currencyPrecision")]
        public int? CurrencyPrecision { get; set; }

        /// <summary>
        ///     Language Code (ISO 639-1) used for placing this order. Has to be a valid lang code that the shop has setup.
        ///     Used for order update emails, etc.
        /// </summary>
        [JsonProperty("langCode")]
        [StringLength(2, MinimumLength = 2)]
        public string LangCode { get; set; }

        /// <summary>Reference to the payment methods payment transaction</summary>
        [JsonProperty("paymentReference")]
        [StringLength(80)]
        public string PaymentReference { get; set; }

        /// <summary>Status of the payment methods payment transaction</summary>
        [JsonProperty("paymentStatus")]
        [StringLength(20)]
        public string PaymentStatus { get; set; }

        /// <summary>An order is read when an administrator has read it via the admin GUI</summary>
        [JsonProperty("isRead")]
        public bool IsRead { get; set; }

        /// <summary>Whether the customer or an admin has added a comment to the order</summary>
        [JsonProperty("hasComments")]
        public bool HasComments { get; set; }

        /// <summary>An internal comment placed by an administrator. Not available to the customer</summary>
        [JsonProperty("internalComment")]
        public string InternalComment { get; set; }

        /// <summary>The ID of the tracking number type. Types are available via: GET /shipping-tracker-types</summary>
        [JsonProperty("shippingTrackerType")]
        public int? ShippingTrackerType { get; set; }

        /// <summary>
        ///     The shipping tracking number. Has to be in the format that is used for the chosen tracking type (please
        ///     contact the freight forwarder regarding this).
        /// </summary>
        [JsonProperty("shippingTrackingNo")]
        [StringLength(50)]
        public string ShippingTrackingNo { get; set; }

        /// <summary>The email address of the customer at the point of order creation</summary>
        [JsonProperty("originalCustomerEmail")]
        public string OriginalCustomerEmail { get; set; }

        /// <summary>The national id number of the customer at the point of order creation</summary>
        [JsonProperty("originalCustomerNationalIdNo")]
        public string OriginalCustomerNationalIdNo { get; set; }

        /// <summary>The VAT number of the customer at the point of order creation</summary>
        [JsonProperty("originalCustomerVatNo")]
        public string OriginalCustomerVatNo { get; set; }

        /// <summary>Custom customer info at the point of order creation</summary>
        [JsonProperty("originalCustomerCustomInfo1")]
        public string OriginalCustomerCustomInfo1 { get; set; }

        /// <summary>Custom customer info at the point of order creation</summary>
        [JsonProperty("originalCustomerCustomInfo2")]
        public string OriginalCustomerCustomInfo2 { get; set; }

        [JsonProperty("items")]
        public OrderItemModelCollection Items { get; set; }

        [JsonProperty("addresses")]
        public OrderAddressCollection Addresses { get; set; }

        [JsonProperty("externalServices")]
        public OrderExternalServiceModelCollection ExternalServices { get; set; }

        [JsonProperty("customer")]
        public CustomerModelItem Customer { get; set; }

        [JsonProperty("status")]
        public OrderStatusModelItem Status { get; set; }
    }
}