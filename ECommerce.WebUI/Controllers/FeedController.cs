using ASPProject.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ASPProject.WebUI.Controllers
{
    public class FeedController : Controller
    {
        private UserManager<CustomIdentityUser> _userManager;
        private CustomIdentityDBContext _context;

        public FeedController(UserManager<CustomIdentityUser> userManager, CustomIdentityDBContext context)
        {
            _userManager = userManager;
            _context = context;
        }
        public IActionResult Weather()
        {
            return View("Weather");
        }
        public async Task<IActionResult> Video()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            ViewBag.User = new
            {
                ImageUrl = user.ImageUrl,
                Username = user.UserName,
                Email = user.Email
            };
            return View("Video");
        }
        public async Task<IActionResult> Favorite()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            ViewBag.User = new
            {
                ImageUrl = user.ImageUrl,
                Username = user.UserName,
                Email = user.Email
            };
            return View("Favorite");
        }
    }
}
