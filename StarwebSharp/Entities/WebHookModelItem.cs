using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class WebHookModelItem
    {
        [JsonProperty("data")]
        public WebHookModel Data { get; set; } = new WebHookModel();
    }
}