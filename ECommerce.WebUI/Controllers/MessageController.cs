using Microsoft.AspNetCore.Mvc;

namespace ASPProject.WebUI.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Message()
        {
            return View("Message");
        }
        public IActionResult LiveChat()
        {
            return View("LiveChat");
        }
    }
}
