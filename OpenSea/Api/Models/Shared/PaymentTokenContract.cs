using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OpenSea.Api.Models.Shared
{
    public class PaymentTokenContract
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("image_url")]
        public Uri ImageUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("decimals")]
        public long? Decimals { get; set; }

        [JsonProperty("eth_price")]
        public string EthPrice { get; set; }

        [JsonProperty("usd_price")]
        public string UsdPrice { get; set; }
    }

}
