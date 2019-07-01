using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using StarwebSharp.Entities;
using StarwebSharp.Extensions;
using StarwebSharp.Infrastructure;

namespace StarwebSharp.Services.OrderStatus
{
    /// <summary>
    /// A service for manipulating Starweb order statuses.
    /// </summary>
    public class OrderStatusService : StarwebService
    {
        /// <summary>
        /// Creates a new instance of <see cref="OrderStatusService" />.
        /// </summary>
        /// <param name="myStarwebUrl">The shop's *.mystrweb.se/api/vX URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public OrderStatusService(string myStarwebUrl, string shopAccessToken) : base(myStarwebUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a list of order statuses.
        /// </summary>
        /// <returns></returns>
        public virtual async Task<IEnumerable<OrderStatusModel>> ListAsync()
        {
            var req = PrepareRequest("order-statuses");
            return await ExecuteRequestAsync<List<OrderStatusModel>>(req, HttpMethod.Get, rootElement: "data");
        }

        /// <summary>
        /// Retrieves the <see cref="OrderStatusModel"/> with the given id.
        /// </summary>
        /// <param name="orderStatusId">The id of the order status to retrieve.</param>
        /// <returns>The <see cref="OrderStatusModel"/>.</returns>
        public virtual async Task<OrderStatusModel> GetAsync(int orderStatusId)
        {
            var req = PrepareRequest($"order-statuses/{orderStatusId}");
            return await ExecuteRequestAsync<OrderStatusModel>(req, HttpMethod.Get, rootElement: "data");
        }


        /// <summary>
        /// Creates a new <see cref="OrderStatusModel"/> on the store.
        /// </summary>
        /// <param name="order">A new <see cref="OrderModel"/>. Id should be set to null.</param>
        /// <returns>The new <see cref="OrderStatusModel"/>.</returns>
        public virtual async Task<OrderStatusModel> CreateAsync(OrderStatusCreateUpdateModel order)
        {
            var req = PrepareRequest("order-statuses");
            var body = order.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<OrderStatusModel>(req, HttpMethod.Post, content, "");
        }

        /// <summary>
        /// Updates the given <see cref="OrderStatusModel"/>.
        /// </summary>
        /// <param name="orderStatusId">Id of the object being updated.</param>
        /// <param name="order">The <see cref="OrderStatusCreateUpdateModel"/> to update.</param>
        /// <returns>The updated <see cref="OrderStatusModel"/>.</returns>
        public virtual async Task<OrderStatusModel> UpdateAsync(int orderStatusId, OrderStatusCreateUpdateModel order)
        {
            var req = PrepareRequest($"order-statuses/{orderStatusId}");
            var body = order.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<OrderStatusModel>(req, HttpMethod.Put, content, "data");
        }

#if NETCORE
        /// <summary>
        /// Updates the given <see cref="OrderStatusModel"/>.
        /// </summary>
        /// <param name="orderStatusId">Id of the object being updated.</param>
        /// <param name="order">The <see cref="OrderStatusCreateUpdateModel"/> to update.</param>
        /// <returns>The updated <see cref="OrderStatusModel"/>.</returns>
        public virtual async Task<OrderStatusModel> PatchAsync(int orderStatusId, OrderStatusCreateUpdateModel order)
        {
            var req = PrepareRequest($"order-statuses/{orderStatusId}");
            var body = order.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<OrderStatusModel>(req, HttpMethod.Patch, content, "data");
        }
#endif

        /// <summary>
        /// Deletes a order status with the given Id.
        /// </summary>
        /// <param name="orderStatusId">The order object's Id.</param>
        public virtual async Task DeleteAsync(int orderStatusId)
        {
            var req = PrepareRequest($"order-statuses/{orderStatusId}");

            await ExecuteRequestAsync(req, HttpMethod.Delete);
        }
    }
}
