using Microsoft.AspNetCore.Mvc;

namespace ASPProject.WebUI.Controllers
{
    public class FeedController : Controller
    {
        public IActionResult Weather()
        {
            return View("Weather");
        }
        public IActionResult Video()
        {
            return View("Video");
        }
        public IActionResult Favorite()
        {
            return View("Favorite");
        }
    }
}
