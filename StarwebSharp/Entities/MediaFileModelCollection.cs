using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class MediaFileModelCollection
    {
        /// <summary>A collection of media files</summary>
        [JsonProperty("data")]
        public ICollection<MediaFileModel> Data { get; set; } =
            new Collection<MediaFileModel>();

        [JsonProperty("meta")]
        public Meta Meta { get; set; } = new Meta();
    }
}