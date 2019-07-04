using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductStockStatusModel
    {
        /// <summary>The stock status id</summary>
        [JsonProperty("stockStatusId")]
        public int StockStatusId { get; set; }

        /// <summary>
        ///     The idCode of the status. Only standard statuses has idCodes set. It is also not permitted to change names for
        ///     standard statuses
        /// </summary>
        [JsonProperty("idCode")]
        [StringLength(20)]
        public string IdCode { get; set; }

        /// <summary>Sort index for this status</summary>
        [JsonProperty("sortIndex")]
        public int? SortIndex { get; set; }

        /// <summary>
        ///     This has to be set to another, existing stock status id, or null. If a product has its quantity changed to
        ///     negative, the product will then change stock status to the one with this id
        /// </summary>
        [JsonProperty("stockoutNewStatusId")]
        public int? StockoutNewStatusId { get; set; }

        /// <summary>Is the product buyable when this status is set?</summary>
        [JsonProperty("productBuyable")]
        public bool ProductBuyable { get; set; } = true;

        /// <summary>Should the product be displayed as "in stock" when this status is set?</summary>
        [JsonProperty("inStock")]
        public bool InStock { get; set; }

        [JsonProperty("languages")]
        public ProductStockStatusLanguageModelCollection Languages { get; set; } =
            new ProductStockStatusLanguageModelCollection();
    }
}