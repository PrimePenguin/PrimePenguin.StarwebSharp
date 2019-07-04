using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductVariantModel
    {
        [JsonProperty("variantId")]
        public int VariantId { get; set; }

        /// <summary>The product variants SKU (stock keeping unit)</summary>
        [JsonProperty("sku")]
        [StringLength(40)]
        public string Sku { get; set; }

        /// <summary>Is this variant active? Only active variants are visible to customers</summary>
        [JsonProperty("isActive")]
        public bool IsActive { get; set; } = true;

        /// <summary>The sort index of this variant.</summary>
        [JsonProperty("sortIndex")]
        public int? SortIndex { get; set; }

        /// <summary>
        ///     The ID of the variants stock status. Available stock statuses can be fetched using the /product-stock-statuses
        ///     endpoint
        /// </summary>
        [JsonProperty("stockStatusId")]
        public int? StockStatusId { get; set; }

        /// <summary>The current stock quantity for this variant</summary>
        [JsonProperty("stockQuantity")]
        [Range(-100000000, 100000000)]
        public int? StockQuantity { get; set; }

        /// <summary>The variants weight in KG</summary>
        [JsonProperty("weightInKg")]
        [Range(0.0D, int.MaxValue)]
        public double? WeightInKg { get; set; }

        /// <summary>The cost for this variant. Used for statistic and never displayed to customers</summary>
        [JsonProperty("costPrice")]
        public string CostPrice { get; set; }

        /// <summary>European article no</summary>
        [JsonProperty("ean")]
        [StringLength(20)]
        public string Ean { get; set; }

        /// <summary>Manufacturer part no</summary>
        [JsonProperty("mpn")]
        [StringLength(40)]
        public string Mpn { get; set; }

        /// <summary>The ID of this variant main image. Available media files can be fetched using the /media-files endpoint</summary>
        [JsonProperty("imageFileId")]
        public int? ImageFileId { get; set; }

        /// <summary>
        ///     An array of attribute value IDs that this variant belongs to. This field is mandatory for products variants if
        ///     the product´s hasSeveralVariants field is set to true
        /// </summary>
        [JsonProperty("attributeValueLinks")]
        public ICollection<int> AttributeValueLinks { get; set; } =
            new Collection<int>();

        /// <summary>A collection of product variant prices</summary>
        [JsonProperty("prices")]
        public ProductVariantPriceModelCollection Prices { get; set; } =
            new ProductVariantPriceModelCollection();

        /// <summary>A collection of product variant attribute values</summary>
        [JsonProperty("attributeValues")]
        public ProductVariantAttributeValueModelCollection AttributeValues { get; set; } =
            new ProductVariantAttributeValueModelCollection();
    }
}