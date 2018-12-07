using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using StarwebSharp.Entities;
using StarwebSharp.Extensions;
using StarwebSharp.Infrastructure;

namespace StarwebSharp.Services.ProductStockStatus
{
    /// <summary>
    /// A service for manipulating Starweb product stock statuses.
    /// </summary>
    public class ProductStockStatusService : StarwebService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ProductStockStatusService" />.
        /// </summary>
        /// <param name="myStarwebUrl">The shop's *.mystrweb.se/api/vX URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ProductStockStatusService(string myStarwebUrl, string shopAccessToken) : base(myStarwebUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a list of product stock statuses.
        /// </summary>
        /// <returns></returns>
        public virtual async Task<IEnumerable<ProductStockStatusModel>> ListAsync()
        {
            var req = PrepareRequest("product-stock-statuses");
            return await ExecuteRequestAsync<List<ProductStockStatusModel>>(req, HttpMethod.Get, rootElement: "data");
        }

        /// <summary>
        /// Retrieves the <see cref="ProductStockStatusModel"/> with the given id.
        /// </summary>
        /// <param name="orderStatusId">The id of the stock status to retrieve.</param>
        /// <returns>The <see cref="ProductStockStatusModel"/>.</returns>
        public virtual async Task<ProductStockStatusModel> GetAsync(int orderStatusId)
        {
            var req = PrepareRequest($"product-stock-statuses/{orderStatusId}");
            return await ExecuteRequestAsync<ProductStockStatusModel>(req, HttpMethod.Get, rootElement: "data");
        }

        /// <summary>
        /// Creates a new <see cref="ProductStockStatusModel"/> on the store.
        /// </summary>
        /// <param name="order">A new <see cref="ProductStockStatusCreateUpdateModel"/>. Id should be set to null.</param>
        /// <returns>The new <see cref="ProductStockStatusModel"/>.</returns>
        public virtual async Task<ProductStockStatusModel> CreateAsync(ProductStockStatusCreateUpdateModel order)
        {
            var req = PrepareRequest("product-stock-statuses");
            var body = order.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<ProductStockStatusModel>(req, HttpMethod.Post, content, "");
        }

        /// <summary>
        /// Updates the given <see cref="ProductStockStatusModel"/>.
        /// </summary>
        /// <param name="stockStatusId">Id of the object being updated.</param>
        /// <param name="order">The <see cref="ProductStockStatusCreateUpdateModel"/> to update.</param>
        /// <returns>The updated <see cref="ProductStockStatusModel"/>.</returns>
        public virtual async Task<ProductStockStatusModel> UpdateAsync(int stockStatusId, ProductStockStatusCreateUpdateModel order)
        {
            var req = PrepareRequest($"product-stock-statuses/{stockStatusId}");
            var body = order.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<ProductStockStatusModel>(req, HttpMethod.Put, content, "data");
        }

        /// <summary>
        /// Deletes a stock status with the given Id.
        /// </summary>
        /// <param name="stockStatusId">The product stock status object's Id.</param>
        public virtual async Task DeleteAsync(int stockStatusId)
        {
            var req = PrepareRequest($"product-stock-statuses/{stockStatusId}");

            await ExecuteRequestAsync(req, HttpMethod.Delete);
        }
    }
}
