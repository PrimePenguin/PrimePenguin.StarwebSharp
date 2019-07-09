using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using StarwebSharp.Entities;
using StarwebSharp.Extensions;
using StarwebSharp.Filters;
using StarwebSharp.Infrastructure;

namespace StarwebSharp.Services.ProductVariantAttributeValue
{
    public class ProductVariantAttributeValueService : StarwebService
    {
        /// <summary>
        ///     Creates a new instance of <see cref="ProductVariantAttributeValueService" />.
        /// </summary>
        /// <param name="myStarwebUrl">The shop's *.mystrweb.se/api/vX URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ProductVariantAttributeValueService(string myStarwebUrl, string shopAccessToken) : base(myStarwebUrl,
            shopAccessToken)
        {
        }


        /// <summary>
        ///     Gets a list of product variants attributes values. Max 100 per call.
        /// </summary>
        /// <returns></returns>
        public virtual async Task<IEnumerable<ProductVariantAttributeValueModel>> ListAsync(int attributeId,
            ProductVariantAttributeValueFilter filter = null)
        {
            var req = PrepareRequest($"product-attributes/{attributeId}/values");

            if (filter != null) req.QueryParams.AddRange(filter.ToParameters());

            return await ExecuteRequestAsync<List<ProductVariantAttributeValueModel>>(req, HttpMethod.Get,
                rootElement: "data");
        }


        /// <summary>
        ///     Retrieves the <see cref="ProductVariantAttributeValueModel" /> with the given id.
        /// </summary>
        /// <param name="attributeId">The attribute id of the product variant.</param>
        /// <param name="attributeValueId">The attribute value id of the product variant.</param>
        /// <param name="include">
        ///     If you want to include child data in the result. Example: ?include=prices (to include variants
        ///     prices). Available includes: prices, attributes, attributes.attribute
        /// </param>
        /// <returns>The <see cref="ProductVariantModel" />.</returns>
        public virtual async Task<ProductVariantAttributeValueModel> GetAsync(int attributeId, int attributeValueId,
            string include = null)
        {
            var req = PrepareRequest($"product-attributes/{attributeId}/values/{attributeValueId}");
            ;
            if (!string.IsNullOrEmpty(include)) req.QueryParams.Add("include", include);

            return await ExecuteRequestAsync<ProductVariantAttributeValueModel>(req, HttpMethod.Get,
                rootElement: "data");
        }

        /// <summary>
        ///     Creates a new <see cref="ProductVariantAttributeValueModel" /> on the store.
        /// </summary>
        /// <param name="attributeId">The attribute id of the product variant.</param>
        /// <param name="model">A new <see cref="ProductVariantAttributeValueModel" />. Id should be set to null.</param>
        /// <returns>The new <see cref="ProductVariantAttributeValueModel" />.</returns>
        public virtual async Task<ProductVariantAttributeValueModel> CreateAsync(int attributeId,
            ProductVariantAttributeValueModel model)
        {
            var req = PrepareRequest($"product-attributes/{attributeId}/values");
            var body = model.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<ProductVariantAttributeValueModel>(req, HttpMethod.Post, content, "data");
        }


        /// <summary>
        ///     Updates the given <see cref="ProductVariantAttributeValueModel" />.
        /// </summary>
        /// <param name="attributeId">The  attribute id of the product variant.</param>
        /// <param name="attributeValueId">The  attribute value id of the product variant.</param>
        /// <param name="model">The <see cref="ProductVariantAttributeValueModel" /> to update.</param>
        /// <returns>The updated <see cref="ProductVariantAttributeValueModel" />.</returns>
        public virtual async Task<ProductVariantAttributeValueModel> UpdateAsync(int attributeId, int attributeValueId,
            ProductVariantAttributeValueModel model)
        {
            var req = PrepareRequest($"product-attributes/{attributeId}/values/{attributeValueId}");
            var body = model.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<ProductVariantAttributeValueModel>(req, HttpMethod.Put, content, "data");
        }


        /// <summary>
        ///     Deletes a product attribute variant attribute value with the given attributeValueId.
        /// </summary>
        /// <param name="attributeValueId">The  attribute value id of the product variant.</param>
        /// <param name="attributeId">The attribute id of product variant</param>
        public virtual async Task DeleteAsync(int attributeId, int attributeValueId)
        {
            var req = PrepareRequest($"product-attributes/{attributeId}/values/{attributeValueId}");

            await ExecuteRequestAsync(req, HttpMethod.Delete);
        }
    }
}