namespace Stripe
{
    using Newtonsoft.Json;

    public class LoginLinkCreateOnAccountOptions : BaseOptions
    {
        /// <summary>
        /// Where to redirect the user after they log out of their dashboard.
        /// </summary>
        [JsonProperty("redirect_url")]
        public string RedirectUrl { get; set; }
    }
}
