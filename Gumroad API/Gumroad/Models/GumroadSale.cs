using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Plague.Gumroad
{
    public class GumroadSale
    {
        [JsonProperty("id")]
        public string ID { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("seller_id")]
        public string SellerID { get; set; }
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
        [JsonProperty("daystamp")]
        public string Daystamp { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("product_name")]
        public string ProductName { get; set; }
        [JsonProperty("product_has_variants")]
        public bool ProductHasVariants { get; set; }
        [JsonProperty("price")]
        public double Price { get; set; }
        [JsonProperty("gumroad_fee")]
        public double GumroadFee { get; set; }
        [JsonProperty("subscription_duration")]
        public string SubscriptionDuration { get; set; }
        [JsonProperty("formatted_display_price")]
        public string FormattedDisplayPrice { get; set; }
        [JsonProperty("formatted_total_price")]
        public string FormattedTotalPrice { get; set; }
        [JsonProperty("currency_symbol")]
        public string CurrencySymbol { get; set; }
        [JsonProperty("amount_refundable_in_currency")]
        public string AmountRefundableInCurrency { get; set; }
        [JsonProperty("product_id")]
        public string ProductID { get; set; }
        [JsonProperty("product_permalink")]
        public string ProductPermalink { get; set; }
        [JsonProperty("partially_refunded")]
        public bool IsPartiallyRefunded { get; set; }
        [JsonProperty("chargedback")]
        public bool IsChargedBack { get; set; }
        [JsonProperty("purchase_email")]
        public string PurchaseEmail { get; set; }
        [JsonProperty("full_name")]
        public string FullName { get; set; }
        [JsonProperty("paid")]
        public bool IsPaid { get; set; }
        [JsonProperty("has_variants")]
        public bool HasVariants { get; set; }
        [JsonProperty("variants")]
        public GumroadSaleVariant Variants { get; set; }
        [JsonProperty("variants_and_quantity")]
        public string VariantsAndQuantity { get; set; }
        [JsonProperty("has_custom_fields")]
        public bool HasCustomFields { get; set; }
        [JsonProperty("custom_fields")]
        public Dictionary<string, string> CustomFields { get; set; }
        [JsonProperty("order_id")]
        public string OrderID { get; set; }
        [JsonProperty("is_product_physical")]
        public bool IsProductPhysical { get; set; }
        [JsonProperty("purchaser_id")]
        public ulong PurchaserID { get; set; }
        [JsonProperty("is_recurring_billing")]
        public bool IsRecurringBilling { get; set; }
        [JsonProperty("can_contact")]
        public bool CanContact { get; set; }
        [JsonProperty("is_following")]
        public bool IsFollowing { get; set; }
        [JsonProperty("disputed")]
        public bool IsDisputed { get; set; }
        [JsonProperty("dispute_won")]
        public bool IsDisputeWon { get; set; }
        [JsonProperty("is_additional_contribution")]
        public bool IsAdditionalContribution { get; set; }
        [JsonProperty("discover_fee_charged")]
        public bool IsDiscoverFeeCharged { get; set; }
        [JsonProperty("is_gift_sender_purchase")]
        public bool IsGiftSenderPurchase { get; set; }
        [JsonProperty("is_gift_receiver_purchase")]
        public bool IsGiftReceiverPurchase { get; set; }
        [JsonProperty("referrer")]
        public string Referrer { get; set; }
        [JsonProperty("product_rating")]
        public string ProductRating { get; set; }
        [JsonProperty("reviews_count")]
        public int ReviewsCount { get; set; }
        [JsonProperty("average_rating")]
        public double AverageRating { get; set; }
        [JsonProperty("subscription_id")]
        public string SubscriptionID { get; set; }
        [JsonProperty("cancelled")]
        public bool IsCancelled { get; set; }
        [JsonProperty("ended")]
        public bool IsEnded { get; set; }
        [JsonProperty("recurring_charge")]
        public bool IsRecurringCharge { get; set; }
        [JsonProperty("license_key")]
        public string LicenseKey { get; set; }
        [JsonProperty("license_id")]
        public string LicenseID { get; set; }
        [JsonProperty("license_disabled")]
        public bool IsLicenseDisabled { get; set; }
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }
}
