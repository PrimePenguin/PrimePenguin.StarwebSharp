using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class MediaFileModel
    {
        /// <summary>The media file ID</summary>
        [JsonProperty("mediaFileId",
            NullValueHandling = NullValueHandling.Ignore)]
        public int MediaFileId { get; set; }

        /// <summary>The name of the media file</summary>
        [JsonProperty("name",
            NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>A timestamp of when the media file was created. The time should be formatted using ISO-8601</summary>
        [JsonProperty("createdAt",
            NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>A timestamp of when the media file was modifies. The time should be formatted using ISO-8601</summary>
        [JsonProperty("modifiedAt",
            NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedAt { get; set; }

        /// <summary>The media files size in bytes</summary>
        [JsonProperty("size",
            NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>The media files mime type</summary>
        [JsonProperty("mime",
            NullValueHandling = NullValueHandling.Ignore)]
        public string Mime { get; set; }

        /// <summary>The media files height in pixels</summary>
        [JsonProperty("height",
            NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }

        /// <summary>The media files width in pixels</summary>
        [JsonProperty("width",
            NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }

        /// <summary>The media files URL</summary>
        [JsonProperty("url",
            NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }
    }
}