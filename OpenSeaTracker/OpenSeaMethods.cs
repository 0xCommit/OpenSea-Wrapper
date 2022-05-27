using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenSea.Api;
using OpenSea.Api.Models;

namespace OpenSeaTracker
{
    class OpenSeaMethods
    {
        private AssetsApi assetsApi;
        private CollectionsApi collectionsApi;
        private ContractApi contractApi;
        private EventsApi eventsApi;

        public OpenSeaMethods()
        {
            assetsApi = new AssetsApi();
            collectionsApi = new CollectionsApi();
            contractApi = new ContractApi();
            eventsApi = new EventsApi();
        }

        public List<Asset> GetAllAssetsByContract(string assetContractAddress)
        {
            int offset = 0;
            int count = 50;
            string direction = "asc";
            AssetsObject assetsResponse;
            List<Asset> allAssets = new List<Asset>();

            while (true)
            {
                assetsResponse = assetsApi.GetAssets("", null, assetContractAddress, "", direction, "", offset, count);
                
                bool duplicatesFound = false;
                foreach (var asset in assetsResponse.Assets)
                {
                    if (allAssets.Contains(asset))
                    {
                        duplicatesFound = true;
                        break;
                    }
                    allAssets.Add(asset);
                }

                if (duplicatesFound) break;

                // Last page or no results, all assets found
                if (assetsResponse.Assets.Length != count)
                    break;

                // Maximum offset can be set to is 10,000. After 10k is hit, reverse the order, and grab remaining assets.
                if (offset == 10000)
                {
                    direction = "desc";
                    offset = 0;
                }
                else
                {
                    offset += count;
                }
            }

            return allAssets;
        }

        public List<Asset> GetAllAssetsByCollection(string collectionName)
        {
            int offset = 0;
            int count = 50;
            string direction = "asc";
            AssetsObject assetsResponse;
            List<Asset> allAssets = new List<Asset>();

            while (true)
            {
                assetsResponse = assetsApi.GetAssets("", null, "", "", direction, collectionName, offset, count);

                bool duplicatesFound = false;
                foreach (var asset in assetsResponse.Assets)
                {
                    if (allAssets.Contains(asset))
                    {
                        duplicatesFound = true;
                        break;
                    }
                    allAssets.Add(asset);
                }

                if (duplicatesFound) break;

                // Last page or no results, all assets found
                if (assetsResponse.Assets.Length != count)
                    break;

                // Maximum offset can be set to is 10,000. After 10k is hit, reverse the order, and grab remaining assets.
                if (offset == 10000)
                {
                    direction = "desc";
                    offset = 0;
                }
                else
                {
                    offset += count;
                }
            }

            return allAssets;
        }
   
        
    }
}
