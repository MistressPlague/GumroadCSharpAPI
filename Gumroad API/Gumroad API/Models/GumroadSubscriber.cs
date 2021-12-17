using Newtonsoft.Json;

namespace Plague.Gumroad
{
    public class GumroadSubscriber
    {
        [JsonProperty("id")]
        public string ID { get; set; }
        [JsonProperty("product_id")]
        public string ProductID { get; set; }
        [JsonProperty("product_name")]
        public string ProductName { get; set; }
        [JsonProperty("user_id")]
        public string UserID { get; set; }
        [JsonProperty("user_email")]
        public string UserEmail { get; set; }
        [JsonProperty("purchase_ids")]
        public string[] PurchaseIDs { get; set; }
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
        [JsonProperty("cancelled_at")]
        public string CancelledAt { get; set; }
        [JsonProperty("user_requested_cancellation_at")]
        public string UserRequestedCancellationAt { get; set; }
        [JsonProperty("change_occurence_count")]
        public string ChangeOccurenceCount { get; set; }
        [JsonProperty("recurrence")]
        public string Recurrence { get; set; }
        [JsonProperty("ended_at")]
        public string EndedAt { get; set; }
    }
}