using FoodDeliveryApp.Db.Repositories.Contracts;
using FoodDeliveryApp.Models;
using FoodDeliveryApp.Web.Managers.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDeliveryApp.Web.Managers.Implementation
{
    public class MenuManager : IBaseManager<Menu>
    {
        private readonly IUnitOfWork _unitOfWork;

        public MenuManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Menu> GetAll()
        {
            return _unitOfWork.Menus.GetAll();
        }

        public Menu GetById(object id)
        {
            return _unitOfWork.Menus.GetById(id);
        }
    }
}
