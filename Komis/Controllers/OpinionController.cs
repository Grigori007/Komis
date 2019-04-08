using Komis.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Komis.Controllers
{
    [Authorize]
    public class OpinionController : Controller
    {
        private readonly IOpinionRepository opinionRepository;

        public OpinionController(IOpinionRepository _opinionRepository)
        {
            opinionRepository = _opinionRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Opinion opinion)
        {
            if (ModelState.IsValid)
            {
                opinionRepository.AddOpinion(opinion);
                return RedirectToAction("FeedbackSent");

            } else
            {
                return View(opinion);
            }
        }

        [HttpGet]
        public IActionResult FeedbackSent()
        {
            return View();
        }
    }
}