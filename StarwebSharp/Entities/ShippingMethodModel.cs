using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using StarwebSharp.Enums;

namespace StarwebSharp.Entities
{
    public class ShippingMethodModel
    {
        /// <summary>The shipping methods Id</summary>
        [JsonProperty("shippingMethodId",
            NullValueHandling = NullValueHandling.Ignore)]
        public int ShippingMethodId { get; set; }

        /// <summary>If the shipping method is actively available on checkout or not</summary>
        [JsonProperty("active",
            NullValueHandling = NullValueHandling.Ignore)]
        public bool Active { get; set; }

        /// <summary>
        ///     The restrictions to countries this shipping method is valid for. Valid values are: all, EU, non-EU, selected,
        ///     none
        /// </summary>
        [JsonProperty("validForCountries",
            NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public ShippingMethodModelValidForCountries ValidForCountries { get; set; }

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

        /// <summary>The customer type this method is valid for. Valid values are: null (no restriction), person, company</summary>
        [JsonProperty("validForCustomerType",
            NullValueHandling = NullValueHandling.Ignore)]
        public string ValidForCustomerType { get; set; }

        /// <summary>Offer free shipping with this method if the minimum order sub total amount is at least this value</summary>
        [JsonProperty("freeShippingMinItemsSubtotal",
            NullValueHandling = NullValueHandling.Ignore)]
        [Range(0.0D, int.MaxValue)]
        public double? FreeShippingMinItemsSubtotal { get; set; }

        /// <summary>Offer free shipping with this method if the minimum order total weight is at least this value</summary>
        [JsonProperty("freeShippingMinWeight",
            NullValueHandling = NullValueHandling.Ignore)]
        [Range(0.0D, int.MaxValue)]
        public double? FreeShippingMinWeight { get; set; }

        /// <summary>Tells whether this method is a "click and collect" or not</summary>
        [JsonProperty("isClickAndCollect",
            NullValueHandling = NullValueHandling.Ignore)]
        public bool IsClickAndCollect { get; set; }

        [JsonProperty("languages",
            NullValueHandling = NullValueHandling.Ignore)]
        public ShippingMethodLanguageModelCollection Languages { get; set; }
    }
}