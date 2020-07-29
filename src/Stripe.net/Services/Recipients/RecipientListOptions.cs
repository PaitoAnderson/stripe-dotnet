namespace Stripe
{
    using Newtonsoft.Json;

    public class RecipientListOptions : ListOptionsWithCreated
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("verified")]
        public bool? Verified { get; set; }
    }
}
