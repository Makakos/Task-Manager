using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Task_Manager.Models;

namespace Task_Manager.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public AccountController(UserManager<User> userManager,SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
      
        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Registration(RegistrationViewModel model)
        {
            if(ModelState.IsValid)
            {
                
                User user = new User { UserName = (model.Name==null?model.Email:model.Name), Year = model.Year, Email = model.Email,PhoneNumber = model.PhoneNumber };
                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {

                    await userManager.AddToRoleAsync(user, "User");

                    await signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Login(string returnUrl)
        {
            ViewBag.ReturnURL = returnUrl;
            return View(new LoginViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                User user = await userManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    signInManager.SignOutAsync();
                    var result = await signInManager.PasswordSignInAsync(user.UserName, model.Password, model.IsRemember, false);
                    if (result.Succeeded)
                    {
                        return Redirect(returnUrl ?? "/");
                    }
                }
                ModelState.AddModelError(nameof(LoginViewModel), "Неверный логин или пароль");
            }
            return View(model);
        }

        [Authorize]
        public IActionResult Logout()
        {
            signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}
