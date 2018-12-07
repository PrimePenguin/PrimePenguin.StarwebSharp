using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class OrderCommentModel
    {
        /// <summary>The comments id</summary>
        [JsonProperty("commentId",
            NullValueHandling = NullValueHandling.Ignore)]
        public int CommentId { get; set; }

        /// <summary>A timestamp of when the comment was created. The time should be formatted using ISO-8601</summary>
        [JsonProperty("createdAt",
            NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>The comment</summary>
        [JsonProperty("text",
            NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>The author of the comment. Either ”admin” or ”customer”</summary>
        [JsonProperty("from",
            NullValueHandling = NullValueHandling.Ignore)]
        public string From { get; set; }
    }
}