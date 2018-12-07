using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class PricelistModel
    {
        /// <summary>The pricelist id</summary>
        [JsonProperty("pricelistId",
            NullValueHandling = NullValueHandling.Ignore)]
        public int PricelistId { get; set; }

        /// <summary>The name of this pricelist</summary>
        [JsonProperty("name",
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(30)]
        public string Name { get; set; }

        /// <summary>If this pricelist is the default ”master” pricelist or not. Only one pricelist can be the master pricelist</summary>
        [JsonProperty("isMaster",
            NullValueHandling = NullValueHandling.Ignore)]
        public bool IsMaster { get; set; }

        /// <summary>The region this pricelist is valid for</summary>
        [JsonProperty("region",
            NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>The countryCodes this pricelist is valid for</summary>
        [JsonProperty("countryCodes",
            NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string> CountryCodes { get; set; } =
            new Collection<string>();

        /// <summary>The currencyCode this pricelist is valid for</summary>
        [JsonProperty("currencyCode",
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(3, MinimumLength = 3)]
        public string CurrencyCode { get; set; }

        /// <summary>Does this pricelist has a parent price list. </summary>
        [JsonProperty("parentPricelistId",
            NullValueHandling = NullValueHandling.Ignore)]
        public int? ParentPricelistId { get; set; }

        /// <summary>Is this pricelist a ”customer” pricelist (for selected customer groups)</summary>
        [JsonProperty("isCustomerPricelist",
            NullValueHandling = NullValueHandling.Ignore)]
        public bool IsCustomerPricelist { get; set; }

        /// <summary>Is this pricelist a ”country” pricelist (base pricelist for a certain country)</summary>
        [JsonProperty("isCountryPricelist",
            NullValueHandling = NullValueHandling.Ignore)]
        public bool IsCountryPricelist { get; set; }
    }
}