using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class EntityLink
    {
        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }
}
