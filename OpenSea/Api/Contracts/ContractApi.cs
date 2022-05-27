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
    public class ContractApi
    {
        public Contract RetrieveSingleContract(string assetContractAddress)
        {
            string url = $"https://api.opensea.io/api/v1/asset_contract/{assetContractAddress}";

            // Get response
            string body;
            using (WebClient wc = new WebClient())
            {
                body = wc.DownloadString(url);
            }

            // Parse into Contract object and return 
            Contract assetContract = JsonConvert.DeserializeObject<Contract>(body);
            return assetContract;


        }
    }
}
