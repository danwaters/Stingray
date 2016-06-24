using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Stingray
{
    public partial class CreateCarPage : ContentPage
    {
        CarViewModel _viewModel = new CarViewModel();

        public CreateCarPage()
        {
            BindingContext = _viewModel;
            InitializeComponent();
        }
    }
}
