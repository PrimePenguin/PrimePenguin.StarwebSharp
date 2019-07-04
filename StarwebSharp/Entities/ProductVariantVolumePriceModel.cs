using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductVariantVolumePriceModel
    {
        /// <summary>The pricelist this price is for</summary>
        [JsonProperty("pricelistId")]
        public int PricelistId { get; set; }

        /// <summary>The price excluding vat</summary>
        [JsonProperty("priceExVat")]
        [Range(0D, int.MaxValue)]
        public double PriceExVat { get; set; }

        /// <summary>The minimum quantity required for the price to apply</summary>
        [JsonProperty("quantity")]
        [Range(2, int.MaxValue)]
        public double Quantity { get; set; }
    }
}