using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Komis.Models
{
    public class CarRepository : ICarRepository
    {
        private readonly AppDbContext appDbContext;

        public CarRepository(AppDbContext _appDbContext)
        {
            appDbContext = _appDbContext;
        }

        public void AddCar(Car car)
        {
            appDbContext.Cars.Add(car);
            appDbContext.SaveChanges();
        }

        public void DeleteCar(Car car)
        {
            appDbContext.Cars.Remove(car);
            appDbContext.SaveChanges();
        }

        public void EditCar(Car car)
        {
            appDbContext.Cars.Update(car);
            appDbContext.SaveChanges();
        }

        public IEnumerable<Car> GetAllCars()
        {
            return appDbContext.Cars;
        }

        public Car GetOneCarById(int carId)
        {
            return appDbContext.Cars.FirstOrDefault(s => s.CarId == carId);
        }
    }
}
