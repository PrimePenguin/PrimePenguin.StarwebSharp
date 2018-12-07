using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class PaymentMethodModelCollection
    {
        /// <summary>A collection of payment methods</summary>
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<PaymentMethodModel> Data { get; set; } =
            new Collection<PaymentMethodModel>();
    }
}