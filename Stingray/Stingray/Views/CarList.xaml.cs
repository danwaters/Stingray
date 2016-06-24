using Xamarin.Forms;
using Stingray.ViewModels;

namespace Stingray
{
    public partial class CarList : ContentPage
    {
        public CarList()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var viewModel = new CarListViewModel();
            await viewModel.LoadCarsAsync();
            BindingContext = viewModel; 
        }
    }
}
