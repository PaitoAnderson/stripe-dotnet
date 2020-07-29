namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodFpxOptions : INestedOptions
    {
        /// <summary>
        /// Account holder type for FPX transaction.
        /// </summary>
        [JsonProperty("account_holder_type")]
        public string AccountHolderType { get; set; }

        /// <summary>
        /// The customer's bank.
        /// </summary>
        [JsonProperty("bank")]
        public string Bank { get; set; }
    }
}
