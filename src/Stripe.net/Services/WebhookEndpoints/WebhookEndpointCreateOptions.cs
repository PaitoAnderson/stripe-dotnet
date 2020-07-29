namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class WebhookEndpointCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Events sent to this endpoint will be generated with this Stripe Version instead of your
        /// account's default Stripe Version.
        /// </summary>
        [JsonProperty("api_version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Whether this endpoint should receive events from connected accounts (<c>true</c>), or
        /// from your account (<c>false</c>). Defaults to <c>false</c>.
        /// </summary>
        [JsonProperty("connect")]
        public bool? Connect { get; set; }

        /// <summary>
        /// An optional description of what the webhook is used for.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The list of events to enable for this endpoint. You may specify <c>['*']</c> to enable
        /// all events, except those that require explicit selection.
        /// </summary>
        [JsonProperty("enabled_events")]
        public List<string> EnabledEvents { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The URL of the webhook endpoint.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
