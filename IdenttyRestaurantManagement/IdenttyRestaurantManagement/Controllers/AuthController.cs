using IdenttyRestaurantManagement.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdenttyRestaurantManagement.Controllers
{
    public class AuthController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AuthController(SignInManager<User> signInManager, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        public async Task<IActionResult> Login(string username, string password)
        {
            var result = await _signInManager.PasswordSignInAsync(username, password, false, false);
            if (!result.Succeeded) return RedirectToAction("Login");
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(UserViewModel model)
        {
            IdentityResult result = await _userManager.CreateAsync(new User
            {
                Name = model.Name,
                UserName = model.UserNm
          
            }, model.Password
                 );
            if (result.Succeeded) return RedirectToAction("Login");



            return RedirectToAction("Register");
        }
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Login");
        }

        [AllowAnonymous]
        public async Task<IActionResult> Role()
        {
            await _roleManager.CreateAsync(new IdentityRole { Name = Roles.Chef });
            return View();

        }
        public async Task<IActionResult> AddToRole()
        {
            User user = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            //bool isInRole = await _userManager.IsInRoleAsync(user, Roles.HR);
            if (!await _userManager.IsInRoleAsync(user, Roles.Chef))
                await _userManager.AddToRoleAsync(user, Roles.Chef);

            await _signInManager.SignOutAsync();

            return View();
        }
}