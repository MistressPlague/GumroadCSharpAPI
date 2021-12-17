using Newtonsoft.Json;

namespace Plague.Gumroad
{
    public class GumroadUser
    {
        [JsonProperty("bio")]
        public string Bio { get; set; }
        [JsonProperty("facebook_profile")]
        public string FacebookProfile { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("twitter_handle")]
        public string TwitterHandle { get; set; }
        [JsonProperty("user_id")]
        public string UserID { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
