using System.Threading.Tasks;
using RestEase;

namespace Plague.Gumroad
{
    internal static class GumroadExtensions
    {
        internal static async Task<GetSubscriptionsResponse> GetSubscriptionsAsync(this GumroadProduct product, string token)
        {
            return await GumroadAPI.gumroadInstance.GetSubscriptionsAsync(token, product.ID);
        }
    }
}