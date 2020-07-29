namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CardShipping : StripeEntity<CardShipping>
    {
        [JsonProperty("address")]
        public Address Address { get; set; }

        /// <summary>
        /// The delivery company that shipped a card.
        /// </summary>
        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        /// <summary>
        /// A unix timestamp representing a best estimate of when the card will be delivered.
        /// </summary>
        [JsonProperty("eta")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Eta { get; set; }

        /// <summary>
        /// Recipient name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Shipment service, such as <c>standard</c> or <c>express</c>.
        /// </summary>
        [JsonProperty("service")]
        public string Service { get; set; }

        /// <summary>
        /// The delivery status of the card.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// A tracking number for a card shipment.
        /// </summary>
        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// A link to the shipping carrier's site where you can view detailed information about a
        /// card shipment.
        /// </summary>
        [JsonProperty("tracking_url")]
        public string TrackingUrl { get; set; }

        /// <summary>
        /// Packaging options.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
