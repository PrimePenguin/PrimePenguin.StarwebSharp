using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using StarwebSharp.Entities;

namespace StarwebSharp.Services.Currency
{
    /// <summary>
    ///     A service for manipulating Starweb Currencies.
    /// </summary>
    public class CurrencyService : StarwebService
    {
        /// <summary>
        ///     Creates a new instance of <see cref="CurrencyService" />.
        /// </summary>
        /// <param name="myStarwebUrl">The shop's *.mystrweb.se/api/vX URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public CurrencyService(string myStarwebUrl, string shopAccessToken) : base(myStarwebUrl, shopAccessToken)
        {
        }

        /// <summary>
        ///     Gets a list of currencies.
        /// </summary>
        /// <returns></returns>
        public virtual async Task<IEnumerable<CurrencyModel>> ListAsync()
        {
            var req = PrepareRequest("currencies");
            return await ExecuteRequestAsync<List<CurrencyModel>>(req, HttpMethod.Get, rootElement: "data");
        }

        /// <summary>
        ///     Retrieves the <see cref="CurrencyModel" /> with the given currency code.
        /// </summary>
        /// <param name="currencyCode">The code of the currency to retrieve.</param>
        /// <returns>The <see cref="CurrencyModel" />.</returns>
        public virtual async Task<CurrencyModel> GetAsync(string currencyCode)
        {
            var req = PrepareRequest($"currencies/{currencyCode}");
            return await ExecuteRequestAsync<CurrencyModel>(req, HttpMethod.Get, rootElement: "data");
        }
    }
}