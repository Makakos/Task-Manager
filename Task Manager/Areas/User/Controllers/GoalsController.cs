using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.InkML;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Task_Manager.Models;
using Task_Manager.Services;

namespace Task_Manager.Areas.User.Controllers
{
    [Area("User")]
    public class GoalsController : Controller
    {
        private readonly DataManager dataManager;

        public IEnumerable<string> categories = new List<string>
        {
            "For every day" ,
            "Deadline",
            "For today",
            "General"
        };

        public GoalsController(DataManager manager)
        {
            dataManager = manager;
        }
       public IActionResult Index(int id)
       {
            var entity = dataManager.Goals.GetGoalById(id);
            return View(entity);
        }


        public IActionResult Edit(int id)
        {
            
            var entity = id == default ? new Goal() : dataManager.Goals.GetGoalById(id);
            ViewBag.Categories = new SelectList(categories);
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



        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            if (id != null)
            {
                Goal goal = dataManager.Goals.GetGoalById(id);
                if (goal != null)
                    return View(goal);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            if (id != null)
            {
                Goal goal = new Goal { Id = id };
                dataManager.Goals.DeleteGoal(goal);
                return RedirectToAction("Index","Home");
    
            }
            return View(dataManager.Goals.GetGoalById(id));
        }
    }
}

