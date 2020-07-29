namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CardholderSpendingControlsSpendingLimitOptions : INestedOptions
    {
        /// <summary>
        /// Maximum amount allowed to spend per interval.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Array of strings containing <a
        /// href="https://stripe.com/docs/api#issuing_authorization_object-merchant_data-category">categories</a>
        /// this limit applies to. Omitting this field will apply the limit to all categories.
        /// </summary>
        [JsonProperty("categories")]
        public List<string> Categories { get; set; }

        /// <summary>
        /// Interval (or event) to which the amount applies.
        /// </summary>
        [JsonProperty("interval")]
        public string Interval { get; set; }
    }
}
