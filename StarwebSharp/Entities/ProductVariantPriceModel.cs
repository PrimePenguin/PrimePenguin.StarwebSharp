using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductVariantPriceModel
    {
        /// <summary>The pricelist this price is for</summary>
        [JsonProperty("pricelistId")]
        public int PricelistId { get; set; }

        /// <summary>The price excluding vat</summary>
        [JsonProperty("priceExVat")]
        [Range(0.0D, int.MaxValue)]
        public double PriceExVat { get; set; }

        /// <summary>The special price excluding vat (a discounted price)</summary>
        [JsonProperty("specialPriceExVat")]
        [Range(0.0D, int.MaxValue)]
        public double? SpecialPriceExVat { get; set; }
    }
}