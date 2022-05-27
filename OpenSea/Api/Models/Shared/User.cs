using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OpenSea.Api.Models.Shared
{
    public class User
    {
        [JsonProperty("username")]
        public string Username { get; set; }
    }
}
