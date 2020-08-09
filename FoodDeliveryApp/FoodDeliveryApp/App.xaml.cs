using Prism;
using Prism.Ioc;
using FoodDeliveryApp.ViewModels;
using FoodDeliveryApp.Views;
using Xamarin.Essentials.Interfaces;
using Xamarin.Essentials.Implementation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FoodDeliveryApp.Web.Api.Client.Contracts;
using FoodDeliveryApp.Web.Api.Client.Implementation;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace FoodDeliveryApp
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/RestaurantsView");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<RestaurantsView, RestaurantsViewModel>();

            containerRegistry.Register<IRestaurantsApi, FoodDeliveryApiClient>();
            containerRegistry.Register<IFoodCategoriesApi, FoodDeliveryApiClient>();
        }
    }
}
