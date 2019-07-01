using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using StarwebSharp.Entities;
using StarwebSharp.Extensions;
using StarwebSharp.Infrastructure;

namespace StarwebSharp.Services.ProductManufacturer
{
    /// <summary>
    ///     A service for manipulating Starweb product manufacturers.
    /// </summary>
    public class ProductManufacturerService : StarwebService
    {
        /// <summary>
        ///     Creates a new instance of <see cref="ProductManufacturerService" />.
        /// </summary>
        /// <param name="myStarwebUrl">The shop's *.mystrweb.se/api/vX URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ProductManufacturerService(string myStarwebUrl, string shopAccessToken) : base(myStarwebUrl,
            shopAccessToken)
        {
        }

        /// <summary>
        ///     Gets a list of product manufacturers.
        /// </summary>
        /// <returns></returns>
        public virtual async Task<IEnumerable<ProductManufacturerModel>> ListAsync()
        {
            var req = PrepareRequest("product-manufacturers");
            return await ExecuteRequestAsync<List<ProductManufacturerModel>>(req, HttpMethod.Get, rootElement: "data");
        }

        /// <summary>
        ///     Retrieves the <see cref="ProductManufacturerModel" /> with the given id.
        /// </summary>
        /// <param name="manufacturerId">The id of the product manufacturer to retrieve.</param>
        /// <returns>The <see cref="ProductManufacturerModel" />.</returns>
        public virtual async Task<ProductManufacturerModel> GetAsync(int manufacturerId)
        {
            var req = PrepareRequest($"product-manufacturers/{manufacturerId}");
            return await ExecuteRequestAsync<ProductManufacturerModel>(req, HttpMethod.Get, rootElement: "data");
        }

        /// <summary>
        ///     Creates a new <see cref="ProductManufacturerModel" /> on the store.
        /// </summary>
        /// <param name="product">A new <see cref="ProductManufacturerModel" />. Id should be set to null.</param>
        /// <returns>The new <see cref="ProductManufacturerModel" />.</returns>
        public virtual async Task<ProductManufacturerModel> CreateAsync(ProductManufacturerModel product)
        {
            var req = PrepareRequest("product-manufacturers");
            var body = product.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<ProductManufacturerModel>(req, HttpMethod.Post, content, "data");
        }

        /// <summary>
        ///     Updates the given <see cref="ProductManufacturerModel" />.
        /// </summary>
        /// <param name="manufacturerId">Id of the object being updated.</param>
        /// <param name="product">The <see cref="ProductManufacturerModel" /> to update.</param>
        /// <returns>The updated <see cref="ProductManufacturerModel" />.</returns>
        public virtual async Task<ProductManufacturerModel> UpdateAsync(int manufacturerId,
            ProductManufacturerModel product)
        {
            var req = PrepareRequest($"product-manufacturers/{manufacturerId}");
            var body = product.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<ProductManufacturerModel>(req, HttpMethod.Put, content, "data");
        }

#if NETCORE
        // <summary>
        /// Updates the given
        /// <see cref="ProductManufacturerModel" />
        /// .
        /// </summary>
        /// <param name="manufacturerId">Id of the object being updated.</param>
        /// <param name="product">The <see cref="ProductManufacturerModel" /> to update.</param>
        /// <returns>The updated <see cref="ProductManufacturerModel" />.</returns>
        public virtual async Task<ProductManufacturerModel> PatchAsync(int manufacturerId,
            ProductManufacturerModel product)
        {
            var req = PrepareRequest($"product-manufacturers/{manufacturerId}");
            var body = product.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<ProductManufacturerModel>(req, HttpMethod.Patch, content, "data");
        }
#endif

        /// <summary>
        ///     Deletes a product manufacturer with the given Id.
        /// </summary>
        /// <param name="manufacturerId">The product manufacturer object's Id.</param>
        public virtual async Task DeleteAsync(int manufacturerId)
        {
            var req = PrepareRequest($"product-manufacturers/{manufacturerId}");
            await ExecuteRequestAsync(req, HttpMethod.Delete);
        }
    }
}