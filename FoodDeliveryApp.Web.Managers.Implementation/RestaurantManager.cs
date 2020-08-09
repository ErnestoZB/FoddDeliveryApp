using FoodDeliveryApp.Db.Repositories.Contracts;
using FoodDeliveryApp.Models;
using FoodDeliveryApp.Web.Managers.Contracts;
using System.Collections.Generic;

namespace FoodDeliveryApp.Web.Managers.Implementation
{
    public class RestaurantManager: IBaseManager<Restaurant>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RestaurantManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IEnumerable<Restaurant> GetAll()
        {
            var entities = _unitOfWork.Restaurants.GetAll();

            return _mapper.Map<IEnumerable<Entities.Restaurant>, IEnumerable<Restaurant>>(entities);
        }

        public Restaurant GetById(object id)
        {
            var entity = _unitOfWork.Restaurants.GetById(id);

            return _mapper.Map<Entities.Restaurant, Restaurant>(entity);
        }
    }
}
