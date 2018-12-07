using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductMediaFileLinkModel
    {
        /// <summary>This links ID</summary>
        [JsonProperty("productMediaFileId",
            NullValueHandling = NullValueHandling.Ignore)]
        public int ProductMediaFileId { get; set; }

        /// <summary>The media file this link points to. You can fetch available media files from the /media-files endpoint</summary>
        [JsonProperty("mediaFileId", Required = Required.Always)]
        public int? MediaFileId { get; set; }

        /// <summary>
        ///     The sort index of these media file links. Note that after the item is saved the sort index will be rearranged
        ///     so that the item with the lowest sort index always get sort index 0, the next one 1, and so on.
        /// </summary>
        [JsonProperty("sortIndex",
            NullValueHandling = NullValueHandling.Ignore)]
        public int? SortIndex { get; set; }

        /// <summary>The type of file this link points to. Can be either ”image” or ”document”</summary>
        [JsonProperty("type",
            NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }
}