using System.Collections.Generic;

namespace Komis.Models
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllCars();
        Car GetOneCarById(int carId);
    }
}
