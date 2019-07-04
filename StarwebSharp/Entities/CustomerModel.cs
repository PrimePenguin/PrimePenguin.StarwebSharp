using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class CustomerModel
    {
        /// <summary>The customers ID</summary>
        [JsonProperty("customerId")]
        public int CustomerId { get; set; }

        /// <summary>A timestamp of when the customer was created. The time should be formatted using ISO-8601</summary>
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        /// <summary>The type of customer this is. Either: ”person” or ”company”</summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>Email address of the customer</summary>
        [JsonProperty("email")]
        [StringLength(255)]
        public string Email { get; set; }

        /// <summary>National id number of the customer</summary>
        [JsonProperty("nationalIdNo")]
        [StringLength(20)]
        public string NationalIdNo { get; set; }

        /// <summary>VAT number of the customer</summary>
        [JsonProperty("vatNo")]
        [StringLength(20)]
        public string VatNo { get; set; }

        /// <summary>
        ///     Custom info saved to a customer. Can be linked to text fields on the customer registration page for additional
        ///     data collection
        /// </summary>
        [JsonProperty("customInfo1")]
        [StringLength(255)]
        public string CustomInfo1 { get; set; }

        /// <summary>
        ///     Custom info saved to a customer. Can be linked to text fields on the customer registration page for additional
        ///     data collection
        /// </summary>
        [JsonProperty("customInfo2")]
        [StringLength(255)]
        public string CustomInfo2 { get; set; }

        /// <summary>A timestamp of when the customer was modified. The time should be formatted using ISO-8601</summary>
        [JsonProperty("modifiedAt")]
        public string ModifiedAt { get; set; }

        /// <summary>If the customer is approved or not. Can be null if the customer is neither approved nor disapproved yet</summary>
        [JsonProperty("approved")]
        public bool? Approved { get; set; }

        /// <summary>A timestamp of when the customer was was approved/disapproved. The time should be formatted using ISO-8601</summary>
        [JsonProperty("approvedAt")]
        public string ApprovedAt { get; set; }

        /// <summary>The id of the pricelist the customer is linked to (or null if the customer has no specific pricelist linked)</summary>
        [JsonProperty("pricelistId")]
        public int? PricelistId { get; set; }

        [JsonProperty("tags")]
        public CustomerTagModelCollection Tags { get; set; }

        [JsonProperty("addresses")]
        public CustomerAddressesModelCollection Addresses { get; set; }

        [JsonProperty("externalServices")]
        public CustomerExternalServicesModelCollection ExternalServices { get; set; }
    }
}