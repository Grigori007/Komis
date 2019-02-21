using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Komis.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string Mark  { get; set; }
        public string Model { get; set; }
        public int ProductionDate  { get; set; }
        public string Mileage { get; set; }
        public string EngineCapacity  { get; set; }
        public string FuelType { get; set; }
        public string Power { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string MiniImageUrl { get; set; }
        public bool IsCarOfTheWeek { get; set; }
    }


}
