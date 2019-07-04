using System.Net.Http;
using System.Threading.Tasks;
using StarwebSharp.Entities;
using StarwebSharp.Extensions;
using StarwebSharp.Filters;
using StarwebSharp.Infrastructure;

namespace StarwebSharp.Services.ProductBundledProductPrice
{
    public class ProductBundledProductPriceService : StarwebService
    {
        /// <summary>
        ///     Creates a new instance of <see cref="ProductBundledProductPriceService" />.
        /// </summary>
        /// <param name="myStarwebUrl">The shop's *.mystrweb.se/api/vX URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ProductBundledProductPriceService(string myStarwebUrl, string shopAccessToken) : base(myStarwebUrl,
            shopAccessToken)
        {
        }

        /// <summary>
        ///     Returns a list of product variant pricelist prices. Max 100 per call.
        /// </summary>
        /// <param name="productId">The product id of product.</param>
        /// <param name="bundledProductId">bundled product id of product.</param>
        /// <returns></returns>
        public virtual async Task<ProductBundleProductPriceModel> ListAsync(int productId, int bundledProductId,
            ProductBundledProductPriceFilter filter = null)
        {
            var req = PrepareRequest($"products/{productId}/bundled-products/{bundledProductId}/prices");

            if (filter != null) req.QueryParams.AddRange(filter.ToParameters());

            return await ExecuteRequestAsync<ProductBundleProductPriceModel>(req, HttpMethod.Get, rootElement: "");
        }


        /// <summary>
        ///     Retrieves the <see cref="ProductBundleProductPriceModel" /> with the given price id.
        /// </summary>
        /// <param name="productId">The product id of product.</param>
        /// <param name="bundledProductId">bundled product id of product.</param>
        /// <param name="pricelistId">price list id of  bundled product.</param>
        /// <param name="include">
        ///     If you want to include child data in the result. Example: ? include=languages (to include
        ///     language based data such as category names, description, etc). Available includes: languages
        /// </param>
        /// <returns>The <see cref="ProductCategoryModel" />.</returns>
        public virtual async Task<ProductBundleProductPriceModel> GetAsync(int productId, int bundledProductId,
            int pricelistId, string include = null)
        {
            var req = PrepareRequest($"products/{productId}/bundled-products/{bundledProductId}/prices/{pricelistId}");

            if (!string.IsNullOrEmpty(include)) req.QueryParams.Add("include", include);

            return await ExecuteRequestAsync<ProductBundleProductPriceModel>(req, HttpMethod.Get, rootElement: "data");
        }

        /// <summary>
        ///     Creates a new <see cref="ProductBundleProductPriceModel" /> on the store.
        /// </summary>
        /// <param name="productId">The product id of product.</param>
        /// <param name="bundledProductId">bundled product id of product.</param>
        /// <param name="bundledProductPriceModel">A new <see cref="ProductBundleProductPriceModel" />. Id should be set to null.</param>
        /// <returns>The new <see cref="ProductCategoryModel" />.</returns>
        public virtual async Task<ProductBundleProductPriceModel> CreateAsync(int productId, int bundledProductId,
            ProductBundleProductPriceModel bundledProductPriceModel)
        {
            var req = PrepareRequest($"products/{productId}/bundled-products/{bundledProductId}/prices");
            var body = bundledProductPriceModel.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<ProductBundleProductPriceModel>(req, HttpMethod.Post, content, "data");
        }

        /// <summary>
        ///     Deletes a product bundled price the  bundled price Id.
        /// </summary>
        /// <param name="productId">The product id of product.</param>
        /// <param name="bundledProductId">bundled product id of product.</param>
        /// <param name="pricelistId">The bundled price list id.</param>
        public virtual async Task DeleteAsync(int productId, int bundledProductId, int pricelistId)
        {
            var req = PrepareRequest($"products/{productId}/bundled-products/{bundledProductId}/prices/{pricelistId}");

            await ExecuteRequestAsync(req, HttpMethod.Delete);
        }

        /// <summary>
        ///     Updates the given <see cref="ProductBundleProductPriceModel" />.
        /// </summary>
        /// <param name="productId">The product id of product.</param>
        /// <param name="bundledProductId">bundled product id of product.</param>
        /// <param name="pricelistId">The bundled price list id.</param>
        /// <param name="product">The <see cref="ProductBundleProductPriceModel" /> to update.</param>
        /// <returns>The updated <see cref="ProductCategoryModel" />.</returns>
        public virtual async Task<ProductBundleProductPriceModel> UpdateAsync(int productId, int bundledProductId,
            int pricelistId,
            ProductBundleProductPriceModel bundleProductPriceModel)
        {
            var req = PrepareRequest($"products/{productId}/bundled-products/{bundledProductId}/prices/{pricelistId}");
            var body = bundleProductPriceModel.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<ProductBundleProductPriceModel>(req, HttpMethod.Put, content, "data");
        }
    }
}