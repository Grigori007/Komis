using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Komis.Models
{
    public class CarRepository : ICarRepository
    {
        private readonly AppDbContext _appDbContext;

        public CarRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Car> GetAllCars()
        {
            return _appDbContext.Cars;
        }

        public Car GetOneCarById(int carId)
        {
            return _appDbContext.Cars.FirstOrDefault(s => s.CarId == carId);
        }
    }
}
