using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using StarwebSharp.Entities;

namespace StarwebSharp.Services.ProductVariant
{
    public class ProductVariantCreateUpdateModel
    {
        [JsonProperty("variantId", NullValueHandling = NullValueHandling.Ignore)]
        public int? VariantId { get; set; }

        /// <summary>The product variants SKU (stock keeping unit)</summary>
        [JsonProperty("sku", NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(40)]
        public string Sku { get; set; }

        /// <summary>Is this variant active? Only active variants are visible to customers</summary>
        [JsonProperty("isActive", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsActive { get; set; } = true;

        /// <summary>The sort index of this variant.</summary>
        [JsonProperty("sortIndex", NullValueHandling = NullValueHandling.Ignore)]
        public int? SortIndex { get; set; }

        /// <summary>
        ///     The ID of the variants stock status. Available stock statuses can be fetched using the /product-stock-statuses
        ///     endpoint
        /// </summary>
        [JsonProperty("stockStatusId", NullValueHandling = NullValueHandling.Ignore)]
        public int? StockStatusId { get; set; }

        /// <summary>The current stock quantity for this variant</summary>
        [JsonProperty("stockQuantity", NullValueHandling = NullValueHandling.Ignore)]
        [Range(-100000000, 100000000)]
        public int? StockQuantity { get; set; }

        /// <summary>The variants weight in KG</summary>
        [JsonProperty("weightInKg", NullValueHandling = NullValueHandling.Ignore)]
        [Range(0.0D, int.MaxValue)]
        public double? WeightInKg { get; set; }

        /// <summary>The cost for this variant. Used for statistic and never displayed to customers</summary>
        [JsonProperty("costPrice", NullValueHandling = NullValueHandling.Ignore)]
        public string CostPrice { get; set; }

        /// <summary>European article no</summary>
        [JsonProperty("ean", NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(20)]
        public string Ean { get; set; }

        /// <summary>Manufacturer part no</summary>
        [JsonProperty("mpn", NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(40)]
        public string Mpn { get; set; }

        /// <summary>The ID of this variant main image. Available media files can be fetched using the /media-files endpoint</summary>
        [JsonProperty("imageFileId", NullValueHandling = NullValueHandling.Ignore)]
        public int? ImageFileId { get; set; }

        /// <summary>
        ///     An array of attribute value IDs that this variant belongs to. This field is mandatory for products variants if
        ///     the product´s hasSeveralVariants field is set to true
        /// </summary>
        [JsonProperty("attributeValueLinks", NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int> AttributeValueLinks { get; set; }

        /// <summary>A collection of product variant prices</summary>
        [JsonProperty("prices", NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ProductVariantPriceModel> Prices { get; set; }

        /// <summary>A collection of product variant attribute values</summary>
        [JsonProperty("attributeValues", NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ProductVariantAttributeValueModel> AttributeValues { get; set; }
    }
}