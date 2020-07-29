using FoodDeliveryApp.Db.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodDeliveryApp.Db.Repositories.Implementation
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly Microsoft.EntityFrameworkCore.DbContext Context;
        protected readonly DbSet<TEntity> Entities;

        public BaseRepository(Microsoft.EntityFrameworkCore.DbContext context)
        {
            Context = context;
            Entities = Context.Set<TEntity>();
        }

        public bool AddNew(TEntity entity)
        {
            try
            {
                Entities.Add(entity);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public virtual void Delete(object id)
        {
            TEntity entityToDelete = Entities.Find(id);

            Delete(entityToDelete);
        }

        public virtual void Delete(TEntity entityToDelete)
        {
            if (Context.Entry(entityToDelete).State == EntityState.Detached)
            {
                Entities.Attach(entityToDelete);
            }

            Entities.Remove(entityToDelete);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Entities.ToList<TEntity>();
        }

        public TEntity GetById(object id)
        {
            return Entities.Find(id);
        }

        public bool Modify(TEntity entity)
        {
            try
            {
                Entities.Attach(entity);

                Context.Entry(entity).State = EntityState.Modified;

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
