using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class VatRateModelItem
    {
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public VatRateModel Data { get; set; } = new VatRateModel();
    }
}