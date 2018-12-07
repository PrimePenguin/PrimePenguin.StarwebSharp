using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductVariantAttributeModel
    {
        /// <summary>The id for this attribute</summary>
        [JsonProperty("attributeId",
            NullValueHandling = NullValueHandling.Ignore)]
        public int AttributeId { get; set; }

        /// <summary>A collection of attribute languages</summary>
        [JsonProperty("languages",
            NullValueHandling = NullValueHandling.Ignore)]
        public Languages2 Languages { get; set; } = new Languages2();
    }
}