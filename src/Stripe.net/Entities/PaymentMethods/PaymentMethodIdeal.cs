namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodIdeal : StripeEntity<PaymentMethodIdeal>
    {
        /// <summary>
        /// The customer's bank, if provided. Can be one of <c>abn_amro</c>, <c>asn_bank</c>,
        /// <c>bunq</c>, <c>handelsbanken</c>, <c>ing</c>, <c>knab</c>, <c>moneyou</c>,
        /// <c>rabobank</c>, <c>regiobank</c>, <c>sns_bank</c>, <c>triodos_bank</c>, or
        /// <c>van_lanschot</c>.
        /// </summary>
        [JsonProperty("bank")]
        public string Bank { get; set; }

        /// <summary>
        /// The Bank Identifier Code of the customer's bank, if the bank was provided.
        /// </summary>
        [JsonProperty("bic")]
        public string Bic { get; set; }
    }
}
