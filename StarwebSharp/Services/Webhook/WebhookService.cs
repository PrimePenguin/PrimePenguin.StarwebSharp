using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using StarwebSharp.Entities;
using StarwebSharp.Extensions;
using StarwebSharp.Filters;
using StarwebSharp.Infrastructure;

namespace StarwebSharp.Services.Webhook
{
    /// <summary>
    /// A service for manipulating Starweb webhooks.
    /// </summary>
    public class WebhookService : StarwebService
    {
        /// <summary>
        /// Creates a new instance of <see cref="WebhookService" />.
        /// </summary>
        /// <param name="myStarwebUrl">The shop's *.mystrweb.se/api/vX URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public WebhookService(string myStarwebUrl, string shopAccessToken) : base(myStarwebUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a list of webhooks.
        /// </summary>
        /// <returns></returns>
        public virtual async Task<IEnumerable<WebHookModel>> ListAsync()
        {
            var req = PrepareRequest("web-hooks");
            return await ExecuteRequestAsync<List<WebHookModel>>(req, HttpMethod.Get, rootElement: "data");
        }

        /// <summary>
        /// Retrieves the <see cref="WebHookModel"/> with the given id.
        /// </summary>
        /// <param name="webhookId">The id of the webhook to retrieve.</param>
        /// <returns>The <see cref="WebHookModel"/>.</returns>
        public virtual async Task<WebHookModel> GetAsync(int webhookId)
        {
            var req = PrepareRequest($"web-hooks/{webhookId}");
            return await ExecuteRequestAsync<WebHookModel>(req, HttpMethod.Get, rootElement: "data");
        }

        /// <summary>
        /// Creates a new <see cref="WebHookModel"/> on the store.
        /// </summary>
        /// <param name="webhook">A new <see cref="WebHookModel"/>. Id should be set to null.</param>
        /// <returns>The new <see cref="WebHookModel"/>.</returns>
        public virtual async Task<WebHookModel> CreateAsync(WebHookModel webhook)
        {
            var req = PrepareRequest("web-hooks");
            var body = webhook.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<WebHookModel>(req, HttpMethod.Post, content, "data");
        }

        /// <summary>
        /// Updates the given <see cref="WebHookModel"/>.
        /// </summary>
        /// <param name="webhookId">Id of the object being updated.</param>
        /// <param name="webhook">The <see cref="WebHookModel"/> to update.</param>
        /// <returns>The updated <see cref="WebHookModel"/>.</returns>
        public virtual async Task<WebHookModel> UpdateAsync(int webhookId, WebHookModel webhook)
        {
            var req = PrepareRequest($"web-hooks/{webhookId}");
            var body = webhook.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<WebHookModel>(req, HttpMethod.Put, content, "data");
        }

#if NETCORE
        /// <summary>
        /// Updates the given <see cref="WebHookModel"/>.
        /// </summary>
        /// <param name="webhookId">Id of the object being updated.</param>
        /// <param name="webhook">The <see cref="WebHookModel"/> to update.</param>
        /// <returns>The updated <see cref="WebHookModel"/>.</returns>
        public virtual async Task<WebHookModel> PatchAsync(int webhookId, WebHookModel webhook)
        {
            var req = PrepareRequest($"web-hooks/{webhookId}");
            var body = webhook.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<WebHookModel>(req, HttpMethod.Patch, content, "data");
        }
#endif

        /// <summary>
        /// Deletes a webhook with the given Id.
        /// </summary>
        /// <param name="webhookId">The webhook object's Id.</param>
        public virtual async Task DeleteAsync(int webhookId)
        {
            var req = PrepareRequest($"web-hooks/{webhookId}");

            await ExecuteRequestAsync(req, HttpMethod.Delete);
        }
    }
}
