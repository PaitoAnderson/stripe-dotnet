namespace Stripe
{
    using Newtonsoft.Json;

    public class TokenAccountOptions : INestedOptions
    {
        /// <summary>
        /// The business type.
        /// </summary>
        [JsonProperty("business_type")]
        public string BusinessType { get; set; }

        /// <summary>
        /// Information about the company or business.
        /// </summary>
        [JsonProperty("company")]
        public TokenAccountCompanyOptions Company { get; set; }

        /// <summary>
        /// Information about the person represented by the account.
        /// </summary>
        [JsonProperty("individual")]
        public TokenPersonOptions Individual { get; set; }

        /// <summary>
        /// Whether the user described by the data in the token has been shown <a
        /// href="https://stripe.com/docs/connect/account-tokens#stripe-connected-account-agreement">the
        /// Stripe Connected Account Agreement</a>. When creating an account token to create a new
        /// Connect account, this value must be <c>true</c>.
        /// </summary>
        [JsonProperty("tos_shown_and_accepted")]
        public bool? TosShownAndAccepted { get; set; }
    }
}
