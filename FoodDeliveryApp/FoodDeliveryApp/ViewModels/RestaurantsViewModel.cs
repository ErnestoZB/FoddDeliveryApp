using FoodDeliveryApp.Models;
using FoodDeliveryApp.Web.Api.Client.Contracts;
using Prism.Navigation;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodDeliveryApp.ViewModels
{
    public class RestaurantsViewModel : ViewModelBase
    {
        private IEnumerable<FoodCategory> _categories;
        public IEnumerable<FoodCategory> Categories
        {
            get { return _categories; }
            set { SetProperty(ref _categories, value); }
        }

        private IEnumerable<Restaurant> _restaurants;
        public IEnumerable<Restaurant> Restaurants
        {
            get { return _restaurants; }
            set { SetProperty(ref _restaurants, value); }
        }

        private readonly IRestaurantsApi _restaurantsApi;
        private readonly IFoodCategoriesApi _categoriesApi;

        public RestaurantsViewModel(INavigationService navigationService, IRestaurantsApi restaurantsApi, IFoodCategoriesApi categoriesApi)
            : base(navigationService)
        {
            _restaurantsApi = restaurantsApi;
            _categoriesApi = categoriesApi;
        }

        public override void Initialize(INavigationParameters parameters)
        {
            base.Initialize(parameters);

            InitializeCategories();

            InitializeRestaurants();
        }

        private async Task InitializeCategories()
        {
            Categories = await _categoriesApi.GetFoodCategories();
        }

        private async Task InitializeRestaurants()
        {
            Restaurants = await _restaurantsApi.GetRestaurants();
        }
    }
}