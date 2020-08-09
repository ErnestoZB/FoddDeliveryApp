namespace FoodDeliveryApp.Models
{
    public class FoodCategory : BaseModel
    {
        private string _name;
        public string Name 
        {
            get => _name;
            set => SetValue(ref _name, value);
        }

        private string _icon;
        public string Icon 
        {
            get => _icon;
            set => SetValue(ref _icon, value);
        }
    }
}