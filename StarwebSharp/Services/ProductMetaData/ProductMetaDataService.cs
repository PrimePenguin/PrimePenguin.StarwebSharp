using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using StarwebSharp.Entities;
using StarwebSharp.Extensions;
using StarwebSharp.Filters;
using StarwebSharp.Infrastructure;

namespace StarwebSharp.Services.ProductMetaData
{
    public class ProductMetaDataService : StarwebService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ProductMetaDataService" />.
        /// </summary>
        /// <param name="myStarwebUrl">The shop's *.mystrweb.se/api/vX URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ProductMetaDataService(string myStarwebUrl, string shopAccessToken) : base(myStarwebUrl,
            shopAccessToken)
        {
        }

        /// <summary>
        /// Gets a list of product meta data types. Max 100 per call.
        /// </summary>
        /// /// <param name="productId">The product Id of the product</param>
        /// <returns></returns>
        public virtual async Task<IEnumerable<ProductMetaDataModel>> ListAsync(int productId,
            ProductMetaDataTypeFilter filter = null)
        {
            var req = PrepareRequest($"products/{productId}/meta-data");

            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToParameters());
            }

            return await ExecuteRequestAsync<List<ProductMetaDataModel>>(req, HttpMethod.Get,
                rootElement: "data");
        }

        /// <summary>
        /// Retrieves the <see cref="ProductMetaDataModel"/> with the given metaDataTypeId.
        /// </summary>
        /// <param name="productId">The product id of the product </param>
        /// <param name="metaDataTypeId">The meta data type id  of the product.</param>
        /// <param name="include">If you want to include child data in the result. Example: ?include=prices (to include variants prices). Available includes: prices, attributes, attributes.attribute</param>
        /// <returns>The <see cref="ProductMetaDataModel"/>.</returns>
        public virtual async Task<ProductMetaDataModel> GetAsync(int productId, int metaDataTypeId,
            string include = null)
        {
            var req = PrepareRequest($"products/{productId}/meta-data/{metaDataTypeId}");
            ;
            if (!string.IsNullOrEmpty(include))
            {
                req.QueryParams.Add("include", include);
            }

            return await ExecuteRequestAsync<ProductMetaDataModel>(req, HttpMethod.Get,
                rootElement: "data");
        }

        /// <summary>
        /// Creates a new <see cref="ProductMetaDataModel"/> on the store.
        /// </summary>
        /// <param name="productId">The product id of the product.</param>
        /// <param name="model">A new <see cref="ProductMetaDataModel"/>. Id should be set to null.</param>
        /// <returns>The new <see cref="ProductMetaDataModel"/>.</returns>
        public virtual async Task<ProductMetaDataModel> CreateAsync(int productId,
            ProductMetaDataTypeModel model)
        {
            var req = PrepareRequest($"products/{productId}/meta-data");
            var body = model.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<ProductMetaDataModel>(req, HttpMethod.Post, content, "data");
        }

        /// <summary>
        /// Updates the given <see cref="ProductMetaDataModel"/>.
        /// </summary>
        /// <param name="productId">The  product id of the product.</param>
        /// <param name="metaDataTypeId">The  meta data type id of the product.</param>
        /// <param name="model">The <see cref="ProductMetaDataModel"/> to update.</param>
        /// <returns>The updated <see cref="ProductMetaDataModel"/>.</returns>
        public virtual async Task<ProductMetaDataModel> UpdateAsync(int productId, int metaDataTypeId,
            ProductMetaDataModel model)
        {
            var req = PrepareRequest($"products/{productId}/meta-data/{metaDataTypeId}");
            var body = model.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<ProductMetaDataModel>(req, HttpMethod.Put, content, "data");
        }

        /// <summary>
        /// Deletes a product meta data metaDataTypeId.
        /// </summary>
        /// <param name="metaDataTypeId">The  metaDataTypeId of the product.</param>
        /// <param name="productId">The product Id of product</param>
        public virtual async Task DeleteAsync(int productId, int metaDataTypeId)
        {
            var req = PrepareRequest($"products/{productId}/meta-data/{metaDataTypeId}");

            await ExecuteRequestAsync(req, HttpMethod.Delete);
        }
    }
}
