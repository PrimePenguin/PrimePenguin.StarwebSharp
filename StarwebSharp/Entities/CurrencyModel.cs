using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class CurrencyModel
    {
        /// <summary>The currency code</summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        ///     The exchange rate against the shops default currency. Used in reports, etc. The default currency can be
        ///     fetched from /shop
        /// </summary>
        [JsonProperty("exchangeRate")]
        public double ExchangeRate { get; set; }

        /// <summary>The number of decimals to show and use</summary>
        [JsonProperty("precision")]
        public int? Precision { get; set; }
    }
}