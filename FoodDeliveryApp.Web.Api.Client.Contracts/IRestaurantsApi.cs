using FoodDeliveryApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Web.Api.Client.Contracts
{
    public interface IRestaurantsApi
    {
        Task<IEnumerable<Restaurant>> GetRestaurants();
    }
}
