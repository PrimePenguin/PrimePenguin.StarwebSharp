using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class MediaFileModelItem
    {
        [JsonProperty("data")]
        public MediaFileModel Data { get; set; } = new MediaFileModel();
    }
}