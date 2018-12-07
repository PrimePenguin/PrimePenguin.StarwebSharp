using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class CustomerUpdateModel
    {
        /// <summary>The customers ID</summary>
        [JsonProperty("customerId",
            NullValueHandling = NullValueHandling.Ignore)]
        public int? CustomerId { get; set; }

        /// <summary>A timestamp of when the customer was created. The time should be formatted using ISO-8601</summary>
        [JsonProperty("createdAt",
            NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>The type of customer this is. Either: ”person” or ”company”</summary>
        [JsonProperty("type",
            NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>Email address of the customer</summary>
        [JsonProperty("email",
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string Email { get; set; }

        /// <summary>National id number of the customer</summary>
        [JsonProperty("nationalIdNo",
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(20)]
        public string NationalIdNo { get; set; }

        /// <summary>VAT number of the customer</summary>
        [JsonProperty("vatNo",
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(20)]
        public string VatNo { get; set; }

        /// <summary>
        ///     Custom info saved to a customer. Can be linked to text fields on the customer registration page for additional
        ///     data collection
        /// </summary>
        [JsonProperty("customInfo1",
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string CustomInfo1 { get; set; }

        /// <summary>
        ///     Custom info saved to a customer. Can be linked to text fields on the customer registration page for additional
        ///     data collection
        /// </summary>
        [JsonProperty("customInfo2",
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string CustomInfo2 { get; set; }

        /// <summary>The id of the pricelist the customer is linked to (or null if the customer has no specific pricelist linked)</summary>
        [JsonProperty("pricelistId",
            NullValueHandling = NullValueHandling.Ignore)]
        public int? PricelistId { get; set; }

        /// <summary>Language code for the customer</summary>
        [JsonProperty("langCode",
            NullValueHandling = NullValueHandling.Ignore)]
        public string LangCode { get; set; }

        [JsonProperty("addresses",
            NullValueHandling = NullValueHandling.Ignore)]
        public Addresses Addresses { get; set; } = new Addresses();
    }
}