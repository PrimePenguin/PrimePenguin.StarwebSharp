using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class WebHookModelItem
    {
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public WebHookModel Data { get; set; } = new WebHookModel();
    }
}