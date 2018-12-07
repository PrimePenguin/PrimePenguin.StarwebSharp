using Newtonsoft.Json;
using StarwebSharp.Infrastructure;

namespace StarwebSharp.Filters
{
    public class OrderFilter : Parameterizable
    {
        /// <summary>
        /// Page of results to be returned. Default is 1.
        /// </summary>
        [JsonProperty("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Set to true if you want to fetch orders that has not been completed yet. An order is ”completed” when the payment step has been completed successfully.
        /// </summary>
        [JsonProperty("includeNonCompletePayments")]
        public bool IncludeNonCompletePayments { get; set; }

        /// <summary>
        /// A filter query to filter the fetched orders by. Will search in fields such as: customer/company name, order items sku and description, etc
        /// </summary>
        [JsonProperty("filterQuery")]
        public string FilterQuery { get; set; }

        /// <summary>
        /// Only fetch orders with a certain payment method Id
        /// </summary>
        [JsonProperty("filterPaymentMethodId")]
        public int? FilterPaymentMethodId { get; set; }

        /// <summary>
        /// Only fetch orders with a certain shipping method Id
        /// </summary>
        [JsonProperty("filterShippingMethodId")]
        public int? FilterShippingMethodId { get; set; }

        /// <summary>
        /// Only fetch orders created after this timestamp (The time should be formatted using ISO-8601 and url encoded)
        /// </summary>
        [JsonProperty("ordersCreatedAfter")]
        public string OrdersCreatedAfter { get; set; }

        /// <summary>
        /// Only fetch orders created before this timestamp (The time should be formatted using ISO-8601 and url encoded)
        /// </summary>
        [JsonProperty("ordersCreatedBefore")]
        public string OrdersCreatedBefore { get; set; }

        /// <summary>
        /// Only fetch orders with the specifiec order status. Use order status ID
        /// </summary>
        [JsonProperty("statusFilter")]
        public string StatusFilter { get; set; }

        /// <summary>
        /// Sort the result using a specified field. orderId is default
        /// Available values : orderId, createdAt, modifiedAt, customer, paymentMethodName, shippingMethodName, totalAmount, status, read
        /// </summary>
        [JsonProperty("sortBy")]
        public string SortBy { get; set; }

        /// <summary>
        /// ASC for an ascending sort order; or DESC for a descending sort order. DESC is default
        /// Available values : ASC, DESC
        /// </summary>
        [JsonProperty("sortOrder")]
        public string SortOrder { get; set; }

        /// <summary>
        /// If you want to include child data in the result.
        /// Example: ?include=items (to include order items) or ?include=items,externalServices (to include order items as well as external ids).
        /// Available includes: items, externalServices, status, customer, addresses
        /// </summary>
        [JsonProperty("include")]
        public string Include { get; set; }
    }
}
