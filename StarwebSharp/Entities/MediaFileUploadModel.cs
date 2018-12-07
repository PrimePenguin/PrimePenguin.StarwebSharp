using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class MediaFileUploadModel
    {
        [JsonProperty("file",
            NullValueHandling = NullValueHandling.Ignore)]
        public string File { get; set; }
    }
}