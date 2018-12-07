using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductVatRateModelCollection
    {
        /// <summary>A collection of product vat rates</summary>
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ProductVatRateModel> Data { get; set; } =
            new Collection<ProductVatRateModel>();
    }
}