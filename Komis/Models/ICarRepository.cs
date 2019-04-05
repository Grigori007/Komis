using System.Collections.Generic;

namespace Komis.Models
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllCars();
        Car GetOneCarById(int carId);
        void AddCar(Car car);
        void EditCar(Car car);
        void DeleteCar(Car car);
    }
}
