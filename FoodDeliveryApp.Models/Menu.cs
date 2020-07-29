using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDeliveryApp.Models
{
    public class Menu
    {
        public int MenuId { get; set; }

        public List<MenuCategory> Categories { get; set; }

        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
