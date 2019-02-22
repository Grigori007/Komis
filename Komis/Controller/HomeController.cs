using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Komis.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Komis.Controller
{
    public class HomeController : ControllerBase
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
            return View();
        }
    }
}
