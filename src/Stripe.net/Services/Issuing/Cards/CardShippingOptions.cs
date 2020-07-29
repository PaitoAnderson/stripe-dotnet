namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardShippingOptions : INestedOptions
    {
        /// <summary>
        /// The address that the card is shipped to.
        /// </summary>
        [JsonProperty("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// The name printed on the shipping label when shipping the card.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Shipment service.
        /// </summary>
        [JsonProperty("service")]
        public string Service { get; set; }

        /// <summary>
        /// Packaging options.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
