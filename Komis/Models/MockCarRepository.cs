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
                new Car{CarId = 1, Mark="Toyota", Model="Corolla", ProductionDate=2000, Mileage="298000 km", EngineCapacity="2000 cm3", FuelType="Diesel", Power="96", Price=5000, ImageUrl="", MiniImageUrl="", IsCarOfTheWeek=true, CarDescription="Opis 1"},
                new Car{CarId = 2, Mark="Bentley", Model="Continental Flying Spur", ProductionDate=2009, Mileage="65000 km", EngineCapacity="6000 cm3", FuelType="Petrol", Power="610", Price=239000, ImageUrl="", MiniImageUrl="", IsCarOfTheWeek=false, CarDescription="Opis 2"},
                new Car{CarId = 3, Mark="Warszawa", Model="224", ProductionDate=1970, Mileage="42000 km", EngineCapacity="2120 cm3", FuelType="Petrol", Power="70", Price=39900, ImageUrl="", MiniImageUrl="", IsCarOfTheWeek=false, CarDescription="Opis 3"},
                new Car{CarId = 4, Mark="Maybach", Model="57", ProductionDate=2007, Mileage="96000 km", EngineCapacity="5998 cm3", FuelType="Petrol", Power="612", Price=399000, ImageUrl="", MiniImageUrl="", IsCarOfTheWeek=false, CarDescription="Opis 4"},
                new Car{CarId = 5, Mark="Ferrari", Model="458 Italia", ProductionDate=2012, Mileage="20000 km", EngineCapacity="4500 cm3", FuelType="Petrol", Power="570", Price=714900, ImageUrl="", MiniImageUrl="", IsCarOfTheWeek=false, CarDescription="Opis 5"},
                new Car{CarId = 6, Mark="Jaguar", Model="XJ X351", ProductionDate=2017, Mileage="26985 km", EngineCapacity="2993 cm3", FuelType="Diesel", Power="300", Price=177000, ImageUrl="", MiniImageUrl="", IsCarOfTheWeek=false, CarDescription="Opis 6"}
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
