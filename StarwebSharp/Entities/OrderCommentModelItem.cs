using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class OrderCommentModelItem
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public OrderCommentModel Data { get; set; }
    }
}