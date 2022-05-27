using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net;
using Newtonsoft.Json;
using OpenSea.Api.Models;

namespace OpenSea.Api
{
    public class EventsApi
    {
        /// <summary>
        /// Retrieve Events that occurs on assets that OpenSea tracks based on (optional) parameters.
        /// </summary>
        /// <param name="assetContractAddress">(Optional) The NFT contract address for the assets for which to show events. Empty string if filter not required.</param>
        /// <param name="collectionSlug">(Optional)</param>
        /// <param name="tokenId"></param>
        /// <param name="accountAddress"></param>
        /// <param name="eventType"></param>
        /// <param name="onlyOpensea"></param>
        /// <param name="auctionType"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="occuredBefore"></param>
        /// <param name="occuredAfter"></param>
        public EventsObject RetrieveEvents(string assetContractAddress, string collectionSlug, string tokenId, string accountAddress, string eventType, bool onlyOpensea, string auctionType,
                                        int offset, int limit, long occuredBefore = -1, long occuredAfter = -1)
        {
            string url = "https://api.opensea.io/api/v1/events?";

            // Build URL
            if(!assetContractAddress.Equals(string.Empty))
            {
                url += $"asset_contract_address={assetContractAddress}&";
            }

            
            if(!collectionSlug.Equals(string.Empty))
            {
                url += $"collection_slug={collectionSlug}&";
            }

            if(!tokenId.Equals(string.Empty))
            {
                url += $"token_id={tokenId}&";
            }

            if(!accountAddress.Equals(string.Empty))
            {
                url += $"account_address={accountAddress}&";
            }

            if(!eventType.Equals(string.Empty))
            {
                url += $"event_type={eventType}&";
            }

            url += $"only_opensea={onlyOpensea.ToString()}&";

            if(!auctionType.Equals(string.Empty))
            {
                url += $"auction_type={auctionType}&";
            }

            url += $"offset={offset.ToString()}&";

            url += $"limit={limit.ToString()}&";

            if(occuredBefore != -1)
            {
                url += $"occured_before={occuredBefore}&";
            }

            if(occuredAfter != -1)
            {
                url += $"occured_after={occuredAfter}";
            }

            // Remove trailing '&' if exists
            if(url[url.Length - 1].Equals('&'))
            {
                url = url.Remove(url.Length - 1);
            }

            // Make the GET request
            string body;
            using (WebClient wc = new WebClient())
            {
                body = wc.DownloadString(url);
            }

            // Parse response into object 
            EventsObject responseObject = JsonConvert.DeserializeObject<EventsObject>(body);
            return responseObject;
        }
    }
}
