using System.Windows.Input;
using Xamarin.Forms;

namespace Stingray.ViewModels
{
    public class CarViewModel : BaseViewModel
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
                });
            }
        }
    }
}
