namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsCardThreeDSecure : StripeEntity<ChargePaymentMethodDetailsCardThreeDSecure>
    {
        /// <summary>
        /// Whether or not authentication was performed. 3D Secure will succeed without
        /// authentication when the card is not enrolled.
        /// </summary>
        [JsonProperty("authenticated")]
        public bool Authenticated { get; set; }

        /// <summary>
        /// For authenticated transactions: how the customer was authenticated by the issuing bank.
        /// </summary>
        [JsonProperty("authentication_flow")]
        public string AuthenticationFlow { get; set; }

        /// <summary>
        /// Indicates the outcome of 3D Secure authentication.
        /// </summary>
        [JsonProperty("result")]
        public string Result { get; set; }

        /// <summary>
        /// Additional information about why 3D Secure succeeded or failed based on the
        /// <c>result</c>.
        /// </summary>
        [JsonProperty("result_reason")]
        public string ResultReason { get; set; }

        /// <summary>
        /// Whether or not 3D Secure succeeded.
        /// </summary>
        [JsonProperty("succeeded")]
        public bool Succeeded { get; set; }

        /// <summary>
        /// The version of 3D Secure that was used.
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
