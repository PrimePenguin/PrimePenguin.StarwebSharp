using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductsAttributesModelItem
    {
        /// <summary>The id for this attribute</summary>
        [JsonProperty("attributeId",
            NullValueHandling = NullValueHandling.Ignore)]
        public int? AttributeId { get; set; }
    }
}