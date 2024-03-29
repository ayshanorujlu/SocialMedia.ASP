﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASPProject.Entities;

namespace ASPProject.WebUI.Controllers
{
    public class MessageController : Controller
    {
        private UserManager<CustomIdentityUser> _userManager;
        private CustomIdentityDBContext _context;

        public MessageController(UserManager<CustomIdentityUser> userManager, CustomIdentityDBContext context)
        {
            _userManager = userManager;
            _context = context;
        }
        public async Task<IActionResult> Message()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            ViewBag.User = new
            {
                ImageUrl = user.ImageUrl,
                Username = user.UserName,
                Email = user.Email
            };
            return View("Message");
        }
        public async Task<IActionResult> LiveChat()
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            var users = await _context.Users
                .Where(u => u.Id != currentUser.Id && u.IsOnline)
                .ToListAsync();
            ViewBag.User = new
            {
                ImageUrl = currentUser.ImageUrl,
                Username = currentUser.UserName,
                Email = currentUser.Email
            };
            ViewBag.Users = new List<object>();
            foreach (var item in users)
            {
                ViewBag.Users.Add(new
                {
                    Id = item.Id,
                    ImageUrl = item.ImageUrl,
                    Username = item.UserName,
                    Email = item.Email
                });
            }
            return View("LiveChat");
        }
    }
}
