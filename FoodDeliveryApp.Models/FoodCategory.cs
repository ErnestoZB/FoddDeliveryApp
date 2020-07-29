using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FoodDeliveryApp.Models
{
    public class FoodCategory
    {
        public int FoodCategoryId { get; set; }

        [Required]
        public string Type { get; set; }

        public IList<Restaurant> Restaurants { get; set; }
    }
}
