using Newtonsoft.Json;
using System.Collections.Generic;

namespace Plague.Gumroad
{
    public class GetSalesResponse
    {
        [JsonProperty("success")]
        public bool IsSuccess { get; set; }
        [JsonProperty("next_page_url")]
        public string NextPageUrl { get; set; }
        [JsonProperty("sales")]
        public IReadOnlyList<GumroadSale> Sales { get; set; }
    }
}
