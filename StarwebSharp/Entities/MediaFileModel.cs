using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class MediaFileModel
    {
        /// <summary>The media file ID</summary>
        [JsonProperty("mediaFileId")]
        public int MediaFileId { get; set; }

        /// <summary>The name of the media file</summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>A timestamp of when the media file was created. The time should be formatted using ISO-8601</summary>
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        /// <summary>A timestamp of when the media file was modifies. The time should be formatted using ISO-8601</summary>
        [JsonProperty("modifiedAt")]
        public string ModifiedAt { get; set; }

        /// <summary>The media files size in bytes</summary>
        [JsonProperty("size")]
        public int? Size { get; set; }

        /// <summary>The media files mime type</summary>
        [JsonProperty("mime")]
        public string Mime { get; set; }

        /// <summary>The media files height in pixels</summary>
        [JsonProperty("height")]
        public int? Height { get; set; }

        /// <summary>The media files width in pixels</summary>
        [JsonProperty("width")]
        public int? Width { get; set; }

        /// <summary>The media files URL</summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("links")]
        public EntityLink[] Links { get; set; }
    }
}