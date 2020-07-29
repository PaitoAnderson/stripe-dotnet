namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsIdeal : StripeEntity<ChargePaymentMethodDetailsIdeal>
    {
        /// <summary>
        /// The customer's bank. Can be one of <c>abn_amro</c>, <c>asn_bank</c>, <c>bunq</c>,
        /// <c>handelsbanken</c>, <c>ing</c>, <c>knab</c>, <c>moneyou</c>, <c>rabobank</c>,
        /// <c>regiobank</c>, <c>sns_bank</c>, <c>triodos_bank</c>, or <c>van_lanschot</c>.
        /// </summary>
        [JsonProperty("bank")]
        public string Bank { get; set; }

        /// <summary>
        /// The Bank Identifier Code of the customer's bank.
        /// </summary>
        [JsonProperty("bic")]
        public string Bic { get; set; }

        /// <summary>
        /// Last four characters of the IBAN.
        /// </summary>
        [JsonProperty("iban_last4")]
        public string IbanLast4 { get; set; }

        /// <summary>
        /// Owner's verified full name. Values are verified or provided by iDEAL directly (if
        /// supported) at the time of authorization or settlement. They cannot be set or mutated.
        /// </summary>
        [JsonProperty("verified_name")]
        public string VerifiedName { get; set; }
    }
}
