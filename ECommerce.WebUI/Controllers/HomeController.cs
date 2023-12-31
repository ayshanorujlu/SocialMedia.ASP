﻿using ASPProject.Entities;
using ASPProject.WebUI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASPProject.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private UserManager<CustomIdentityUser> _userManager;
        private CustomIdentityDBContext _context;

        public HomeController(UserManager<CustomIdentityUser> userManager, CustomIdentityDBContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            ViewBag.User = new
            {
                ImageUrl = user.ImageUrl,
                Username = user.UserName
            };
            var something = ViewBag.User.ImageUrl;
            return View();
        }
        public IActionResult MyProfile()
        {
            return View("MyProfile");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}