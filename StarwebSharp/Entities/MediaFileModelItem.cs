using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class MediaFileModelItem
    {
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public MediaFileModel Data { get; set; } = new MediaFileModel();
    }
}