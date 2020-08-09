using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FoodDeliveryApp.Entities
{
    public class Score
    {
        public int ScoreId { get; set; }

        [Required]
        public int Count { get; set; }

        [Required]
        public double Average { get; set; }

        public int RestaurantId { get; set; }
        public Restaurant Restaurant {get; set; }
    }
}
