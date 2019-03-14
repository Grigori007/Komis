using Komis.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Komis.Controllers
{
    [Authorize]
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

        [HttpGet]
        public IActionResult FeedbackSent()
        {
            return View();
        }
    }
}