using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Komis.Models;

namespace Komis.Controllers
{
    public class OpinionController : Controller
    {
        private readonly IOpinionRepository _opinionRepository;

        public OpinionController(IOpinionRepository opinionRepository)
        {
            _opinionRepository = opinionRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Opinion opinion)
        {
            if (ModelState.IsValid)
            {
                _opinionRepository.AddOpinion(opinion);

                return RedirectToAction("FeedbackSent");
            } else
            {
                return View(opinion);
            }
        }

        public IActionResult FeedbackSent()
        {
            return View();
        }
    }
}