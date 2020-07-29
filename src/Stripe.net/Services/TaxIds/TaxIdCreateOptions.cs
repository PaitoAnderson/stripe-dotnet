namespace Stripe
{
    using Newtonsoft.Json;

    public class TaxIdCreateOptions : BaseOptions
    {
        /// <summary>
        /// Type of the tax ID, one of <c>eu_vat</c>, <c>br_cnpj</c>, <c>br_cpf</c>, <c>nz_gst</c>,
        /// <c>au_abn</c>, <c>in_gst</c>, <c>no_vat</c>, <c>za_vat</c>, <c>ch_vat</c>,
        /// <c>mx_rfc</c>, <c>sg_uen</c>, <c>ru_inn</c>, <c>ca_bn</c>, <c>hk_br</c>, <c>es_cif</c>,
        /// <c>tw_vat</c>, <c>th_vat</c>, <c>jp_cn</c>, <c>li_uid</c>, <c>my_itn</c>, <c>us_ein</c>,
        /// <c>kr_brn</c>, <c>ca_qst</c>, <c>my_sst</c>, <c>sg_gst</c>, <c>ae_trn</c>,
        /// <c>cl_tin</c>, <c>sa_vat</c>, <c>id_npwp</c>, or <c>my_frp.</c>
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Value of the tax ID.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
