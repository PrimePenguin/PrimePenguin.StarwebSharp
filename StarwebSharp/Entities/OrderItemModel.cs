using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using StarwebSharp.Enums;

namespace StarwebSharp.Entities
{
    public class OrderItemModel
    {
        /// <summary>The id of the order item</summary>
        [JsonProperty("itemId", NullValueHandling = NullValueHandling.Ignore)]
        public int ItemId { get; set; }

        /// <summary>The SKU of the order item</summary>
        [JsonProperty("sku", NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(40)]
        public string Sku { get; set; }

        /// <summary>The description of the order item</summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string Description { get; set; }

        /// <summary>The quantity of the order item</summary>
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        [Range(-1000000, 1000000)]
        public int Quantity { get; set; }

        /// <summary>The unit symbol of the order item</summary>
        [JsonProperty("unitSymbol", NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(5)]
        public string UnitSymbol { get; set; }

        /// <summary>The price per unit excluding VAT</summary>
        [JsonProperty("unitPrice", NullValueHandling = NullValueHandling.Ignore)]
        public double UnitPrice { get; set; }

        /// <summary>The items VAT rate in percent. 25.0 = 25% VAT</summary>
        [JsonProperty("vatRate", NullValueHandling = NullValueHandling.Ignore)]
        [Range(0, 100)]
        public double VatRate { get; set; }

        /// <summary>The discount for the entire order row. Either as a percentage or an amount. If this is an amount and set to 20.0, the sum 20.0 will be subtracted from the order total no matter what the quantity is set to.</summary>
        [JsonProperty("discount", NullValueHandling = NullValueHandling.Ignore)]
        [Range(0, int.MaxValue)]
        public double Discount { get; set; }

        /// <summary>The type of discount. Either ”amount” or ”percent”. Default is ”percent”</summary>
        [JsonProperty("discountType", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderItemModelDiscountType DiscountType { get; set; }

        /// <summary>The sort order of the order items</summary>
        [JsonProperty("sortIndex", NullValueHandling = NullValueHandling.Ignore)]
        [Range(0, int.MaxValue)]
        public int SortIndex { get; set; }
    }
}