namespace OpenSea.Api.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using OpenSea.Api.Models.Shared;

    public class EventsObject
    {
        [JsonProperty("asset_events")]
        public Event[] AssetEvents { get; set; }
    }

    public class Event
    {
        [JsonProperty("approved_account")]
        public object ApprovedAccount { get; set; }

        [JsonProperty("asset")]
        public Asset Asset { get; set; }

        [JsonProperty("asset_bundle")]
        public object AssetBundle { get; set; }

        [JsonProperty("auction_type")]
        public string AuctionType { get; set; }

        [JsonProperty("bid_amount")]
        public string BidAmount { get; set; }

        [JsonProperty("collection_slug")]
        public string CollectionSlug { get; set; }

        [JsonProperty("contract_address")]
        public string ContractAddress { get; set; }

        [JsonProperty("created_date")]
        public DateTimeOffset CreatedDate { get; set; }

        [JsonProperty("custom_event_name")]
        public object CustomEventName { get; set; }

        [JsonProperty("dev_fee_payment_event")]
        public object DevFeePaymentEvent { get; set; }

        [JsonProperty("duration")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Duration { get; set; }

        [JsonProperty("ending_price")]
        public string EndingPrice { get; set; }

        [JsonProperty("event_type")]
        public string EventType { get; set; }

        [JsonProperty("from_account")]
        public Account FromAccount { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("owner_account")]
        public object OwnerAccount { get; set; }

        [JsonProperty("payment_token")]
        public PaymentTokenContract PaymentToken { get; set; }

        [JsonProperty("quantity")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Quantity { get; set; }

        [JsonProperty("seller")]
        public Account Seller { get; set; }

        [JsonProperty("starting_price")]
        public string StartingPrice { get; set; }

        [JsonProperty("to_account")]
        public object ToAccount { get; set; }

        [JsonProperty("total_price")]
        public object TotalPrice { get; set; }

        [JsonProperty("transaction")]
        public Transaction Transaction { get; set; }

        [JsonProperty("winner_account")]
        public object WinnerAccount { get; set; }
    }

    public class Account
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

    public class Transaction
    {
        [JsonProperty("block_hash")]
        public string BlockHash { get; set; }

        [JsonProperty("block_number")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long BlockNumber { get; set; }

        [JsonProperty("from_account")]
        public Account FromAccount { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("timestamp")]
        public DateTimeOffset Timestamp { get; set; }

        [JsonProperty("to_account")]
        public Account ToAccount { get; set; }

        [JsonProperty("transaction_hash")]
        public string TransactionHash { get; set; }

        [JsonProperty("transaction_index")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long TransactionIndex { get; set; }
    }

}
