using Newtonsoft.Json;

namespace Plague.Gumroad
{
    public class GumroadProduct
    {
        [JsonProperty("custom_permalink")]
        public string CustomPermalink { get; set; }
        [JsonProperty("custom_receipt")]
        public string CustomReceipt { get; set; }
        [JsonProperty("custom_summary")]
        public string CustomSummary { get; set; }
        [JsonProperty("custom_fields")]
        public object CustomFields { get; set; }
        [JsonProperty("customizable_price")]
        public string CustomizablePrice { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("deleted")]
        public bool IsDeleted { get; set; }
        [JsonProperty("max_purchase_count")]
        public int? MaxPurchaseCount { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("preview_url")]
        public string PreviewUrl { get; set; }
        [JsonProperty("require_shipping")]
        public bool RequireShipping { get; set; }
        [JsonProperty("subscription_duration")]
        public string SubscriptionDuration { get; set; }
        [JsonProperty("published")]
        public bool IsPublished { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("id")]
        public string ID { get; set; }
        [JsonProperty("price")]
        public float Price { get; set; }
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [JsonProperty("short_url")]
        public string ShortUrl { get; set; }
        [JsonProperty("formatted_price")]
        public string FormattedPrice { get; set; }
        [JsonProperty("file_info")]
        public object FileInfo { get; set; }
        [JsonProperty("shown_on_profile")]
        public bool IsShownOnProfile { get; set; }

        // Only with `view_sales` scope
        [JsonProperty("sales_count")]
        public string SalesCount { get; set; }
        [JsonProperty("sales_usd_cents")]
        public string SalesUsdCents { get; set; }
    }
}
