using Xamarin.Forms;
using Stingray.ViewModels;

namespace Stingray
{
    public partial class CreateCarPage : ContentPage
    {
        CarViewModel viewModel = new CarViewModel();

        public CreateCarPage()
        {
            BindingContext = viewModel;
            InitializeComponent();
        }
    }
}
