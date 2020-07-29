namespace Stripe
{
    using Newtonsoft.Json;

    public class BitcoinReceiverListOptions : ListOptions
    {
        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("filled")]
        public bool? Filled { get; set; }

        [JsonProperty("uncaptured_funds")]
        public bool? UncapturedFunds { get; set; }
    }
}
