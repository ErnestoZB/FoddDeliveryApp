using FoodDeliveryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FoodDeliveryApp.Views
{
    public partial class RestaurantsView : ContentPage
    {
        public RestaurantsView()
        {
            InitializeComponent();
        }

        private void OnFavoriteTapped(object sender, EventArgs e)
        {
            var args = (TappedEventArgs) e;

            var restaurant = (Restaurant) args.Parameter;

            restaurant.IsFavorite = !restaurant.IsFavorite;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }
    }
}