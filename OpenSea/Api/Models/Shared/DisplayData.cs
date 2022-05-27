using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OpenSea.Api.Models.Shared
{
    public class DisplayData
    {
        [JsonProperty("card_display_style")]
        public string CardDisplayStyle { get; set; }

        [JsonProperty("images", NullValueHandling = NullValueHandling.Ignore)]
        public object[] Images { get; set; }
    }
}
