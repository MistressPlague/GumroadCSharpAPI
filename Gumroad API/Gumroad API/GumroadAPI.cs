using RestEase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using Newtonsoft.Json;

namespace Plague.Gumroad
{
    internal class GumroadAPI
    {
        public readonly string token;

        public event Action<GumroadProduct, GumroadSubscriber[]> OnSubscriptionNotification;
        public event Action<GumroadSale[]> OnSaleNotification;

        public GumroadAPI(string accessToken, double MonitorInterval = 20000)
        {
            token = accessToken;

            gumroad = RestClient.For<IGumroadApi>(GumroadConstants.ApiUrl);

            var timer = new Timer
            {
                Interval = MonitorInterval
            };

            timer.Elapsed += TimerTick;
            timer.Enabled = true;
            timer.Start();
        }

        private IReadOnlyList<GumroadSale> LastSaleResponse;
        private Dictionary<string, GumroadSubscriber[]> LastSubscriptionsResponse = new Dictionary<string, GumroadSubscriber[]>();
        private async void TimerTick(object sender, ElapsedEventArgs e)
        {
            #region Sales Monitor
            var Sales = (await gumroad.GetSalesAsync(token, new GetSalesParams() { Page = 1, After = DateTime.Now.AddDays(-1) })).Sales;

            if (LastSaleResponse != null)
            {
                var NewSales = Sales.Where(o => LastSaleResponse.All(p => JsonConvert.SerializeObject(p) != JsonConvert.SerializeObject(o))).ToArray();

                if (NewSales.Length > 0)
                {
                    OnSaleNotification?.Invoke(NewSales);
                }
            }

            LastSaleResponse = Sales;
            #endregion

            #region Subscriptions Monitor
            var Products = (await gumroad.GetProductsAsync(token)).Products;

            foreach (var product in Products)
            {
                var Subscriptions = (await product.GetSubscriptionsAsync(token)).Subscribers;

                if (Subscriptions != null && Subscriptions.Length > 0)
                {
                    if (LastSubscriptionsResponse.ContainsKey(product.ID))
                    {
                        var NewSubscriptions = Subscriptions.Where(o => LastSubscriptionsResponse[product.ID].All(p => JsonConvert.SerializeObject(p) != JsonConvert.SerializeObject(o))).ToArray();

                        if (NewSubscriptions.Length > 0)
                        {
                            OnSubscriptionNotification?.Invoke(product, NewSubscriptions);
                        }
                    }

                    LastSubscriptionsResponse[product.ID] = Subscriptions;
                }
            }
            #endregion
        }

        //One At A Time! Static For Global Access!
        internal static IGumroadApi gumroadInstance;

        internal IGumroadApi gumroad
        {
            get => gumroadInstance;
            set => gumroadInstance = value;
        }
    }
}