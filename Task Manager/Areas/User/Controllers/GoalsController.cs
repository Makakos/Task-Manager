using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.InkML;
using Microsoft.AspNetCore.Mvc;
using Task_Manager.Models;
using Task_Manager.Services;

namespace Task_Manager.Areas.User.Controllers
{
    [Area("User")]
    public class GoalsController : Controller
    {
        private readonly DataManager dataManager;

        public GoalsController(DataManager manager)
        {
            dataManager = manager;
        }

        public IActionResult Edit(int id)
        {
            var entity = id == default ? new Goal() : dataManager.Goals.GetGoalById(id);
            
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(Goal goal)
        {
            if (ModelState.IsValid)
            {
              

                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var user = dataManager.Users.GetUserById(userId);
                goal.User = user;
           
               
                dataManager.Goals.SaveGoal(goal);
                
                return RedirectToAction("Index", "Home");
            }
            return View(goal);
        }
    }
}
