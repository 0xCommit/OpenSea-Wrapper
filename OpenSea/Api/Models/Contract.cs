namespace OpenSea.Api.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class Contract
    {
        [JsonProperty("collection")]
        public Collection Collection { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("asset_contract_type")]
        public string AssetContractType { get; set; }

        [JsonProperty("created_date")]
        public DateTimeOffset CreatedDate { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nft_version")]
        public string NftVersion { get; set; }

        [JsonProperty("opensea_version")]
        public object OpenseaVersion { get; set; }

        [JsonProperty("owner")]
        public long Owner { get; set; }

        [JsonProperty("schema_name")]
        public string SchemaName { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("total_supply")]
        public object TotalSupply { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("external_link")]
        public Uri ExternalLink { get; set; }

        [JsonProperty("image_url")]
        public Uri ImageUrl { get; set; }

        [JsonProperty("default_to_fiat")]
        public bool DefaultToFiat { get; set; }

        [JsonProperty("dev_buyer_fee_basis_points")]
        public long DevBuyerFeeBasisPoints { get; set; }

        [JsonProperty("dev_seller_fee_basis_points")]
        public long DevSellerFeeBasisPoints { get; set; }

        [JsonProperty("only_proxied_transfers")]
        public bool OnlyProxiedTransfers { get; set; }

        [JsonProperty("opensea_buyer_fee_basis_points")]
        public long OpenseaBuyerFeeBasisPoints { get; set; }

        [JsonProperty("opensea_seller_fee_basis_points")]
        public long OpenseaSellerFeeBasisPoints { get; set; }

        [JsonProperty("buyer_fee_basis_points")]
        public long BuyerFeeBasisPoints { get; set; }

        [JsonProperty("seller_fee_basis_points")]
        public long SellerFeeBasisPoints { get; set; }

        [JsonProperty("payout_address")]
        public object PayoutAddress { get; set; }
    }

}
