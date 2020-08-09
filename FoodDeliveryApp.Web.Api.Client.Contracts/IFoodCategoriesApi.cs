using FoodDeliveryApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Web.Api.Client.Contracts
{
    public interface IFoodCategoriesApi
    {
        Task<IEnumerable<FoodCategory>> GetFoodCategories();
    }
}
