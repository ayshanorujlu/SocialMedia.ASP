using Microsoft.AspNetCore.Mvc;

namespace ASPProject.WebUI.Controllers
{
    public class FeedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
