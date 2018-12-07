using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductCategoryModel
    {
        /// <summary>The product category Id</summary>
        [JsonProperty("categoryId", NullValueHandling = NullValueHandling.Ignore)]
        public int CategoryId { get; set; }

        /// <summary>The category`s parent`s Id</summary>
        [JsonProperty("parentId", NullValueHandling = NullValueHandling.Ignore)]
        public int? ParentId { get; set; }

        /// <summary>
        ///     The category`s visibility settings. Possible values are: visible, hidden and pricelists. Pricelists means that
        ///     the category is only visible for customers with access to specific pricelists
        /// </summary>
        [JsonProperty("visibility", NullValueHandling = NullValueHandling.Ignore)]
        public string Visibility { get; set; }

        /// <summary>Sort index. A category with a lower value is displayed higher up in lists</summary>
        [JsonProperty("sortIndex", NullValueHandling = NullValueHandling.Ignore)]
        public int? SortIndex { get; set; }

        /// <summary>
        ///     Whether or not links to the category should open a category page listing its products and sub categories on
        ///     click.
        /// </summary>
        [JsonProperty("openPage", NullValueHandling = NullValueHandling.Ignore)]
        public bool OpenPage { get; set; }

        /// <summary>The Id to the category`s image file. Has to be an existing mediaFile</summary>
        [JsonProperty("imageFileId", NullValueHandling = NullValueHandling.Ignore)]
        public int? ImageFileId { get; set; }

        /// <summary>The system name the externalId belongs to.</summary>
        [JsonProperty("externalType", NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(20)]
        public string ExternalType { get; set; }

        /// <summary>The external Id for this category for the system named in externalType</summary>
        [JsonProperty("externalId", NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(40)]
        public string ExternalId { get; set; }

        /// <summary>Whether or not the category has any children categories</summary>
        [JsonProperty("hasChildren", NullValueHandling = NullValueHandling.Ignore)]
        public bool HasChildren { get; set; }

        [JsonProperty("languages", NullValueHandling = NullValueHandling.Ignore)]
        public ProductCategoryLanguagesModelCollection Languages { get; set; }
    }
}