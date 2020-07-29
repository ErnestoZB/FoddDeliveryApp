using System;
using System.Collections.Generic;

namespace FoodDeliveryApp.Db.Repositories.Contracts
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();

        TEntity GetById(object id);

        void Delete(object id);

        void Delete(TEntity entityToDelete);

        bool AddNew(TEntity entity);

        bool Modify(TEntity entity);
    }
}
