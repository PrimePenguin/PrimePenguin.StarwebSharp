using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductVatRateModel
    {
        /// <summary>The country code this vat rate should be valid for. The country code should be set using ISO 3166-1 alpha-2</summary>
        [JsonProperty("countryCode")]
        [StringLength(2, MinimumLength = 2)]
        public string CountryCode { get; set; }

        /// <summary>The vat rate to use for this country and product</summary>
        [JsonProperty("vatRate")]
        [Range(0.0D, 100.0D)]
        public double VatRate { get; set; }
    }
}