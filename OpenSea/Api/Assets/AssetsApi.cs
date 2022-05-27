using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OpenSea.Api.Models;

namespace OpenSea.Api
{
    public class AssetsApi
    {
        // TODO: The API also has a "asset_contract_addresses" parameter, an array of assetContractAddress, add?
        /// <summary>
        /// Retrieves a collection of assets based on (optional) parameters
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="tokenIds"></param>
        /// <param name="assetContractAddress"></param>
        /// <param name="orderBy"></param>
        /// <param name="orderDirection"></param>
        /// <param name="collection"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public AssetsObject GetAssets(string owner, string[] tokenIds, string assetContractAddress, string orderBy, string orderDirection, string collection, int offset, int limit)
        {
            string url = " https://api.opensea.io/api/v1/assets?";

            if(!owner.Equals(string.Empty))
            {
                url += $"owner={owner}&";
            }

            if(tokenIds != null)
            {
                foreach(string tokenId in tokenIds)
                {
                    if (tokenId.Equals(string.Empty))
                        continue;

                    url += $"token_ids={tokenId}&";
                }
            }

            if(!assetContractAddress.Equals(string.Empty))
            {
                url += $"asset_contract_address={assetContractAddress}&";
            }

            if(!orderBy.Equals(string.Empty))
            {
                url += $"order_by={orderBy}&";
            }

            if(!orderDirection.Equals(string.Empty))
            {
                url += $"order_direction={orderDirection}&";
            }

            if(!collection.Equals(string.Empty))
            {
                url += $"collection={collection}&";
            }

            url += $"offset={offset.ToString()}&";

            url += $"limit={limit.ToString()}";

            // Get response and parse in to object
            // Make the GET request
            string body;
            using (WebClient wc = new WebClient())
            {
               body = wc.DownloadString(url);
            }

            // Parse response into object 
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
            AssetsObject responseObject = JsonConvert.DeserializeObject<AssetsObject>(body, settings);
            return responseObject;
        }

        // In the API, there is another endpoint for just a single asset ('asset', instead of 'assets'), instead of re-writing for that, use the assets endpoint (above method)
        /// <summary>
        /// Retrieves a single asset based on the assetContractAddress and tokenId. 
        /// </summary>
        /// <param name="assetContractAddress"></param>
        /// <param name="tokenId"></param>
        /// <returns></returns>
        public AssetsObject RetrieveSingleAsset(string assetContractAddress, string tokenId)
        {
            var responseObject = GetAssets(string.Empty, new string[] { tokenId }, assetContractAddress, string.Empty, string.Empty, string.Empty, 0, 10);
            return responseObject;
        }
    }
}
