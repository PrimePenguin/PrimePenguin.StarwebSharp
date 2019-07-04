using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class MediaFileUploadModel
    {
        [JsonProperty("file")]
        public string File { get; set; }
    }
}