using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class VatRateModelItem
    {
        [JsonProperty("data")]
        public VatRateModel Data { get; set; } = new VatRateModel();
    }
}