using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Komis.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Cars.Any())
            {          
                context.AddRange(
                new Car { Mark = "Toyota", Model = "Corolla", ProductionDate = 2000, Mileage = "298000 km", EngineCapacity = "2000 cm3", FuelType = "Diesel", Power = "96", Price = 5000, ImageUrl = "", MiniImageUrl = "../images/corolla.jpg", IsCarOfTheWeek = true, CarDescription = "Opis 1" },
                new Car { Mark = "Bentley", Model = "Continental Flying Spur", ProductionDate = 2009, Mileage = "65000 km", EngineCapacity = "6000 cm3", FuelType = "Petrol", Power = "610", Price = 239000, ImageUrl = "", MiniImageUrl = "../images/bentley flying spur.jpg", IsCarOfTheWeek = false, CarDescription = "Opis 2" },
                new Car { Mark = "Warszawa", Model = "224", ProductionDate = 1970, Mileage = "42000 km", EngineCapacity = "2120 cm3", FuelType = "Petrol", Power = "70", Price = 39900, ImageUrl = "", MiniImageUrl = "../images/warszawa 224.jpg", IsCarOfTheWeek = false, CarDescription = "Opis 3" },
                new Car { Mark = "Maybach", Model = "57", ProductionDate = 2007, Mileage = "96000 km", EngineCapacity = "5998 cm3", FuelType = "Petrol", Power = "612", Price = 399000, ImageUrl = "", MiniImageUrl = "../images/maybach 57.jpg", IsCarOfTheWeek = false, CarDescription = "Opis 4" },
                new Car { Mark = "Ferrari", Model = "458 Italia", ProductionDate = 2012, Mileage = "20000 km", EngineCapacity = "4500 cm3", FuelType = "Petrol", Power = "570", Price = 714900, ImageUrl = "", MiniImageUrl = "../images/ferrari_458_italia.jpg", IsCarOfTheWeek = false, CarDescription = "Opis 5" },
                new Car { Mark = "Jaguar", Model = "XJ X351", ProductionDate = 2017, Mileage = "26985 km", EngineCapacity = "2993 cm3", FuelType = "Diesel", Power = "300", Price = 177000, ImageUrl = "", MiniImageUrl = "../images/jaguar xj x351.jpg", IsCarOfTheWeek = false, CarDescription = "Opis 6" }
                );
            }
            context.SaveChanges();
        }
    }
}
