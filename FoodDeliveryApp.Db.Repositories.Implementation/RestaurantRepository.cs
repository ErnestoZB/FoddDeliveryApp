using FoodDeliveryApp.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FoodDeliveryApp.Db.Repositories.Implementation
{
    public class RestaurantRepository : BaseRepository<Restaurant>
    {
        public RestaurantRepository(DbContext context)
            : base(context)
        {
        }

        public override IEnumerable<Restaurant> GetAll()
        {
            return Entities.Include(m => m.Score);
        }
    }
}