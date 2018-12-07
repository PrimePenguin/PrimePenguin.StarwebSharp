using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class WebHookModelCollection
    {
        /// <summary>A list of web hooks</summary>
        [JsonProperty("data",
            NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<WebHookModel> Data { get; set; } =
            new Collection<WebHookModel>();
    }
}