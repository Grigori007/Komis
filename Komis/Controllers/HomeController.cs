using Komis.Models;
using Komis.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Komis.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarRepository _carRepository;

        public HomeController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        { 
            var cars = _carRepository.GetAllCars().OrderBy(s => s.Mark);
            
            var homeVM = new HomeViewModel()
            {
                Title = "Car review",
                CarList = cars.ToList()
            };

            return View(homeVM);
        }

        // GET: 
        public IActionResult Details(int id)
        {
            var car = _carRepository.GetOneCarById(id);

            if (car == null)
            {
                return NotFound(); 
            }

            return View(car);
        }
    }
}
