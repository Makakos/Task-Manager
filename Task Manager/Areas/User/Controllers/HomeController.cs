using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Task_Manager.Services;

namespace Task_Manager.Areas.User.Controllers
{
    [Area("User")]
    public class HomeController : Controller
    {
        private readonly DataManager manager;
        public HomeController(DataManager dataManager) { manager = dataManager; }


        public IActionResult Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = manager.Users.GetUserById(userId);
            user.Goals = manager.Goals.GetUserGoals(userId);
            return View(user);
        }
    }
}
