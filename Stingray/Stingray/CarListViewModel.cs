using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Stingray
{
    public class CarListViewModel : BindableObject
    {
        private List<Car> _cars = new List<Car>();
        public List<Car> Cars
        {
            get
            {
                return _cars;
            }
            set
            {
                _cars = value;
                OnPropertyChanged();
            }
        }

        public CarListViewModel()
        {
            Cars = new List<Car>();
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

        public ICommand RefreshCommand
        {
            get
            {
                return new Command(async() =>
                {
                    await LoadCarsAsync();
                });
            }
        }

        public async Task LoadCarsAsync()
        {
            IsBusy = true;
            var service = new CarService();
            Cars = await service.LoadAllCars();
            IsBusy = false;
        }
     }
}
