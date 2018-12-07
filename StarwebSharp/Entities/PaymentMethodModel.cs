using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using StarwebSharp.Enums;

namespace StarwebSharp.Entities
{
    public class PaymentMethodModel
    {
        /// <summary>The payment methods Id</summary>
        [JsonProperty("paymentMethodId",
            NullValueHandling = NullValueHandling.Ignore)]
        public int PaymentMethodId { get; set; }

        /// <summary>The payment methods idCode. This can be used to identify a payment method of a standarized type</summary>
        [JsonProperty("idCode",
            NullValueHandling = NullValueHandling.Ignore)]
        public string IdCode { get; set; }

        /// <summary>If the payment method is actively available on checkout or not</summary>
        [JsonProperty("active",
            NullValueHandling = NullValueHandling.Ignore)]
        public bool Active { get; set; }

        /// <summary>Fee associated with this method</summary>
        [JsonProperty("fee",
            NullValueHandling = NullValueHandling.Ignore)]
        [Range(0.0D, int.MaxValue)]
        public double Fee { get; set; }

        /// <summary>
        ///     The restrictions to countries this payment method is valid for. Valid values are: all, EU, non-EU, selected,
        ///     none
        /// </summary>
        [JsonProperty("validForCountries",
            NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public PaymentMethodModelValidForCountries ValidForCountries { get; set; }

        /// <summary>The countries this method is valid for (if validForCountries is set to ”selected”)</summary>
        [JsonProperty("validCountriesSelected",
            NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string> ValidCountriesSelected { get; set; } =
            new Collection<string>();

        /// <summary>The min order sub total that this method is valid for</summary>
        [JsonProperty("validForMinItemsSubtotal",
            NullValueHandling = NullValueHandling.Ignore)]
        [Range(0.0D, int.MaxValue)]
        public double? ValidForMinItemsSubtotal { get; set; }

        /// <summary>The max order sub total that this method is valid for</summary>
        [JsonProperty("validForMaxItemsSubtotal",
            NullValueHandling = NullValueHandling.Ignore)]
        [Range(0.0D, int.MaxValue)]
        public double? ValidForMaxItemsSubtotal { get; set; }

        /// <summary>The min order weight that this method is valid for</summary>
        [JsonProperty("validForMinWeight",
            NullValueHandling = NullValueHandling.Ignore)]
        [Range(0.0D, int.MaxValue)]
        public double? ValidForMinWeight { get; set; }

        /// <summary>The max order weight that this method is valid for.</summary>
        [JsonProperty("validForMaxWeight",
            NullValueHandling = NullValueHandling.Ignore)]
        [Range(0.0D, int.MaxValue)]
        public double? ValidForMaxWeight { get; set; }

        /// <summary>The shipping methods this is valid for. Valid values are: all, selected</summary>
        [JsonProperty("validForShippingMethods",
            NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public PaymentMethodModelValidForShippingMethods ValidForShippingMethods { get; set; }

        /// <summary>The customer type this method is valid for. Valid values are: null (no restriction), person, company</summary>
        [JsonProperty("validForCustomerType",
            NullValueHandling = NullValueHandling.Ignore)]
        public string ValidForCustomerType { get; set; }

        /// <summary>Tells whether this method is a "click and collect" or not</summary>
        [JsonProperty("isClickAndCollect",
            NullValueHandling = NullValueHandling.Ignore)]
        public bool IsClickAndCollect { get; set; }

        [JsonProperty("languages",
            NullValueHandling = NullValueHandling.Ignore)]
        public PaymentMethodLanguageModelCollection Languages { get; set; }
    }
}