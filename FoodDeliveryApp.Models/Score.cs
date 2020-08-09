using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDeliveryApp.Models
{
    public class Score : BaseModel
    {
        private int _count;
        public int Count 
        { 
            get => _count;
            set => SetValue(ref _count, value);
        }

        private double _average;
        public double Average 
        {
            get => _average;
            set => SetValue(ref _average, value);
        }
    }
}
