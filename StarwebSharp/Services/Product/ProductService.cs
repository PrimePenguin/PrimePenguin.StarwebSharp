using System.Net.Http;
using System.Threading.Tasks;
using StarwebSharp.Entities;
using StarwebSharp.Extensions;
using StarwebSharp.Filters;
using StarwebSharp.Infrastructure;

namespace StarwebSharp.Services.Product
{
    /// <summary>
    /// A service for manipulating Starweb products.
    /// </summary>
    public class ProductService : StarwebService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ProductService" />.
        /// </summary>
        /// <param name="myStarwebUrl">The shop's *.mystrweb.se/api/vX URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ProductService(string myStarwebUrl, string shopAccessToken) : base(myStarwebUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a list of products. Max 100 per call.
        /// </summary>
        /// <returns></returns>
        public virtual async Task<ProductModelCollection> ListAsync(ProductFilter filter = null)
        {
            var req = PrepareRequest("products");

            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToParameters());
            }

            return await ExecuteRequestAsync<ProductModelCollection>(req, HttpMethod.Get, rootElement: "");
        }

        /// <summary>
        /// Count products.
        /// </summary>
        /// <returns></returns>
        public virtual async Task<int> CountAsync()
        {
            var req = PrepareRequest("products");
            var filter = new ProductFilter { Page = 1000 };
            req.QueryParams.AddRange(filter.ToParameters());
            var productMeta = await ExecuteRequestAsync<ProductModelCollection>(req, HttpMethod.Get, rootElement: "");
            return productMeta.Meta.Pagination.Total.GetValueOrDefault(0);
        }

        /// <summary>
        /// Retrieves the <see cref="ProductModel"/> with the given id.
        /// </summary>
        /// <param name="productId">The id of the product to retrieve.</param>
        /// <param name="include">If you want to include child data in the result. Example: ?include=variants (to include product variants); ?include=variants,languages (to include both product variants and languages). Available includes: primaryVariant, primaryVariant.prices, mediaFiles, languages, vatRates, categories, unit, metaData. NOTE! Only one variant is included in result for performance reason. To fetch all variants, instead use /products/x/variants (unnecessary if hasSeveralVariants is false)</param>
        /// <returns>The <see cref="ProductModel"/>.</returns>
        public virtual async Task<ProductModel> GetAsync(int productId, string include = null)
        {
            var req = PrepareRequest($"products/{productId}");

            if (!string.IsNullOrEmpty(include))
            {
                req.QueryParams.Add("include", include);
            }

            return await ExecuteRequestAsync<ProductModel>(req, HttpMethod.Get, rootElement: "data");
        }

        /// <summary>
        /// Creates a new <see cref="ProductModel"/> on the store.
        /// </summary>
        /// <param name="product">A new <see cref="ProductCreateUpdateModel"/>. Id should be set to null.</param>
        /// <returns>The new <see cref="ProductModel"/>.</returns>
        public virtual async Task<ProductModel> CreateAsync(ProductCreateUpdateModel product)
        {
            var req = PrepareRequest("products");
            var body = product.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<ProductModel>(req, HttpMethod.Post, content, "data");
        }

        /// <summary>
        /// Updates the given <see cref="ProductModel"/>.
        /// </summary>
        /// <param name="productId">Id of the object being updated.</param>
        /// <param name="product">The <see cref="ProductCreateUpdateModel"/> to update.</param>
        /// <returns>The updated <see cref="ProductModel"/>.</returns>
        public virtual async Task<ProductModel> UpdateAsync(int productId, ProductCreateUpdateModel product)
        {
            var req = PrepareRequest($"products/{productId}");
            var body = product.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<ProductModel>(req, HttpMethod.Put, content, "data");
        }

#if NETCORE
        /// <summary>
        /// Updates the given <see cref="ProductModel"/>.
        /// </summary>
        /// <param name="productId">Id of the object being updated.</param>
        /// <param name="product">The <see cref="ProductCreateUpdateModel"/> to update.</param>
        /// <returns>The updated <see cref="ProductModel"/>.</returns>
        public virtual async Task<ProductModel> PatchAsync(int productId, ProductCreateUpdateModel product)
        {
            var req = PrepareRequest($"products/{productId}");
            var body = product.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<ProductModel>(req, HttpMethod.Patch, content, "data");
        }
#endif

        /// <summary>
        /// Deletes a product with the given Id.
        /// </summary>
        /// <param name="productId">The product object's Id.</param>
        public virtual async Task DeleteAsync(int productId)
        {
            var req = PrepareRequest($"products/{productId}");

            await ExecuteRequestAsync(req, HttpMethod.Delete);
        }
    }
}
