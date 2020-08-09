using FoodDeliveryApp.Db.Repositories.Contracts;
using FoodDeliveryApp.Models;
using FoodDeliveryApp.Web.Managers.Contracts;
using System.Collections.Generic;

namespace FoodDeliveryApp.Web.Managers.Implementation
{
    public class MenuManager : IBaseManager<Menu>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MenuManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IEnumerable<Menu> GetAll()
        {
            var menuEntities = _unitOfWork.Menus.GetAll();

            return _mapper.Map<IEnumerable<Entities.Menu>, IEnumerable<Menu>>(menuEntities);
        }

        public Menu GetById(object id)
        {
            var menuEntity = _unitOfWork.Menus.GetById(id);

            return _mapper.Map<Entities.Menu, Menu>(menuEntity);
        }
    }
}
