namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class IssuerFraudRecordService : Service<IssuerFraudRecord>,
        IListable<IssuerFraudRecord, IssuerFraudRecordListOptions>,
        IRetrievable<IssuerFraudRecord, IssuerFraudRecordGetOptions>
    {
        public IssuerFraudRecordService()
            : base(null)
        {
        }

        public IssuerFraudRecordService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/issuer_fraud_records";

        public virtual IssuerFraudRecord Get(string id, IssuerFraudRecordGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<IssuerFraudRecord> GetAsync(string id, IssuerFraudRecordGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<IssuerFraudRecord> List(IssuerFraudRecordListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<IssuerFraudRecord>> ListAsync(IssuerFraudRecordListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<IssuerFraudRecord> ListAutoPaging(IssuerFraudRecordListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual IAsyncEnumerable<IssuerFraudRecord> ListAutoPagingAsync(IssuerFraudRecordListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }
    }
}
