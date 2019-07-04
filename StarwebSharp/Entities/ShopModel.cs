using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ShopModel
    {
        /// <summary>The shop name</summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>A unique id code for this shop</summary>
        [JsonProperty("idCode")]
        public string IdCode { get; set; }

        /// <summary>The current status of this shop. Possible values are: open, closed, inactive</summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>Shops default language code</summary>
        [JsonProperty("defaultLangCode")]
        public string DefaultLangCode { get; set; }

        /// <summary>Active languages in shop</summary>
        [JsonProperty("activeLangCodes")]
        public ICollection<string> ActiveLangCodes { get; set; } =
            new Collection<string>();

        /// <summary>The shops base currency. All currencies and related data can be fetched using the /currencies endpoint</summary>
        [JsonProperty("baseCurrency")]
        public string BaseCurrency { get; set; }

        /// <summary>The default customer country</summary>
        [JsonProperty("defaultCustomerCountryCode")]
        public string DefaultCustomerCountryCode { get; set; }

        /// <summary>The default vat rate for new products</summary>
        [JsonProperty("generalDefaultVatRate")]
        [Range(0.0D, int.MaxValue)]
        public double GeneralDefaultVatRate { get; set; }

        /// <summary>The company running this web shop</summary>
        [JsonProperty("shopCompanyName")]
        public string ShopCompanyName { get; set; }

        /// <summary>The address to the web shop</summary>
        [JsonProperty("shopAddress")]
        public string ShopAddress { get; set; }

        /// <summary>The postal code to the web shop</summary>
        [JsonProperty("shopPostalCode")]
        public string ShopPostalCode { get; set; }

        /// <summary>The city to the web shop</summary>
        [JsonProperty("shopCity")]
        public string ShopCity { get; set; }

        /// <summary>The business id of the company running the web shop</summary>
        [JsonProperty("shopOrgNo")]
        public string ShopOrgNo { get; set; }

        /// <summary>The contact phone number to the web shop</summary>
        [JsonProperty("shopPhoneNo")]
        public string ShopPhoneNo { get; set; }

        /// <summary>The EU VAT number of the company running the web shop</summary>
        [JsonProperty("shopVatNo")]
        public string ShopVatNo { get; set; }

        /// <summary>The country the company behind the web shop resides in</summary>
        [JsonProperty("shopCountryCode")]
        public string ShopCountryCode { get; set; }
    }
}