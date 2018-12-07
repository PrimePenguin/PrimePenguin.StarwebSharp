using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using StarwebSharp.Entities;

namespace StarwebSharp.Services.ShippingMethod
{
    /// <summary>
    /// A service for manipulating Starweb shipping methods.
    /// </summary>
    public class ShippingMethodService : StarwebService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ShippingMethodService" />.
        /// </summary>
        /// <param name="myStarwebUrl">The shop's *.mystrweb.se/api/vX URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShippingMethodService(string myStarwebUrl, string shopAccessToken) : base(myStarwebUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a list of shipping methods.
        /// </summary>
        /// <returns></returns>
        public virtual async Task<IEnumerable<ShippingMethodModel>> ListAsync()
        {
            var req = PrepareRequest("shipping-methods");
            return await ExecuteRequestAsync<List<ShippingMethodModel>>(req, HttpMethod.Get, rootElement: "data");
        }

        /// <summary>
        /// Retrieves the <see cref="ShippingMethodModel"/> with the given id.
        /// </summary>
        /// <param name="shippingMethodId">The id of the shipping method to retrieve.</param>
        /// <returns>The <see cref="ShippingMethodModel"/>.</returns>
        public virtual async Task<ShippingMethodModel> GetAsync(int shippingMethodId)
        {
            var req = PrepareRequest($"shipping-methods/{shippingMethodId}");
            return await ExecuteRequestAsync<ShippingMethodModel>(req, HttpMethod.Get, rootElement: "data");
        }
    }
}
