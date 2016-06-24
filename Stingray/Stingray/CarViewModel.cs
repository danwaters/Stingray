using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Stingray
{
    public class CarViewModel : BindableObject
    {
        private Car _car = new Car();
        public Car Car
        {
            get { return _car; }
            set
            {
                _car = value;
                OnPropertyChanged();
            }
        }

        bool _isBusy;
        public bool IsBusy
        {
            get
            { return _isBusy; }
            set
            {
                _isBusy = value;
                OnPropertyChanged();
            }
        }

        public ICommand SubmitCarCommand
        {
            get
            {
                return new Command(async() => {

                    using(new Busy(this))
                    {
                        var service = new CarService();
                        await service.AddCar(this.Car);
                    }
                } );
            }
        }
    }

    public class Busy : IDisposable
    {
        readonly CarViewModel _viewModel;
        public Busy(CarViewModel viewModel)
        {
            _viewModel = viewModel;
            _viewModel.IsBusy = true;
        }

        public void Dispose()
        {
            _viewModel.IsBusy = false;
        }
    }

}
