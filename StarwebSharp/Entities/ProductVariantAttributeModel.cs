using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductVariantAttributeModel
    {
        /// <summary>The id for this attribute</summary>
        [JsonProperty("attributeId")]
        public int AttributeId { get; set; }

        /// <summary>A collection of attribute languages</summary>
        [JsonProperty("languages")]
        public Languages2 Languages { get; set; } = new Languages2();
    }
}