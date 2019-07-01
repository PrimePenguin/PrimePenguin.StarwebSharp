using System.Net.Http;
using System.Threading.Tasks;
using StarwebSharp.Entities;
using StarwebSharp.Extensions;
using StarwebSharp.Infrastructure;

namespace StarwebSharp.Services.OrderComments
{
    /// <summary>
    ///     A service for manipulating Comments of order.
    /// </summary>
    public class OrderCommentsService : StarwebService
    {
        /// <summary>
        ///     Creates a new instance of <see cref="OrderCommentsService" />.
        /// </summary>
        /// <param name="myStarwebUrl">The shop's *.mystrweb.se/api/vX URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public OrderCommentsService(string myStarwebUrl, string shopAccessToken) : base(myStarwebUrl, shopAccessToken)
        {
        }

        /// <summary>
        ///     Gets a list of orders with given order id . Max 100 per call.
        /// </summary>
        /// <param name="orderId">The id of the order to retrieve.</param>
        /// <param name="include">
        ///     If you want to include child data in the result. Example: ?include=items (to include order items)
        ///     or ?include=items,externalServices (to include order items as well as external ids). Available includes: items,
        ///     externalServices, status, order, addresses
        /// </param>
        /// <returns>The <see cref="OrderCommentModelCollection" />.</returns>
        public virtual async Task<OrderCommentModelCollection> ListAsync(int orderId, string include = null)
        {
            var req = PrepareRequest($"orders/{orderId}/comments");

            if (!string.IsNullOrEmpty(include)) req.QueryParams.Add("include", include);

            return await ExecuteRequestAsync<OrderCommentModelCollection>(req, HttpMethod.Get, rootElement: "");
        }


        /// <summary>
        ///     Creates a new comment <see cref="OrderCommentModelItem" /> of order
        /// </summary>
        public virtual async Task<OrderCommentModelItem> CreateAsync(int orderId, OrderCommentModel orderComment)
        {
            var req = PrepareRequest($"orders/{orderId}/comments");
            var body = orderComment.ToDictionary();
            var content = new JsonContent(body);
            return await ExecuteRequestAsync<OrderCommentModelItem>(req, HttpMethod.Post, content, "data");
        }


        /// <summary>
        ///     Retrieves the <see cref="OrderCommentModel" /> with the order and comment id
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="commentId"></param>
        /// <param name="include"></param>
        /// <returns></returns>
        public virtual async Task<OrderCommentModel> GetAsync(int orderId, int commentId, string include = null)
        {
            var req = PrepareRequest($"orders/{orderId}/comments/{commentId}");

            if (!string.IsNullOrEmpty(include)) req.QueryParams.Add("include", include);

            return await ExecuteRequestAsync<OrderCommentModel>(req, HttpMethod.Get, rootElement: "data");
        }

        /// <summary>
        ///     Deletes a comment with the given comment Id.
        /// </summary>
        public virtual async Task DeleteAsync(int orderId, int commentId)
        {
            var req = PrepareRequest($"orders/{orderId}/comments/{commentId}");

            await ExecuteRequestAsync(req, HttpMethod.Delete);
        }


        /// <summary>
        ///     Updates the given <see cref="OrderCommentModel" />.
        /// </summary>
        /// <param name="orderId">Id of the object being updated.</param>
        /// <param name="commentId">commentId of the order</param>
        /// <param name="orderCommentModel">The <see cref="OrderCommentModel" /> to update.</param>
        /// <returns>The updated <see cref="OrderCommentModel" />.</returns>
        public virtual async Task<OrderCommentModel> UpdateAsync(int orderId, int commentId,
            OrderCommentModel orderCommentModel)
        {
            var req = PrepareRequest($"orders/{orderId}/comments/{commentId}");
            var body = orderCommentModel.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<OrderCommentModel>(req, HttpMethod.Put, content, "data");
        }

#if NETCORE
        /// <summary>
        ///     Updates the given <see cref="OrderCommentModel" />.
        /// </summary>
        /// <param name="orderId">Id of the object being updated.</param>
        /// <param name="commentId">commentId of the order</param>
        /// <param name="orderCommentModel">The <see cref="OrderCommentModel" /> to update.</param>
        /// <returns>The updated <see cref="OrderCommentModel" />.</returns>
        public virtual async Task<OrderModel> PatchAsync(int orderId, int commentId,
            OrderCommentModel orderCommentModel)
        {
            var req = PrepareRequest($"orders/{orderId}/comments/{commentId}");
            var body = orderCommentModel.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<OrderModel>(req, HttpMethod.Patch, content, "data");
        }
#endif
    }
}