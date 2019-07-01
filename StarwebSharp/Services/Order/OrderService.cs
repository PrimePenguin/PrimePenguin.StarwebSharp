using System.Net.Http;
using System.Threading.Tasks;
using StarwebSharp.Entities;
using StarwebSharp.Extensions;
using StarwebSharp.Filters;
using StarwebSharp.Infrastructure;

namespace StarwebSharp.Services.Order
{
    /// <summary>
    /// A service for manipulating Starweb orders.
    /// </summary>
    public class OrderService : StarwebService
    {
        /// <summary>
        /// Creates a new instance of <see cref="OrderService" />.
        /// </summary>
        /// <param name="myStarwebUrl">The shop's *.mystrweb.se/api/vX URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public OrderService(string myStarwebUrl, string shopAccessToken) : base(myStarwebUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a list of orders. Max 100 per call.
        /// </summary>
        /// <returns></returns>
        public virtual async Task<OrderModelCollection> ListAsync(OrderFilter filter = null)
        {
            var req = PrepareRequest("orders");

            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToParameters());
            }

            return await ExecuteRequestAsync<OrderModelCollection>(req, HttpMethod.Get, rootElement: "");
        }


        /// <summary>
        /// Count orders
        /// </summary>
        /// <returns></returns>
        public virtual async Task<int> CountAsync()
        {
            var req = PrepareRequest("orders");
            var filter = new OrderFilter() { Page = 1000 };
            req.QueryParams.AddRange(filter.ToParameters());
            var orderMeta = await ExecuteRequestAsync<OrderModelCollection>(req, HttpMethod.Get, rootElement: "");
            return orderMeta.Meta.Pagination.Total.GetValueOrDefault(0);
        }


        /// <summary>
        /// Retrieves the <see cref="OrderModel"/> with the given id.
        /// </summary>
        /// <param name="orderId">The id of the order to retrieve.</param>
        /// <param name="include">If you want to include child data in the result. Example: ?include=items (to include order items) or ?include=items,externalServices (to include order items as well as external ids). Available includes: items, externalServices, status, order, addresses</param>
        /// <returns>The <see cref="OrderModel"/>.</returns>
        public virtual async Task<OrderModel> GetAsync(int orderId, string include = null)
        {
            var req = PrepareRequest($"orders/{orderId}");

            if (!string.IsNullOrEmpty(include))
            {
                req.QueryParams.Add("include", include);
            }

            return await ExecuteRequestAsync<OrderModel>(req, HttpMethod.Get, rootElement: "data");
        }


        /// <summary>
        /// Creates a new <see cref="OrderModel"/> on the store.
        /// </summary>
        /// <param name="order">A new <see cref="OrderCreateUpdateModel"/>. Id should be set to null.</param>
        /// <returns>The new <see cref="OrderModel"/>.</returns>
        public virtual async Task<OrderModel> CreateAsync(OrderCreateUpdateModel order)
        {
            var req = PrepareRequest("orders");
            var body = order.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<OrderModel>(req, HttpMethod.Post, content, "data");
        }



        /// <summary>
        /// Updates the given <see cref="OrderModel"/>.
        /// </summary>
        /// <param name="orderId">Id of the object being updated.</param>
        /// <param name="order">The <see cref="OrderCreateUpdateModel"/> to update.</param>
        /// <returns>The updated <see cref="OrderModel"/>.</returns>
        public virtual async Task<OrderModel> UpdateAsync(int orderId, OrderCreateUpdateModel order)
        {
            var req = PrepareRequest($"orders/{orderId}");
            var body = order.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<OrderModel>(req, HttpMethod.Put, content, "data");
        }

#if NETCORE
        /// <summary>
        /// Updates the given <see cref="OrderModel"/>.
        /// </summary>
        /// <param name="orderId">Id of the object being updated.</param>
        /// <param name="order">The <see cref="OrderCreateUpdateModel"/> to update.</param>
        /// <returns>The updated <see cref="OrderModel"/>.</returns>
        public virtual async Task<OrderModel> PatchAsync(int orderId, OrderCreateUpdateModel order)
        {
            var req = PrepareRequest($"orders/{orderId}");
            var body = order.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<OrderModel>(req, HttpMethod.Patch, content, "data");
        }
#endif



        /// <summary>
        /// Deletes a order with the given Id.
        /// </summary>
        /// <param name="orderId">The order object's Id.</param>
        public virtual async Task DeleteAsync(int orderId)
        {
            var req = PrepareRequest($"orders/{orderId}");

            await ExecuteRequestAsync(req, HttpMethod.Delete);
        }
    }
}
