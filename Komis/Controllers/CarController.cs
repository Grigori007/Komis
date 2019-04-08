using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Komis.Models;
using Komis.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Komis.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarRepository carRepository;

        public CarController(ICarRepository _carRepository)
        {
            carRepository = _carRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var cars = carRepository.GetAllCars().OrderBy(s => s.Mark);
            return View(cars);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var car = carRepository.GetOneCarById(id);
            if (car == null)
            {
                return NotFound();
            } else
            {
                return View(car);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Car car)
        {
            if (ModelState.IsValid)
            {
                carRepository.AddCar(car);
                return RedirectToAction("CarAdded");
            } else
            {
                return View(car);
            }
        }

        [HttpGet]
        public IActionResult CarAdded()
        {
            return View();
        }

    }
}
