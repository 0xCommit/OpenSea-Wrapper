using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using OpenSea.Api.Models;

namespace OpenSea.Api
{
    public class CollectionsApi
    {
        /// <summary>
        /// Retrieves a list of all the supported collections on OpenSea. If a wallet address is supplied, returns only the collections relevant to that user. 
        /// </summary>
        /// <param name="assetOwner">(Optional) Specifying a wallet address will constrain the results to collections where the user owns at least one asset of the collection</param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        public CollectionsObject RetrieveCollections(string assetOwner, int offset, int limit)
        {
            string url = "https://api.opensea.io/api/v1/collections?";

            if(!assetOwner.Equals(string.Empty))
            {
                url += $"asset_owner={assetOwner}&";
            }

            url += $"offset={offset.ToString()}&";

            url += $"limit={limit.ToString()}";

            // Make GET request
            string body;
            using (WebClient wc = new WebClient())
            {
                body = wc.DownloadString(url);
            }

            // Parse response into object
            // Depending if assetOwner is supplied or not, the JSON changes, so deal with each way, and for both, return a CollectionsObject
            CollectionsObject collectionsObject = null;

            if(assetOwner.Equals(string.Empty))
            {
                collectionsObject = JsonConvert.DeserializeObject<CollectionsObject>(body);
            }
            else
            {
                List<Collection> collectionsList = JsonConvert.DeserializeObject<List<Collection>>(body);
                collectionsObject = new CollectionsObject() { Collections = collectionsList.ToArray() };
            }

            return collectionsObject;
        }
    }
}
