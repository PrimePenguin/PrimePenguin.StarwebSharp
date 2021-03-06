using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using StarwebSharp.Enums;

namespace StarwebSharp.Entities
{
    public class OrderItemModel
    {
        /// <summary>The id of the order item</summary>
        [JsonProperty("itemId")]
        public int ItemId { get; set; }

        /// <summary>The SKU of the order item</summary>
        [JsonProperty("sku")]
        [StringLength(40)]
        public string Sku { get; set; }

        /// <summary>The description of the order item</summary>
        [JsonProperty("description")]
        [StringLength(255)]
        public string Description { get; set; }

        /// <summary>The quantity of the order item</summary>
        [JsonProperty("quantity")]
        [Range(-1000000, 1000000)]
        public int? Quantity { get; set; }

        /// <summary>The unit symbol of the order item</summary>
        [JsonProperty("unitSymbol")]
        [StringLength(5)]
        public string UnitSymbol { get; set; }

        /// <summary>The price per unit excluding VAT</summary>
        [JsonProperty("unitPrice")]
        public double UnitPrice { get; set; }

        /// <summary>The items VAT rate in percent. 25.0 = 25% VAT</summary>
        [JsonProperty("vatRate")]
        [Range(0, 100)]
        public double VatRate { get; set; }

        /// <summary>
        ///     The discount for the entire order row. Either as a percentage or an amount. If this is an amount and set to
        ///     20.0, the sum 20.0 will be subtracted from the order total no matter what the quantity is set to.
        /// </summary>
        [JsonProperty("discount")]
        [Range(0, int.MaxValue)]
        public double Discount { get; set; }

        /// <summary>The type of discount. Either ”amount” or ”percent”. Default is ”percent”</summary>
        [JsonProperty("discountType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderItemModelDiscountType DiscountType { get; set; }

        /// <summary>The sort order of the order items</summary>
        [JsonProperty("sortIndex")]
        [Range(0, int.MaxValue)]
        public int? SortIndex { get; set; }

        [JsonProperty("bundledItems")]
        public OrderBundledItemModelCollection OrderBundledItems { get; set; } =
            new OrderBundledItemModelCollection();

        /// <summary>
        /// Order item links
        /// </summary>
        [JsonProperty("links")]
        public EntityLink[] Links { get; set; }
    }

    public class OrderBundledItemModelCollection
    {
        /// <summary>A collection of bundled items</summary>
        [JsonProperty("data")]
        public ICollection<OrderBundledItem> Data { get; set; } =
            new Collection<OrderBundledItem>();
    }

    public class OrderBundledItem
    {
        [JsonProperty("itemId")]
        public int? ItemId { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("quantity")]
        public int? Quantity { get; set; }

        [JsonProperty("unitSymbol")]
        public string UnitSymbol { get; set; }

        [JsonProperty("unitPrice")]
        public decimal? UnitPrice { get; set; }

        [JsonProperty("vatRate")]
        public int? VatRate { get; set; }

        [JsonProperty("discount")]
        public decimal? Discount { get; set; }

        [JsonProperty("discountType")]
        public OrderItemModelDiscountType DiscountType { get; set; }

        [JsonProperty("sortIndex")]
        public int? SortIndex { get; set; }

        /// <summary>
        /// Order item links
        /// </summary>
        [JsonProperty("links")]
        public EntityLink[] Links { get; set; }
    }
}