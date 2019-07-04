using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class OrderCommentModelItem
    {
        [JsonProperty("data")]
        public OrderCommentModel Data { get; set; } = new OrderCommentModel();
    }
}