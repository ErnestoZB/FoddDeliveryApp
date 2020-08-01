using FoodDeliveryApp.Db.Repositories.Contracts;
using FoodDeliveryApp.Models;
using FoodDeliveryApp.Web.Managers.Contracts;
using System.Collections.Generic;

namespace FoodDeliveryApp.Web.Managers.Implementation
{
    public class RestaurantManager: IBaseManager<Restaurant>
    {
        private readonly IUnitOfWork _unitOfWork;

        public RestaurantManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _unitOfWork.Restaurants.GetAll();
        }

        public Restaurant GetById(object id)
        {
            return _unitOfWork.Restaurants.GetById(id);
        }
    }
}
