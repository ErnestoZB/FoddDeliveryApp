using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDeliveryApp.Models
{
    public class RestaurantUser
    {
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
