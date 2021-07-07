using IdenttyRestaurantManagement.Data;
using IdenttyRestaurantManagement.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IdenttyRestaurantManagement.Controllers
{//bütün işlemler bu controllerda yapılıyor.
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _applicationDbContext;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category categoryModel)
        {
            _applicationDbContext.Categories.Add(categoryModel);
            _applicationDbContext.SaveChanges();
            return RedirectToAction("CategoryList");
        }
        public IActionResult CategoryList()
        {
            var categoryList = _applicationDbContext.Categories.ToList();
            return View(categoryList);
        }
        public IActionResult MenuAdd()
        {
            return View();
        }
        public IActionResult MenuAdd(Menu menuModel)
        {
            _applicationDbContext.Menus.Add(menuModel);
            _applicationDbContext.SaveChanges();
            return RedirectToAction("MenuList");
        }
        [MyAuthorize(Roles.Chef)]
        public IActionResult MenuList()
        {
            var menuList = _applicationDbContext.Menus.ToList();
            return View(menuList);
        }

        public IActionResult RestaurantList()
        {
            var restaurantList = _applicationDbContext.Restaurants.ToList();
            return View(restaurantList);
        }

      
            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
