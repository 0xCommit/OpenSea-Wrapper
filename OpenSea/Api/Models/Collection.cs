namespace OpenSea.Api.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using OpenSea.Api.Models.Shared;

    public class CollectionsObject
    {
        [JsonProperty("collections")]
        public Collection[] Collections { get; set; }
    }

    public class Collection
    {
        [JsonProperty("primary_asset_contracts")]
        public object[] PrimaryAssetContracts { get; set; }

        [JsonProperty("traits")]
        public Traits Traits { get; set; }

        [JsonProperty("stats")]
        public Dictionary<string, long> Stats { get; set; }

        [JsonProperty("banner_image_url")]
        public Uri BannerImageUrl { get; set; }

        [JsonProperty("chat_url")]
        public object ChatUrl { get; set; }

        [JsonProperty("created_date")]
        public DateTimeOffset CreatedDate { get; set; }

        [JsonProperty("default_to_fiat")]
        public bool DefaultToFiat { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("dev_buyer_fee_basis_points")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long DevBuyerFeeBasisPoints { get; set; }

        [JsonProperty("dev_seller_fee_basis_points")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long DevSellerFeeBasisPoints { get; set; }

        [JsonProperty("discord_url")]
        public object DiscordUrl { get; set; }

        [JsonProperty("display_data")]
        public DisplayData DisplayData { get; set; }

        [JsonProperty("external_url")]
        public Uri ExternalUrl { get; set; }

        [JsonProperty("featured")]
        public bool Featured { get; set; }

        [JsonProperty("featured_image_url")]
        public Uri FeaturedImageUrl { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("safelist_request_status")]
        public string SafelistRequestStatus { get; set; }

        [JsonProperty("image_url")]
        public Uri ImageUrl { get; set; }

        [JsonProperty("is_subject_to_whitelist")]
        public bool IsSubjectToWhitelist { get; set; }

        [JsonProperty("large_image_url")]
        public Uri LargeImageUrl { get; set; }

        [JsonProperty("medium_username")]
        public object MediumUsername { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("only_proxied_transfers")]
        public bool OnlyProxiedTransfers { get; set; }

        [JsonProperty("opensea_buyer_fee_basis_points")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long OpenseaBuyerFeeBasisPoints { get; set; }

        [JsonProperty("opensea_seller_fee_basis_points")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long OpenseaSellerFeeBasisPoints { get; set; }

        [JsonProperty("payout_address")]
        public string PayoutAddress { get; set; }

        [JsonProperty("require_email")]
        public bool RequireEmail { get; set; }

        [JsonProperty("short_description")]
        public object ShortDescription { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("telegram_url")]
        public object TelegramUrl { get; set; }

        [JsonProperty("twitter_username")]
        public string TwitterUsername { get; set; }

        [JsonProperty("instagram_username")]
        public string InstagramUsername { get; set; }

        [JsonProperty("wiki_url")]
        public object WikiUrl { get; set; }
    }

    public partial class Traits
    {

    }
}
