using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductMediaFileLinkModel
    {
        /// <summary>This links ID</summary>
        [JsonProperty("productMediaFileId")]
        public int ProductMediaFileId { get; set; }

        /// <summary>The media file this link points to. You can fetch available media files from the /media-files endpoint</summary>
        [JsonProperty("mediaFileId")]
        public int? MediaFileId { get; set; }

        /// <summary>
        ///     The sort index of these media file links. Note that after the item is saved the sort index will be rearranged
        ///     so that the item with the lowest sort index always get sort index 0, the next one 1, and so on.
        /// </summary>
        [JsonProperty("sortIndex")]
        public int? SortIndex { get; set; }

        /// <summary>The type of file this link points to. Can be either ”image” or ”document”</summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Media file link
        /// </summary>
        [JsonProperty("links")]
        public EntityLink[] Links { get; set; }
    }
}