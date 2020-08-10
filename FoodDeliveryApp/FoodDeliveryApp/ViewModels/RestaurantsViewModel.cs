using FoodDeliveryApp.Models;
using FoodDeliveryApp.Web.Api.Client.Contracts;
using Prism.Navigation;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace FoodDeliveryApp.ViewModels
{
    public class RestaurantsViewModel : ViewModelBase
    {
        private const int MinQueryChars = 2;

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

        private IEnumerable<Restaurant> _filterRestaurants;
        public IEnumerable<Restaurant> FilterRestaurants
        {
            get { return _filterRestaurants; }
            set { SetProperty(ref _filterRestaurants, value); }
        }

        public ICommand SearchCommand { get; }

        private readonly IRestaurantsApi _restaurantsApi;
        private readonly IFoodCategoriesApi _categoriesApi;

        public RestaurantsViewModel(INavigationService navigationService, IRestaurantsApi restaurantsApi, IFoodCategoriesApi categoriesApi)
            : base(navigationService)
        {
            _restaurantsApi = restaurantsApi;
            _categoriesApi = categoriesApi;

            SearchCommand = new Command<string>(query => SearchRestaurants(query));
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
            FilterRestaurants = Restaurants = await _restaurantsApi.GetRestaurants();
        }

        private void SearchRestaurants(string query)
        {
            if (query.Length < MinQueryChars)
            {
                FilterRestaurants = Restaurants;
                return;
            }

            FilterRestaurants = Restaurants.Where(r => r.Name.ToLowerInvariant().Contains(query.ToLowerInvariant()));
        }
    }
}