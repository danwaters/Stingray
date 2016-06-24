using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.WindowsAzure.MobileServices;

namespace Stingray
{
    public class CarService
    {
        private MobileServiceClient _client;

        public CarService()
        {
            _client = new MobileServiceClient("https://gm-devday.azurewebsites.net");
        }

        public async Task AddCar(Car car)
        {
            var table = _client.GetTable<Car>();
            await table.InsertAsync(car);
            await Task.Delay(3000);
        }

        public async Task<List<Car>> LoadAllCars()
        {
            var table = _client.GetTable<Car>();
            return await table.OrderBy(c => c.Make).ToListAsync();
        }
    }
}
