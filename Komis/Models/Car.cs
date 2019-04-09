using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Komis.Models
{
    public class Car
    {
        [BindNever]
        public int CarId { get; set; }

        [Required(ErrorMessage = "Username is required!")]
        [StringLength(100, ErrorMessage = "Username is too long!")]
        public string Mark  { get; set; }

        [Required(ErrorMessage = "Username is required!")]
        [StringLength(100, ErrorMessage = "Username is too long!")]
        public string Model { get; set; }

        [Required]
        public int ProductionDate  { get; set; }

        [Required(ErrorMessage = "Mileage is required!")]
        [StringLength(10, ErrorMessage = "Mileage value is too long!")]
        public string Mileage { get; set; }

        [Required(ErrorMessage = "Engine capacity is required!")]
        [StringLength(10, ErrorMessage = "Capacity value is too long!")]
        public string EngineCapacity  { get; set; }

        [Required(ErrorMessage = "Fuel type is required!")]
        [StringLength(10, ErrorMessage = "Name of fuel type is too long!")]
        public string FuelType { get; set; }

        [Required(ErrorMessage = "Power value is required!")]
        [StringLength(10, ErrorMessage = "Power value is too long!")]
        public string Power { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        // [Required(ErrorMessage = "URL is required!")]
        // [StringLength(200, ErrorMessage = "URL is too long!")]
        public string ImageUrl { get; set; }

        // [Required(ErrorMessage = "URL is required!")]
        // [StringLength(200, ErrorMessage = "URL is too long!")]
        public string MiniImageUrl { get; set; }

        // [Required]
        public bool IsCarOfTheWeek { get; set; }

        [Required(ErrorMessage = "Car description is required!")]
        [StringLength(1000, ErrorMessage = "Car description is too long!")]
        public string CarDescription { get; set; }

        // [Required]
        public bool IsInHQ { get; set; }
    }


}
