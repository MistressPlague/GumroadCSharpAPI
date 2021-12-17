using Newtonsoft.Json;
using Plague.Gumroad;
using System;
using System.Linq;

namespace Gumroad_API
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Token.");

            var API = new GumroadAPI(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Initializing..");

            API.OnSaleNotification += (sales) => // Only Monitors Since Prev Day
            {
                Console.WriteLine("Sale Update! ->\n" + JsonConvert.SerializeObject(sales));
            };

            API.OnSubscriptionNotification += (product, subscriptions) =>
            {
                Console.WriteLine($"{product.Name} Subscription Update! ->\n" + JsonConvert.SerializeObject(subscriptions));
            };

            while (Console.ReadLine() is var line)
            {
                if (line != null)
                {
                    if (line.StartsWith("GetProducts"))
                    {
                        var response = API.gumroad.GetProductsAsync(API.token).Result;

                        Console.WriteLine(JsonConvert.SerializeObject(response.Products));
                    }
                    else if (line.StartsWith("GetProduct("))
                    {
                        var query = line.Replace("GetProduct(", "").Replace(")", "");

                        var response = API.gumroad.GetProductsAsync(API.token).Result;

                        Console.WriteLine(JsonConvert.SerializeObject(response.Products.FirstOrDefault(o => o.Name.Contains(query))));
                    }
                }
            }
        }
    }
}
