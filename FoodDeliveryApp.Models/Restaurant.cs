using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDeliveryApp.Models
{
    public class Restaurant : BaseModel
    {
        private string _name;
        public string Name 
        {
            get => _name;
            set => SetValue(ref _name, value);
        }

        private string _image;
        public string Image
        { 
            get => _image;
            set => SetValue(ref _image, value);
        }

        private int _minDeliveryTime;
        public int MinDeliveryTime
        {
            get => _minDeliveryTime;
            set => SetValue(ref _minDeliveryTime, value);
        }

        private int _maxDeliveryTime;
        public int MaxDeliveryTime 
        {
            get => _maxDeliveryTime;
            set => SetValue(ref _maxDeliveryTime, value);
        }

        private double _shippingPrice;
        public double ShippingPrice 
        {
            get => _shippingPrice;
            set => SetValue(ref _shippingPrice, value); 
        }

        private string _address;
        public string Address 
        {
            get => _address;
            set => SetValue(ref _address, value);
        }

        private Score _score;
        public Score Score 
        {
            get => _score;
            set => SetValue(ref _score, value);
        }

        private bool _isFavorite;
        public bool IsFavorite
        {
            get => _isFavorite;
            set => SetValue(ref _isFavorite, value);
        }
    }
}