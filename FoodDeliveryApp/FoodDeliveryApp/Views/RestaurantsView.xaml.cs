using FoodDeliveryApp.Models;
using FoodDeliveryApp.ViewModels;
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

        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            var searchBar = (SearchBar) sender;

            ((RestaurantsViewModel) BindingContext).SearchCommand.Execute(searchBar.Text);
        }
    }
}