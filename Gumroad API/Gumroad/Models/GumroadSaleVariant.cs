using Newtonsoft.Json;
using System;

namespace Plague.Gumroad
{
    public class GumroadSaleVariant
    {
        [JsonProperty("Tier")]
        public string Tier { get; set; }
    }
}
