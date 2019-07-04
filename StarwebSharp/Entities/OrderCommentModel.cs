using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class OrderCommentModel
    {
        /// <summary>The comments id</summary>
        [JsonProperty("commentId")]
        public int CommentId { get; set; }

        /// <summary>A timestamp of when the comment was created. The time should be formatted using ISO-8601</summary>
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        /// <summary>The comment</summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>The author of the comment. Either ”admin” or ”customer”</summary>
        [JsonProperty("from")]
        public string From { get; set; }
    }
}