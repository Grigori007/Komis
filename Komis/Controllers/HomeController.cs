using Komis.Models;
using Komis.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Komis.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarRepository _carRepository;

        public HomeController(ICarRepository carRepository)
        {
            // _carRepository = new MockCarRepository(); -> gdybysmy nie uzywali depedncy injection to tak trzeba by bylo napisac. DI robi to za nas
            // w tym kontrolerze przekazywany jest interfejs ICarRepository. DI automatycznie wstrzykuje tu jego instancje (wstrzykniece konstruktora)
            _carRepository = carRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            // viewBag jest dynamiczny 
            var cars = _carRepository.GetAllCars().OrderBy(s => s.Mark);
            // model homeVM gromadzi w sobie wszystkie dane, ktore ma wyrenderowac widok Index
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
                return NotFound(); // error 404
            }

            return View(car);
        }
    }
}
