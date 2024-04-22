using Checkpoint2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Checkpoint2.Controllers
{
    public class FeedbackController : Controller
    {
        private static List<Feedback> feedbacks = new List<Feedback>();

        public IActionResult Index()
        {
            return View(feedbacks);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Feedback feedback)
        {
            feedback.IdFeedback = feedbacks.Count + 1;
            feedbacks.Add(feedback);
            return RedirectToAction("Index");
        }
    }
}
