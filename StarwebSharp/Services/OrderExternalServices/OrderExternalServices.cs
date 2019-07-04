using System.Net.Http;
using System.Threading.Tasks;
using StarwebSharp.Entities;
using StarwebSharp.Extensions;
using StarwebSharp.Infrastructure;

namespace StarwebSharp.Services.OrderExternalServices
{
    /// <summary>
    ///     A service for manipulating Starweb order external services.
    /// </summary>
    public class OrderExternalServices : StarwebService
    {
        /// <summary>
        ///     Creates a new instance of <see cref="OrderExternalServices" />.
        /// </summary>
        /// <param name="myStarwebUrl">The shop's *.mystrweb.se/api/vX URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public OrderExternalServices(string myStarwebUrl, string shopAccessToken) : base(myStarwebUrl, shopAccessToken)
        {
        }


        /// <summary>
        ///     Returns a list of order external services with given order id
        /// </summary>
        /// <param name="orderId">The id of the order.</param>
        /// <param name="include">
        ///     If you want to include child data in the result. Example: ?include=items (to include order items)
        ///     or ?include=items,externalServices (to include order items as well as external ids). Available includes: items,
        ///     externalServices, status, order, addresses
        /// </param>
        /// <returns>The <see cref="OrderExternalServiceModelCollection" />.</returns>
        public virtual async Task<OrderExternalServiceModelCollection> ListAsync(int orderId, string include = null)
        {
            var req = PrepareRequest($"orders/{orderId}/external-services");

            if (!string.IsNullOrEmpty(include)) req.QueryParams.Add("include", include);
            return await ExecuteRequestAsync<OrderExternalServiceModelCollection>(req, HttpMethod.Get, rootElement: "");
        }

        /// <summary>
        ///     Creates new external services <see cref="OrderExternalServiceModel" /> of order
        /// </summary>
        public virtual async Task<OrderExternalServicesModelItem> CreateAsync(int orderId,
            OrderExternalServiceModel externalService)
        {
            var req = PrepareRequest($"orders/{orderId}/external-services");
            var body = externalService.ToDictionary();
            var content = new JsonContent(body);
            return await ExecuteRequestAsync<OrderExternalServicesModelItem>(req, HttpMethod.Post, content, "data");
        }


        /// <summary>
        ///     Retrieves the <see cref="OrderExternalServicesModelItem" />of an order with the given order id.
        /// </summary>
        /// <param name="orderId">The id of the order to retrieve.</param>
        /// <param name="serviceName">The service name.</param>
        /// <param name="include">
        ///     If you want to include child data in the result. Example: ?include=items (to include order items)
        ///     or ?include=items,externalServices (to include order items as well as external ids). Available includes: items,
        ///     externalServices, status, order, addresses
        /// </param>
        /// <returns>The <see cref="OrderExternalServicesModelItem" />.</returns>
        public virtual async Task<OrderExternalServicesModelItem> GetAsync(int orderId, string serviceName,
            string include = null)
        {
            var req = PrepareRequest($"orders/{orderId}/external-services/{serviceName}");

            if (!string.IsNullOrEmpty(include)) req.QueryParams.Add("include", include);

            return await ExecuteRequestAsync<OrderExternalServicesModelItem>(req, HttpMethod.Get, rootElement: "");
        }


        /// <summary>
        ///     Deletes an external service of an order
        /// </summary>
        /// <param name="orderId">The order object's Id.</param>
        /// <param name="serviceName">The service name.</param>
        public virtual async Task DeleteAsync(int orderId, string serviceName)
        {
            var req = PrepareRequest($"orders/{orderId}/external-services/{serviceName}");

            await ExecuteRequestAsync(req, HttpMethod.Delete);
        }


        /// <summary>
        ///     Updates the given <see cref="OrderModel" />.
        /// </summary>
        /// <param name="orderId">Id of the object being updated.</param>
        /// <param name="externalServiceModel">The <see cref="OrderExternalServiceModel" /> to update.</param>
        /// <returns>The updated <see cref="OrderModel" />.</returns>
        public virtual async Task<OrderExternalServiceModel> UpdateAsync(int orderId,
            OrderExternalServiceModel externalServiceModel)
        {
            var req = PrepareRequest($"orders/{orderId}/external-services/{externalServiceModel.ServiceName}");
            var body = externalServiceModel.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<OrderExternalServiceModel>(req, HttpMethod.Put, content, "data");
        }

#if NETCORE
        /// <summary>
        ///     Updates the given <see cref="OrderExternalServiceModel" />.
        /// </summary>
        /// <param name="orderId">Id of the object being updated.</param>
        /// <param name="externalServiceModel">The <see cref="OrderExternalServiceModel" /> to update.</param>
        /// <returns>The updated <see cref="OrderModel" />.</returns>
        public virtual async Task<OrderExternalServiceModel> PatchAsync(int orderId,
            OrderExternalServiceModel externalServiceModel)
        {
            var req = PrepareRequest($"orders/{orderId}/external-services/{externalServiceModel.ServiceName}");
            var body = externalServiceModel.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<OrderExternalServiceModel>(req, HttpMethod.Patch, content, "data");
        }
#endif
    }
}