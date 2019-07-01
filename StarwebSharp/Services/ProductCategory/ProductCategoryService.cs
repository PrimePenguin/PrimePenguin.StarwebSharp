using System.Net.Http;
using System.Threading.Tasks;
using StarwebSharp.Entities;
using StarwebSharp.Extensions;
using StarwebSharp.Filters;
using StarwebSharp.Infrastructure;

namespace StarwebSharp.Services.ProductCategory
{
    /// <summary>
    ///     A service for manipulating Starweb product categories.
    /// </summary>
    public class ProductCategoryService : StarwebService
    {
        /// <summary>
        ///     Creates a new instance of <see cref="ProductCategoryService" />.
        /// </summary>
        /// <param name="myStarwebUrl">The shop's *.mystrweb.se/api/vX URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ProductCategoryService(string myStarwebUrl, string shopAccessToken) : base(myStarwebUrl, shopAccessToken)
        {
        }

        /// <summary>
        ///     Gets a list of product categories. Max 100 per call.
        /// </summary>
        /// <returns></returns>
        public virtual async Task<ProductCategoryModelCollection> ListAsync(ProductCategoryFilter filter = null)
        {
            var req = PrepareRequest("product-categories");

            if (filter != null) req.QueryParams.AddRange(filter.ToParameters());

            return await ExecuteRequestAsync<ProductCategoryModelCollection>(req, HttpMethod.Get, rootElement: "");
        }

        /// <summary>
        ///     Retrieves the <see cref="ProductCategoryModel" /> with the given id.
        /// </summary>
        /// <param name="categoryId">The id of the product category to retrieve.</param>
        /// <param name="include">
        ///     If you want to include child data in the result. Example: ?include=languages (to include language
        ///     based data such as category names, description, etc). Available includes: languages
        /// </param>
        /// <returns>The <see cref="ProductCategoryModel" />.</returns>
        public virtual async Task<ProductCategoryModel> GetAsync(int categoryId, string include = null)
        {
            var req = PrepareRequest($"product-categories/{categoryId}");

            if (!string.IsNullOrEmpty(include)) req.QueryParams.Add("include", include);

            return await ExecuteRequestAsync<ProductCategoryModel>(req, HttpMethod.Get, rootElement: "data");
        }

        /// <summary>
        ///     Creates a new <see cref="ProductCategoryModel" /> on the store.
        /// </summary>
        /// <param name="product">A new <see cref="ProductCategoryCreateUpdateModel" />. Id should be set to null.</param>
        /// <returns>The new <see cref="ProductCategoryModel" />.</returns>
        public virtual async Task<ProductCategoryModel> CreateAsync(ProductCategoryCreateUpdateModel product)
        {
            var req = PrepareRequest("product-categories");
            var body = product.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<ProductCategoryModel>(req, HttpMethod.Post, content, "data");
        }

        /// <summary>
        ///     Updates the given <see cref="ProductCategoryModel" />.
        /// </summary>
        /// <param name="categoryId">Id of the object being updated.</param>
        /// <param name="product">The <see cref="ProductCategoryCreateUpdateModel" /> to update.</param>
        /// <returns>The updated <see cref="ProductCategoryModel" />.</returns>
        public virtual async Task<ProductCategoryModel> UpdateAsync(int categoryId,
            ProductCategoryCreateUpdateModel product)
        {
            var req = PrepareRequest($"product-categories/{categoryId}");
            var body = product.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<ProductCategoryModel>(req, HttpMethod.Put, content, "data");
        }

#if NETCORE
        /// <summary>
        ///     Updates the given <see cref="ProductCategoryModel" />.
        /// </summary>
        /// <param name="categoryId">Id of the object being updated.</param>
        /// <param name="product">The <see cref="ProductCategoryCreateUpdateModel" /> to update.</param>
        /// <returns>The updated <see cref="ProductCategoryModel" />.</returns>
        public virtual async Task<ProductCategoryModel> PatchAsync(int categoryId,
            ProductCategoryCreateUpdateModel product)
        {
            var req = PrepareRequest($"product-categories/{categoryId}");
            var body = product.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<ProductCategoryModel>(req, HttpMethod.Patch, content, "data");
        }
#endif

        /// <summary>
        ///     Deletes a product category with the given Id.
        /// </summary>
        /// <param name="categoryId">The product object's Id.</param>
        public virtual async Task DeleteAsync(int categoryId)
        {
            var req = PrepareRequest($"product-categories/{categoryId}");

            await ExecuteRequestAsync(req, HttpMethod.Delete);
        }
    }
}