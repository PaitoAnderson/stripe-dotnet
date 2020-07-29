namespace Stripe
{
    using Newtonsoft.Json;

    public class IssuerFraudRecordListOptions : ListOptions
    {
        [JsonProperty("charge")]
        public string Charge { get; set; }
    }
}
