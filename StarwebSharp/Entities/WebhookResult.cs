using System;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class WebhookResult
    {
        [JsonProperty("eventId", NullValueHandling = NullValueHandling.Ignore)]
        public string EventId { get; set; }

        [JsonProperty("shopIdCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopIdCode { get; set; }

        [JsonProperty("eventTimeStamp", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime EventTimeStamp { get; set; }
    }
}