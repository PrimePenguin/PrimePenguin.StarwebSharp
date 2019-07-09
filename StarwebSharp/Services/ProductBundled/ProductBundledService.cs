using System.Net.Http;
using System.Threading.Tasks;
using StarwebSharp.Entities;
using StarwebSharp.Extensions;
using StarwebSharp.Filters;
using StarwebSharp.Infrastructure;

namespace StarwebSharp.Services.ProductBundled
{
    public class ProductBundledService : StarwebService
    {
        /// <summary>
        ///     Creates a new instance of <see cref="ProductBundledService" />.
        /// </summary>
        /// <param name="myStarwebUrl">The shop's *.mystrweb.se/api/vX URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ProductBundledService(string myStarwebUrl, string shopAccessToken) : base(myStarwebUrl, shopAccessToken)
        {
        }


        /// <summary>
        ///     Return a list of bundled products. Max 100 per call.
        /// </summary>
        /// <param name="productId">The product id of product.</param>
        /// <returns></returns>
        public virtual async Task<BundledProductsModelCollection> ListAsync(int productId, BundledProductFilter filter = null)
        {
            var req = PrepareRequest($"products/{productId}/bundled-products");

            if (filter != null) req.QueryParams.AddRange(filter.ToParameters());

            return await ExecuteRequestAsync<BundledProductsModelCollection>(req, HttpMethod.Get, rootElement: "");
        }

        /// <summary>
        ///     Retrieves the <see cref="BundledProductsModel" /> with the given bundled id.
        /// </summary>
        /// <param name="productId">The product id of product.</param>
        /// <param name="bundledProductId">bundled product id of product.</param>
        /// <param name="include">
        ///     If you want to include child data in the result. Example: ? include=languages (to include
        ///     language based data such as category names, description, etc). Available includes: languages
        /// </param>
        /// <returns>The <see cref="BundledProductsModel" />.</returns>
        public virtual async Task<BundledProductsModel> GetAsync(int productId, int bundledProductId,
            string include = null)
        {
            var req = PrepareRequest($"products/{productId}/bundled-products/{bundledProductId}");

            if (!string.IsNullOrEmpty(include)) req.QueryParams.Add("include", include);

            return await ExecuteRequestAsync<BundledProductsModel>(req, HttpMethod.Get, rootElement: "data");
        }


        /// <summary>
        ///     Creates a new <see cref="BundledProductsModel" /> on the store.
        /// </summary>
        /// <param name="productId">The product id of product.</param>
        /// <param name="bundledProductModel">A new <see cref="BundledProductsModel" />. Id should be set to null.</param>
        /// <returns>The new <see cref="BundledProductsModel" />.</returns>
        public virtual async Task<BundledProductsModel> CreateAsync(int productId,
            BundledProductsModel bundledProductModel)
        {
            var req = PrepareRequest($"products/{productId}/bundled-products");
            var body = bundledProductModel.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<BundledProductsModel>(req, HttpMethod.Post, content, "data");
        }

        /// <summary>
        ///     Deletes a product bundled product
        /// </summary>
        /// <param name="productId">The product id of product.</param>
        /// <param name="bundledProductId">bundled product id of product.</param>
        public virtual async Task DeleteAsync(int productId, int bundledProductId)
        {
            var req = PrepareRequest($"products/{productId}/bundled-products/{bundledProductId}");

            await ExecuteRequestAsync(req, HttpMethod.Delete);
        }

        /// <summary>
        ///     Updates the given <see cref="BundledProductsModel" />.
        /// </summary>
        /// <param name="productId">The product id of product.</param>
        /// <param name="bundledProductId">bundled product id of product.</param>
        /// <param name="bundleProductModel">The <see cref="BundledProductsModel" /> to update.</param>
        /// <returns>The updated <see cref="BundledProductsModel" />.</returns>
        public virtual async Task<BundledProductsModel> UpdateAsync(int productId, int bundledProductId,
            BundledProductsModel bundleProductModel)
        {
            var req = PrepareRequest($"products/{productId}/bundled-products/{bundledProductId}");
            var body = bundleProductModel.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<BundledProductsModel>(req, HttpMethod.Put, content, "data");
        }
    }
}