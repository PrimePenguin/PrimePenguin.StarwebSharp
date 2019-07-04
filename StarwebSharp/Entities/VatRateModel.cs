using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class VatRateModel
    {
        /// <summary>The country code this vat rates should be valid for. The country code should be set using ISO 3166-1 alpha-2</summary>
        [JsonProperty("countryCode")]
        [StringLength(2, MinimumLength = 2)]
        public string CountryCode { get; set; }

        /// <summary>The vat rates to use for this country</summary>
        [JsonProperty("defaultVatRate")]
        [Range(0.0D, 100.0D)]
        public double DefaultVatRate { get; set; }

        /// <summary>The vat rates to use for this country for payment methods</summary>
        [JsonProperty("fixedOrderPaymentVatRate")]
        [Range(0.0D, 100.0D)]
        public double FixedOrderPaymentVatRate { get; set; }

        /// <summary>The vat rates to use for this country for shipping methods</summary>
        [JsonProperty("fixedOrderShippingVatRate")]
        [Range(0.0D, 100.0D)]
        public double FixedOrderShippingVatRate { get; set; }

        /// <summary>The vat rates to use for this country for discounts</summary>
        [JsonProperty("fixedOrderDiscountVatRate")]
        [Range(0.0D, 100.0D)]
        public double FixedOrderDiscountVatRate { get; set; }
    }
}