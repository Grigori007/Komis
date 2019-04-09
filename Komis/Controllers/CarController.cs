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
                return RedirectToAction("Index");
            } else
            {
                return View(car);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var car = carRepository.GetOneCarById(id);

            if (car == null)
            {
                return NotFound();
            }
            else
            {
                return View(car);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Car car)
        {
            if (ModelState.IsValid)
            {
                carRepository.EditCar(car);
                return RedirectToAction("Index");
            }
            else
            {
                return View(car);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var car = carRepository.GetOneCarById(id);

            if(car == null)
            {
                return NotFound();
            } else
            {
                return View(car);
            }
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var car = carRepository.GetOneCarById(id);
            carRepository.DeleteCar(car);

            return RedirectToAction("Index");
        }

    }
}
