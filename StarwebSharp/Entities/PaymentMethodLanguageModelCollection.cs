using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class PaymentMethodLanguageModelCollection
    {
        /// <summary>A collection of payment method languages</summary>
        [JsonProperty("data")]
        public ICollection<PaymentMethodLanguageModel> Data { get; set; } =
            new Collection<PaymentMethodLanguageModel>();
    }
}