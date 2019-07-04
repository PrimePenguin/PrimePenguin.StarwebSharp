using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ShippingMethodLanguageModel
    {
        /// <summary>Language code</summary>
        [JsonProperty("langCode")]
        public string LangCode { get; set; }

        /// <summary>Name of shipping method</summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>Title of shipping method</summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>A shorter informative description</summary>
        [JsonProperty("shortDescription")]
        public string ShortDescription { get; set; }
    }
}