using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FoodDeliveryApp.Entities
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public int MinDeliveryTime { get; set; }

        [Required]
        public int MaxDeliveryTime { get; set; }

        [Required]
        public double ShippingPrice { get; set; }

        [Required]
        public string Address { get; set; }

        public Menu Menu { get; set; }

        public Score Score {get; set; }

        public int FoodCategoryId { get; set; }

        public FoodCategory FoodCategory { get; set; }

        public IList<RestaurantUser> Users { get; set; }

        public IList<Order> Orders { get; set; }
    }
}
