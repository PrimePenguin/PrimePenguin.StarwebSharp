using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using StarwebSharp.Entities;
using StarwebSharp.Extensions;
using StarwebSharp.Filters;
using StarwebSharp.Infrastructure;

namespace StarwebSharp.Services.ProductCategoryLinks
{
    public class ProductCategoryLinksService : StarwebService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ProductCategoryLinksService" />.
        /// </summary>
        /// <param name="myStarwebUrl">The shop's *.mystrweb.se/api/vX URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ProductCategoryLinksService(string myStarwebUrl, string shopAccessToken) : base(myStarwebUrl, shopAccessToken) { }



        /// <summary>
        ///  Returns a list of product category links . Max 100 per call. 
        /// </summary>
        /// <param name="productId">The Id of product.</param>
        /// <returns></returns>
        public virtual async Task<ProductCategoryLinkModel> ListAsync(int productId, ProductCategoryFilter filter = null)
        {
            var req = PrepareRequest($"product/{productId}/categories");

            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToParameters());
            }

            return await ExecuteRequestAsync<ProductCategoryLinkModel>(req, HttpMethod.Get, rootElement: "");
        }

        /// <summary>
        /// Retrieves the <see cref="ProductCategoryLinkModel"/> with the given id.
        /// </summary>
        ///  <param name="productId">The id of the product.</param>
        /// <param name="categoryId">The id of category .</param>
        /// <param name="include">If you want to include child data in the result. Example: ?include=languages (to include language based data such as category names, description, etc). Available includes: languages</param>
        /// <returns>The <see cref="ProductCategoryLinkModel"/>.</returns>
        public virtual async Task<ProductCategoryLinkModel> GetAsync(int productId, int categoryId,
            string include = null)
        {
            var req = PrepareRequest($"products/{productId}/categories/{categoryId}");

            if (!string.IsNullOrEmpty(include))
            {
                req.QueryParams.Add("include", include);
            }

            return await ExecuteRequestAsync<ProductCategoryLinkModel>(req, HttpMethod.Get, rootElement: "data");
        }

        /// <summary>
        /// Creates a new <see cref="ProductCategoryLinkModel"/> on the store.
        /// </summary>
        /// <param name="productId">The id of the product.</param>
        /// <param name="model">A new <see cref="ProductCategoryLinkModel"/>. Id should be set to null.</param>
        /// <returns>The new <see cref="ProductCategoryLinkModel"/>.</returns>
        public virtual async Task<ProductCategoryLinkModel> CreateAsync(int productId,  ProductCategoryLinkModel model)
        {
            var req = PrepareRequest($"product/{productId}/categories");
            var body = model.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<ProductCategoryLinkModel>(req, HttpMethod.Post, content, "data");
        }

        /// <summary>
        /// Deletes a product category link category Id.
        /// </summary>
        /// <param name="productId">The id of the product.</param>
        /// <param name="categoryId">The product object's Id.</param>
        public virtual async Task DeleteAsync(int productId, int categoryId)
        {
            var req = PrepareRequest($"products/{productId}/categories/{categoryId}");

            await ExecuteRequestAsync(req, HttpMethod.Delete);
        }

        /// <summary>
        /// Updates the given <see cref="ProductCategoryLinkModel"/>.
        /// </summary>
        /// <param name="productId">The id of the product.</param>
        /// <param name="categoryId">The product object's Id.</param>
        /// <param name="productCategoryLinkModel">The <see cref="ProductCategoryLinkModel"/> to update.</param>
        /// <returns>The updated <see cref="ProductCategoryLinkModel"/>.</returns>
        public virtual async Task<ProductCategoryLinkModel> UpdateAsync(int productId, int categoryId, 
            ProductCategoryLinkModel productCategoryLinkModel)
        {
            var req = PrepareRequest($"products/{productId}/categories/{categoryId}");
            var body = productCategoryLinkModel.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<ProductCategoryLinkModel>(req, HttpMethod.Put, content, "data");
        }

    }
}
