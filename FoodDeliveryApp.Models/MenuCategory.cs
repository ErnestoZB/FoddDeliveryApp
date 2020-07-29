using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FoodDeliveryApp.Models
{
    public class MenuCategory
    {
        public int MenuCategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        public int MenuId { get; set; }
        public Menu Menu { get; set; }

        public List<Dish> Dishes { get; set; }
    }
}
