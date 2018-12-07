using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class PaymentMethodLanguageModel
    {
        /// <summary>Language code</summary>
        [JsonProperty("langCode",
            NullValueHandling = NullValueHandling.Ignore)]
        public string LangCode { get; set; }

        /// <summary>Name of payment method</summary>
        [JsonProperty("name",
            NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>Title of payment method</summary>
        [JsonProperty("title",
            NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>A shorter informative description</summary>
        [JsonProperty("shortDescription",
            NullValueHandling = NullValueHandling.Ignore)]
        public string ShortDescription { get; set; }
    }
}