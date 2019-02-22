using System.Collections.Generic;
using System.Linq;

namespace Komis.Models
{
    // Mock -> wersja probna do testowania
    public class MockCarRepository : ICarRepository
    {
        private List<Car> _carsList;

        public MockCarRepository()
        {
            if (_carsList == null)
            {
                LoadCarsToList();
            }

        }

        private void LoadCarsToList()
        {
            _carsList = new List<Car>
            {
                new Car{CarId = 1, Mark="Toyota", Model="Corolla", ProductionDate=2000, Mileage="298000", EngineCapacity="1400", FuelType="Petrol", Power="80", Price=2850, ImageUrl="", MiniImageUrl="", IsCarOfTheWeek=true},
                new Car{CarId = 2, Mark="Renault", Model="Espace", ProductionDate=2009, Mileage="", EngineCapacity="", FuelType="", Power="", Price=, ImageUrl="", MiniImageUrl="", IsCarOfTheWeek=false},
                new Car{CarId = 3, Mark="Warszawa", Model="224", ProductionDate=1970, Mileage="42000", EngineCapacity="2120", FuelType="Petrol", Power="70", Price=39900, ImageUrl="", MiniImageUrl="", IsCarOfTheWeek=false},
                new Car{CarId = 4, Mark="Maybach", Model="57", ProductionDate=2007, Mileage="96000", EngineCapacity="5998", FuelType="Petrol", Power="612", Price=399000, ImageUrl="", MiniImageUrl="", IsCarOfTheWeek=false},
                new Car{CarId = 5, Mark="Ferrari", Model="458 Italia", ProductionDate=2012, Mileage="20000", EngineCapacity="4500", FuelType="Petrol", Power="570", Price=714900, ImageUrl="", MiniImageUrl="", IsCarOfTheWeek=false},
                new Car{CarId = 6, Mark="Jaguar", Model="XJ X351", ProductionDate=2017, Mileage="26985", EngineCapacity="2993", FuelType="Diesel", Power="300", Price=177000, ImageUrl="", MiniImageUrl="", IsCarOfTheWeek=false},

            };
        }

        public IEnumerable<Car> GetAllCars()
        {
            return _carsList;
        }

        public Car GetOneCarById(int carId)
        {
            return _carsList.FirstOrDefault(s => s.CarId == carId);
        }
    }
}
