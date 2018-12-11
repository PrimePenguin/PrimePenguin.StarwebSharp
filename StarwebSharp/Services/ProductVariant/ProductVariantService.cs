using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using StarwebSharp.Entities;
using StarwebSharp.Extensions;
using StarwebSharp.Filters;
using StarwebSharp.Infrastructure;

namespace StarwebSharp.Services.ProductVariant
{
    /// <summary>
    /// A service for manipulating Starweb variant variants.
    /// </summary>
    public class ProductVariantService : StarwebService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ProductVariantService" />.
        /// </summary>
        /// <param name="myStarwebUrl">The shop's *.mystrweb.se/api/vX URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ProductVariantService(string myStarwebUrl, string shopAccessToken) : base(myStarwebUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a list of variant variants. Max 100 per call.
        /// </summary>
        /// <returns></returns>
        public virtual async Task<IEnumerable<ProductVariantModel>> ListAsync(int productId, ProductVariantFilter filter = null)
        {
            var req = PrepareRequest($"products/{productId}/variants");

            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToParameters());
            }

            return await ExecuteRequestAsync<List<ProductVariantModel>>(req, HttpMethod.Get, rootElement: "data");
        }

        /// <summary>
        /// Retrieves the <see cref="ProductVariantModel"/> with the given id.
        /// </summary>
        /// <param name="productId">The id of the product.</param>
        /// <param name="variantId">The id of the variant to retrieve.</param>
        /// <param name="include">If you want to include child data in the result. Example: ?include=prices (to include variants prices). Available includes: prices, attributes, attributes.attribute</param>
        /// <returns>The <see cref="ProductVariantModel"/>.</returns>
        public virtual async Task<ProductVariantModel> GetAsync(int productId, int variantId, string include = null)
        {
            var req = PrepareRequest($"products/{productId}/variants/{variantId}");

            if (!string.IsNullOrEmpty(include))
            {
                req.QueryParams.Add("include", include);
            }

            return await ExecuteRequestAsync<ProductVariantModel>(req, HttpMethod.Get, rootElement: "data");
        }

        /// <summary>
        /// Creates a new <see cref="ProductVariantModel"/> on the store.
        /// </summary>
        /// <param name="productId">The id of the product.</param>
        /// <param name="variant">A new <see cref="ProductVariantCreateUpdateModel"/>. Id should be set to null.</param>
        /// <returns>The new <see cref="ProductVariantModel"/>.</returns>
        public virtual async Task<ProductVariantModel> CreateAsync(int productId, ProductVariantCreateUpdateModel variant)
        {
            var req = PrepareRequest($"products/{productId}/variants");
            var body = variant.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<ProductVariantModel>(req, HttpMethod.Post, content, "data");
        }

        /// <summary>
        /// Updates the given <see cref="ProductVariantModel"/>.
        /// </summary>
        /// <param name="productId">The id of the product.</param>
        /// <param name="variantId">Id of the object being updated.</param>
        /// <param name="variant">The <see cref="ProductVariantCreateUpdateModel"/> to update.</param>
        /// <returns>The updated <see cref="ProductVariantModel"/>.</returns>
        public virtual async Task<ProductVariantModel> UpdateAsync(int productId, int variantId, ProductVariantCreateUpdateModel variant)
        {
            var req = PrepareRequest($"products/{productId}/variants/{variantId}");
            var body = variant.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<ProductVariantModel>(req, HttpMethod.Put, content, "data");
        }

#if NETCORE
        /// <summary>
        /// Updates the given <see cref="ProductVariantModel"/>.
        /// </summary>
        /// <param name="productId">The id of the product.</param>
        /// <param name="variantId">Id of the object being updated.</param>
        /// <param name="variant">The <see cref="ProductVariantCreateUpdateModel"/> to update.</param>
        /// <returns>The updated <see cref="ProductVariantModel"/>.</returns>
        public virtual async Task<ProductVariantModel> PatchAsync(int productId, int variantId, ProductVariantCreateUpdateModel variant)
        {
            var req = PrepareRequest($"products/{productId}/variants/{variantId}");
            var body = variant.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<ProductVariantModel>(req, HttpMethod.Patch, content, "data");
        }
#endif

        /// <summary>
        /// Deletes a variant with the given Id.
        /// </summary>
        /// <param name="productId">The variant object's Id.</param>
        /// <param name="variantId">The id of the variant to delete.</param>
        public virtual async Task DeleteAsync(int productId, int variantId)
        {
            var req = PrepareRequest($"products/{productId}/variants/{variantId}");

            await ExecuteRequestAsync(req, HttpMethod.Delete);
        }
    }
}
