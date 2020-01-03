using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        /// <summary>A collection of product variant volume prices</summary>
        [JsonProperty("volumePrices")]
        public ProductVariantvolumePricesModelCollection VolumePrices { get; set; } = 
            new ProductVariantvolumePricesModelCollection();
    }

    public class ProductVariantvolumePricesModelCollection
    {
        /// <summary>A collection of product variants</summary>
        [JsonProperty("data")]
        public ICollection<ProductVariantvolumePriceModel> Data { get; set; } =
            new Collection<ProductVariantvolumePriceModel>();
    }

    public class ProductVariantvolumePriceModel
    {
        /// <summary>The pricelist this price is for</summary>
        [JsonProperty("pricelistId")]
        public int PricelistId { get; set; }

        /// <summary>The price excluding vat</summary>
        [JsonProperty("priceExVat")]
        [Range(0.0D, int.MaxValue)]
        public double PriceExVat { get; set; }

        /// <summary>The special price excluding vat (a discounted price)</summary>
        [JsonProperty("quantity")]
        [Range(0.0D, int.MaxValue)]
        public int? Quantity { get; set; }

    }
}