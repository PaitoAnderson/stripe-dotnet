namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class PriceService : Service<Price>,
        ICreatable<Price, PriceCreateOptions>,
        IListable<Price, PriceListOptions>,
        IRetrievable<Price, PriceGetOptions>,
        IUpdatable<Price, PriceUpdateOptions>
    {
        public PriceService()
            : base(null)
        {
        }

        public PriceService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/prices";

        public virtual Price Create(PriceCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Price> CreateAsync(PriceCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Price Get(string priceId, PriceGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(priceId, options, requestOptions);
        }

        public virtual Task<Price> GetAsync(string priceId, PriceGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(priceId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Price> List(PriceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Price>> ListAsync(PriceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Price> ListAutoPaging(PriceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

#if !NET45
        public virtual IAsyncEnumerable<Price> ListAutoPagingAsync(PriceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }
#endif

        public virtual Price Update(string priceId, PriceUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(priceId, options, requestOptions);
        }

        public virtual Task<Price> UpdateAsync(string priceId, PriceUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(priceId, options, requestOptions, cancellationToken);
        }
    }
}
