using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
                new Car{CarId = 1, Mark="Toyota", Model="Corolla", ProductionDate=2001, Mileage="", EngineCapacity="2.1", FuelType="Diesel", Power="141", Price=5999, ImageUrl="", MiniImageUrl="", IsCarOfTheWeek=false},
                new Car{CarId = 2, Mark="Renault", Model="Espace", ProductionDate=2009, Mileage="", EngineCapacity="", FuelType="", Power="", Price=, ImageUrl="", MiniImageUrl="", IsCarOfTheWeek=false},
                new Car{CarId = 3, Mark="", Model="", ProductionDate=2000, Mileage="", EngineCapacity="", FuelType="", Power="", Price=40000, ImageUrl="", MiniImageUrl="", IsCarOfTheWeek=false},
                new Car{CarId = 4, Mark="", Model="", ProductionDate=2000, Mileage="", EngineCapacity="", FuelType="", Power="", Price=40000, ImageUrl="", MiniImageUrl="", IsCarOfTheWeek=false},
                new Car{CarId = 5, Mark="", Model="", ProductionDate=2000, Mileage="", EngineCapacity="", FuelType="", Power="", Price=40000, ImageUrl="", MiniImageUrl="", IsCarOfTheWeek=false},
                new Car{CarId = 6, Mark="", Model="", ProductionDate=2000, Mileage="", EngineCapacity="", FuelType="", Power="", Price=40000, ImageUrl="", MiniImageUrl="", IsCarOfTheWeek=false},

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
