using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductBundleProductPriceModel
    {
        /// <summary>The pricelist this price is for</summary>
        [JsonProperty("pricelistId", NullValueHandling = NullValueHandling.Ignore)]
        public int PricelistId { get; set; }

        /// <summary>The special price excluding vat (a discounted price)</summary>
        [JsonProperty("specialPriceExVat", NullValueHandling = NullValueHandling.Ignore)]
        [Range(0D, int.MaxValue)]
        public double? SpecialPriceExVat { get; set; }
    }
}