using System.Collections.Generic;

namespace FoodDeliveryApp.Web.Managers.Contracts
{
    public interface IBaseManager<T>
    {
        IEnumerable<T> GetAll();

        T GetById(object id);
    }
}