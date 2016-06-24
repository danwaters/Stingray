using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

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
