using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Text;

namespace FoodDeliveryApp.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [Required]
        public double Total { get; set; }

        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }

        public IList<OrderDish> OrderDishes { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}