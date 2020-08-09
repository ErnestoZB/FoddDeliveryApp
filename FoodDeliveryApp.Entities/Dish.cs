using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace FoodDeliveryApp.Entities
{
    public class Dish
    {
        public int DishId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Image { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }

        public int MenuCategoryId { get; set; }
        public MenuCategory MenuCategory { get; set; }

        public IList<OrderDish> OrderDishes { get; set; }
    }
}
