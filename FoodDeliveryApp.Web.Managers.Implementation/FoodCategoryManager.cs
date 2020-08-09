using FoodDeliveryApp.Db.Repositories.Contracts;
using FoodDeliveryApp.Models;
using FoodDeliveryApp.Web.Managers.Contracts;
using System.Collections.Generic;

namespace FoodDeliveryApp.Web.Managers.Implementation
{
    public class FoodCategoryManager : IBaseManager<FoodCategory>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public FoodCategoryManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IEnumerable<FoodCategory> GetAll()
        {
            var entities = _unitOfWork.FoodCategories.GetAll();

            return _mapper.Map<IEnumerable<Entities.FoodCategory>, IEnumerable<FoodCategory>>(entities);
        }

        public FoodCategory GetById(object id)
        {
            var entity = _unitOfWork.FoodCategories.GetById(id);

            return _mapper.Map<Entities.FoodCategory, FoodCategory>(entity);
        }
    }
}
