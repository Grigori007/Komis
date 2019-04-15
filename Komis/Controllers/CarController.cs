using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Komis.Models;
using Komis.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Komis.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarRepository carRepository;
        private IHostingEnvironment env;

        public CarController(ICarRepository _carRepository, IHostingEnvironment _env)
        {
            carRepository = _carRepository;
            env = _env;
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
            }
            else
            {
                return View(car);
            }
        }

        [HttpGet]
        public IActionResult Create(string fileName)
        {
            if (!string.IsNullOrEmpty(fileName))
            {
                ViewBag.ImgPath = "\\images\\" + fileName;
            }
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Car car)
        {
            if (ModelState.IsValid)
            {
                carRepository.AddCar(car);
                return RedirectToAction("Index");
            }
            else
            {
                return View(car);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id, string FileName)
        {
            var car = carRepository.GetOneCarById(id);

            if (car == null)
            {
                return NotFound();
            }
            else
            {
                if (!string.IsNullOrEmpty(FileName))
                {
                    ViewBag.ImgPath = "\\images\\" + FileName;
                }
                else
                {
                    ViewBag.ImgPath = car.MiniImageUrl;
                }

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
            }
            else
            {
                return View(car);
            }
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id, string imageUrl)
        {
            var car = carRepository.GetOneCarById(id);
            carRepository.DeleteCar(car);

            var webRoot = env.WebRootPath;
            var imagePath = Path.Combine(webRoot.ToString() + imageUrl);

            if (System.IO.File.Exists(imagePath))
            {
                System.IO.File.Delete(imagePath);
            }

            return RedirectToAction("Index");
        }

        [HttpPost("UploadFile")]
        public async Task<IActionResult> UploadImage(IFormCollection form)
        {
            var webRoot = env.WebRootPath;
            var imagePath = Path.Combine(webRoot.ToString() + "\\images\\" + form.Files[0].FileName);

            if (form.Files[0].Length > 0)
            {
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    await form.Files[0].CopyToAsync(stream);
                }
            }

            if (Convert.ToString(form["CarId"]) == string.Empty || Convert.ToString(form["CarId"]) == "0")
            {
                return RedirectToAction(nameof(Create), new { FileName = Convert.ToString(form.Files[0].FileName) });
            }
            else
            {
                return RedirectToAction(nameof(Edit), new { FileName = Convert.ToString(form.Files[0].FileName), id = Convert.ToInt32(form["CarId"]) });
            }
        }

    }
}
