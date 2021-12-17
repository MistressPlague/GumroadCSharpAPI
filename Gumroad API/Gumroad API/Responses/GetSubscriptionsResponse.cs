using Newtonsoft.Json;

namespace Plague.Gumroad
{
    public class GetSubscriptionsResponse
    {
        [JsonProperty("success")]
        public bool IsSuccess { get; set; }
        [JsonProperty("subscribers")]
        public GumroadSubscriber[] Subscribers { get; set; }
    }
}