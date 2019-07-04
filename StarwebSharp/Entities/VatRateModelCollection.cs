using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class VatRateModelCollection
    {
        /// <summary>A collection of country vat rates</summary>
        [JsonProperty("data")]
        public ICollection<VatRateModel> Data { get; set; } =
            new Collection<VatRateModel>();
    }
}