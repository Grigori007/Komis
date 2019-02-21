using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Komis.Models
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllCars();
        Car GetOneCarById(int carId);
    }
}
