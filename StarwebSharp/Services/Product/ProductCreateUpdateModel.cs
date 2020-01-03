using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using StarwebSharp.Entities;

namespace StarwebSharp.Services.Product
{
    public class ProductCreateUpdateModel
    {
        [JsonProperty("productId", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductId { get; set; }

        /// <summary>
        ///     The default vat rate for this product. Will fall back to shop default if null. To fetch country specific vat
        ///     rates, please use include=vatRates or use the /products/x/vat-rates endpoint.
        /// </summary>
        [JsonProperty("defaultVatRate", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultVatRate { get; set; }

        /// <summary>The visibility of this product. Supported values are: hidden, visible, pricelists</summary>
        [JsonProperty("visibility", NullValueHandling = NullValueHandling.Ignore)]
        public string Visibility { get; set; } = "visible";

        /// <summary>A valid URL to a web page with more information for this product</summary>
        [JsonProperty("moreInfoUrl", NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string MoreInfoUrl { get; set; }

        /// <summary>
        ///     The id of the manufacturer to use for this product. Fetch and handle available manufacturers using the
        ///     /product-manufacturers endpoint
        /// </summary>
        [JsonProperty("manufacturerId", NullValueHandling = NullValueHandling.Ignore)]
        public int? ManufacturerId { get; set; }

        /// <summary>
        ///     The id of the unit to use for this product if not standard. Fetch and handle available units using the
        ///     /product-units endpoint
        /// </summary>
        [JsonProperty("unitId", NullValueHandling = NullValueHandling.Ignore)]
        public int? UnitId { get; set; }

        /// <summary>Sort index for this product in a list</summary>
        [JsonProperty("sortIndex", NullValueHandling = NullValueHandling.Ignore)]
        [Range(1, 10000)]
        public int? SortIndex { get; set; }

        /// <summary>Should this product be watchable for customers when it is back in stock?</summary>
        [JsonProperty("isBackInStockWatchable", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsBackInStockWatchable { get; set; } = true;

        /// <summary>Account number for managing accounting on product level</summary>
        [JsonProperty("accounting", NullValueHandling = NullValueHandling.Ignore)]
        [Range(100, 9999)]
        public int? Accounting { get; set; }

        [JsonProperty("variants", NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ProductVariantModel> Variants { get; set; }

        [JsonProperty("mediaFiles", NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ProductMediaFileLinkModel> MediaFiles { get; set; }

        [JsonProperty("languages", NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ProductLanguageSlimModel> Languages { get; set; }

        [JsonProperty("vatRates", NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ProductVatRateModel> VatRates { get; set; }

        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ProductCategoryLinkModel> Categories { get; set; }

        [JsonProperty("metaData", NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ProductMetaDataModel> MetaData { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("visibilityPricelistIds")]
        public ICollection<int> VisibilityPriceListIds { get; set; } = new Collection<int>();

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("bundleUseManualPrice")]
        public bool BundleUseManualPrice { get; set; }

        [JsonProperty("bundledProducts", NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<BundledProductsModel> BundledProducts { get; set; }
    }
}