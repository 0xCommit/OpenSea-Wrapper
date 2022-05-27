namespace OpenSea.Api.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using OpenSea.Api.Models.Shared;

    public class AssetsObject
    {
        [JsonProperty("assets")]
        public Asset[] Assets { get; set; }
    }

    public class Asset
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("token_id")]
        public string TokenId { get; set; }

        [JsonProperty("num_sales")]
        public long NumSales { get; set; }

        [JsonProperty("background_color")]
        public object BackgroundColor { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("image_preview_url")]
        public Uri ImagePreviewUrl { get; set; }

        [JsonProperty("image_thumbnail_url")]
        public Uri ImageThumbnailUrl { get; set; }

        [JsonProperty("image_original_url")]
        public object ImageOriginalUrl { get; set; }

        [JsonProperty("animation_url")]
        public object AnimationUrl { get; set; }

        [JsonProperty("animation_original_url")]
        public object AnimationOriginalUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("external_link")]
        public object ExternalLink { get; set; }

        [JsonProperty("asset_contract")]
        public AssetContract AssetContract { get; set; }

        [JsonProperty("permalink")]
        public Uri Permalink { get; set; }

        [JsonProperty("collection")]
        public Collection Collection { get; set; }

        [JsonProperty("decimals")]
        public object Decimals { get; set; }

        [JsonProperty("token_metadata")]
        public object TokenMetadata { get; set; }

        [JsonProperty("owner")]
        public Creator Owner { get; set; }

        [JsonProperty("sell_orders")]
        public SellOrder[] SellOrders { get; set; }

        [JsonProperty("creator")]
        public Creator Creator { get; set; }

        [JsonProperty("traits")]
        public Trait[] Traits { get; set; }

        [JsonProperty("last_sale")]
        public object LastSale { get; set; }

        [JsonProperty("top_bid")]
        public object TopBid { get; set; }

        [JsonProperty("listing_date")]
        public object ListingDate { get; set; }

        [JsonProperty("is_presale")]
        public bool IsPresale { get; set; }

        [JsonProperty("transfer_fee_payment_token")]
        public object TransferFeePaymentToken { get; set; }

        [JsonProperty("transfer_fee")]
        public object TransferFee { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Asset a = obj as Asset;
            if((System.Object)a == null)
                return false;

            return (Id == a.Id) && (TokenId == a.TokenId) && (AssetContract.Address == a.AssetContract.Address);
        }
    }

    public class AssetContract
    {
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
        public string OpenseaVersion { get; set; }

        [JsonProperty("owner")]
        public long Owner { get; set; }

        [JsonProperty("schema_name")]
        public string SchemaName { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("total_supply")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? TotalSupply { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("external_link")]
        public Uri ExternalLink { get; set; }

        [JsonProperty("image_url")]
        public Uri ImageUrl { get; set; }

        [JsonProperty("default_to_fiat")]
        public bool DefaultToFiat { get; set; }

        [JsonProperty("dev_buyer_fee_basis_points")]
        public long? DevBuyerFeeBasisPoints { get; set; }

        [JsonProperty("dev_seller_fee_basis_points")]
        public long? DevSellerFeeBasisPoints { get; set; }

        [JsonProperty("only_proxied_transfers")]
        public bool OnlyProxiedTransfers { get; set; }

        [JsonProperty("opensea_buyer_fee_basis_points")]
        public long? OpenseaBuyerFeeBasisPoints { get; set; }

        [JsonProperty("opensea_seller_fee_basis_points")]
        public long? OpenseaSellerFeeBasisPoints { get; set; }

        [JsonProperty("buyer_fee_basis_points")]
        public long? BuyerFeeBasisPoints { get; set; }

        [JsonProperty("seller_fee_basis_points")]
        public long? SellerFeeBasisPoints { get; set; }

        [JsonProperty("payout_address")]
        public string PayoutAddress { get; set; }
    }

    public class Creator
    {
        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("profile_img_url")]
        public Uri ProfileImgUrl { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("config")]
        public string Config { get; set; }
    }

    public class SellOrder
    {
        [JsonProperty("created_date")]
        public DateTimeOffset CreatedDate { get; set; }

        [JsonProperty("closing_date")]
        public object ClosingDate { get; set; }

        [JsonProperty("closing_extendable")]
        public bool ClosingExtendable { get; set; }

        [JsonProperty("expiration_time")]
        public long? ExpirationTime { get; set; }

        [JsonProperty("listing_time")]
        public long? ListingTime { get; set; }

        [JsonProperty("order_hash")]
        public string OrderHash { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("exchange")]
        public string Exchange { get; set; }

        [JsonProperty("maker")]
        public FeeRecipient Maker { get; set; }

        [JsonProperty("taker")]
        public FeeRecipient Taker { get; set; }

        [JsonProperty("current_price")]
        [JsonConverter(typeof(ParseStringConverterDecimal))]
        public decimal CurrentPrice { get; set; }

        [JsonProperty("current_bounty")]
        public string CurrentBounty { get; set; }

        [JsonProperty("bounty_multiple")]
        public string BountyMultiple { get; set; }

        [JsonProperty("maker_relayer_fee")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? MakerRelayerFee { get; set; }

        [JsonProperty("taker_relayer_fee")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? TakerRelayerFee { get; set; }

        [JsonProperty("maker_protocol_fee")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? MakerProtocolFee { get; set; }

        [JsonProperty("taker_protocol_fee")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? TakerProtocolFee { get; set; }

        [JsonProperty("maker_referrer_fee")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? MakerReferrerFee { get; set; }

        [JsonProperty("fee_recipient")]
        public FeeRecipient FeeRecipient { get; set; }

        [JsonProperty("fee_method")]
        public long? FeeMethod { get; set; }

        [JsonProperty("side")]
        public long? Side { get; set; }

        [JsonProperty("sale_kind")]
        public long? SaleKind { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("how_to_call")]
        public long? HowToCall { get; set; }

        [JsonProperty("calldata")]
        public string Calldata { get; set; }

        [JsonProperty("replacement_pattern")]
        public string ReplacementPattern { get; set; }

        [JsonProperty("static_target")]
        public string StaticTarget { get; set; }

        [JsonProperty("static_extradata")]
        public string StaticExtradata { get; set; }

        [JsonProperty("payment_token")]
        public string PaymentToken { get; set; }

        [JsonProperty("payment_token_contract")]
        public PaymentTokenContract PaymentTokenContract { get; set; }

        [JsonProperty("base_price")]
        [JsonConverter(typeof(ParseStringConverterDecimal))]
        public decimal BasePrice { get; set; }

        [JsonProperty("extra")]
        [JsonConverter(typeof(ParseStringConverterDecimal))]
        public decimal Extra { get; set; }

        [JsonProperty("quantity")]
        [JsonConverter(typeof(ParseStringConverterDecimal))]
        public decimal Quantity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }

        [JsonProperty("v")]
        public decimal V { get; set; }

        [JsonProperty("r")]
        public string R { get; set; }

        [JsonProperty("s")]
        public string S { get; set; }

        [JsonProperty("approved_on_chain")]
        public bool ApprovedOnChain { get; set; }

        [JsonProperty("cancelled")]
        public bool Cancelled { get; set; }

        [JsonProperty("finalized")]
        public bool Finalized { get; set; }

        [JsonProperty("marked_invalid")]
        public bool MarkedInvalid { get; set; }

        [JsonProperty("prefixed_hash")]
        public string PrefixedHash { get; set; }
    }

    public class FeeRecipient
    {
        [JsonProperty("user")]
        public long? User { get; set; }

        [JsonProperty("profile_img_url")]
        public Uri ProfileImgUrl { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("config")]
        public string Config { get; set; }
    }

    public class Metadata
    {
        [JsonProperty("asset")]
        public MetadataAsset Asset { get; set; }

        [JsonProperty("schema")]
        public string Schema { get; set; }
    }

    public class MetadataAsset
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("quantity")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Quantity { get; set; }
    }

    public class Trait
    {
        [JsonProperty("trait_type")]
        public string TraitType { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("display_type")]
        public object DisplayType { get; set; }

        [JsonProperty("max_value")]
        public object MaxValue { get; set; }

        [JsonProperty("trait_count")]
        public long? TraitCount { get; set; }

        [JsonProperty("order")]
        public object Order { get; set; }
    }


}
