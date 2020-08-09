using FoodDeliveryApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodDeliveryApp.Db.Repositories.Implementation
{
    public class MenuRepository : BaseRepository<Menu>
    {
        public MenuRepository(DbContext context)
            : base(context)
        {
        }

        public override IEnumerable<Menu> GetAll()
        {
            return Entities.Include(m => m.Categories).ThenInclude(c => c.Dishes);
        }
    }
}