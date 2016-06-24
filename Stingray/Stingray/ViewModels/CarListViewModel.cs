using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Stingray.ViewModels
{
    public class CarListViewModel : BaseViewModel
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

        public async Task LoadCarsAsync()
        {
            using (new Busy(this))
            {
                var service = new CarService();
                Cars = await service.LoadAllCars();
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
     }
}
