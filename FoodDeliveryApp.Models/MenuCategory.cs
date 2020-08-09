using System.Collections.Generic;

namespace FoodDeliveryApp.Models
{
    public class MenuCategory
    {
        public string Name { get; set; }

        public List<Dish> Dishes { get; set; }
    }
}