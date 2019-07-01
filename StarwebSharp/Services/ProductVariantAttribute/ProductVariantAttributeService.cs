using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using StarwebSharp.Entities;
using StarwebSharp.Extensions;
using StarwebSharp.Filters;
using StarwebSharp.Infrastructure;

namespace StarwebSharp.Services.ProductVariantAttribute
{
    public class ProductVariantAttributeService : StarwebService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ProductVariantAttributeService" />.
        /// </summary>
        /// <param name="myStarwebUrl">The shop's *.mystrweb.se/api/vX URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ProductVariantAttributeService(string myStarwebUrl, string shopAccessToken) : base(myStarwebUrl, shopAccessToken) { }


        /// <summary>
        /// Gets a list of product variants attributes. Max 100 per call.
        /// </summary>
        /// <returns></returns>
        public virtual async Task<IEnumerable<ProductVariantAttributeModel>> ListAsync(int productId, ProductVariantAttributeFilter filter = null)
        {
            var req = PrepareRequest($"product-attributes");

            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToParameters());
            }

            return await ExecuteRequestAsync<List<ProductVariantAttributeModel>>(req, HttpMethod.Get, rootElement: "data");
        }



        /// <summary>
        /// Retrieves the <see cref="ProductVariantAttributeModel"/> with the given id.
        /// </summary>
        /// <param name="attributeId">The attribute id of the product variant.</param>
        /// <param name="include">If you want to include child data in the result. Example: ?include=prices (to include variants prices). Available includes: prices, attributes, attributes.attribute</param>
        /// <returns>The <see cref="ProductVariantModel"/>.</returns>
        public virtual async Task<ProductVariantAttributeModel> GetAsync(int attributeId, string include = null)
        {
            var req = PrepareRequest($"products-attributes/{attributeId}");
            ;
            if (!string.IsNullOrEmpty(include))
            {
                req.QueryParams.Add("include", include);
            }

            return await ExecuteRequestAsync<ProductVariantAttributeModel>(req, HttpMethod.Get, rootElement: "data");
        }


        /// <summary>
        /// Creates a new <see cref="ProductVariantAttributeModel"/> on the store.
        /// </summary>
        /// <param name="model">A new <see cref="ProductVariantAttributeModel"/>. Id should be set to null.</param>
        /// <returns>The new <see cref="ProductVariantModel"/>.</returns>
        public virtual async Task<ProductVariantAttributeModel> CreateAsync(ProductVariantAttributeModel model)
        {
            var req = PrepareRequest($"product-attributes");
            var body = model.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<ProductVariantAttributeModel>(req, HttpMethod.Post, content, "data");
        }

        /// <summary>
        /// Updates the given <see cref="ProductVariantAttributeModel"/>.
        /// </summary>
        /// <param name="attributeId">The  attribute id of the product variant.</param>
        /// <param name="model">The <see cref="ProductVariantAttributeModel"/> to update.</param>
        /// <returns>The updated <see cref="ProductVariantAttributeModel"/>.</returns>
        public virtual async Task<ProductVariantAttributeModel> UpdateAsync(int attributeId, ProductVariantAttributeModel model)
        {
            var req = PrepareRequest($"product-attributes/{attributeId}");
            var body = model.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<ProductVariantAttributeModel>(req, HttpMethod.Put, content, "data");
        }
        
        /// <summary>
        /// Deletes a product attribute variant with the given Id.
        /// </summary>
        /// <param name="attributeId">The attribute id of product variant</param>
        public virtual async Task DeleteAsync(int attributeId)
        {
            var req = PrepareRequest($"product-attributes/{attributeId}");

            await ExecuteRequestAsync(req, HttpMethod.Delete);
        }


    }
}
