using FoodDeliveryApp.Models;
using FoodDeliveryApp.Web.Api.Client.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Web.Api.Client.Implementation
{
    public class FoodDeliveryApiClient : BaseApiClient, IFoodCategoriesApi, IRestaurantsApi
    {
        private static string ApiHost = "https://192.168.1.72:44354/";

        public FoodDeliveryApiClient() : base(ApiHost)
        {
        }

        public async Task<IEnumerable<FoodCategory>> GetFoodCategories()
        {
            var requestUri = $"api/foodcategories";

            return await GetItem<IEnumerable<FoodCategory>>(requestUri);
        }

        public async Task<IEnumerable<Restaurant>> GetRestaurants()
        {
            var requestUri = $"api/restaurants";

            return await GetItem<IEnumerable<Restaurant>>(requestUri);
        }
    }
}
