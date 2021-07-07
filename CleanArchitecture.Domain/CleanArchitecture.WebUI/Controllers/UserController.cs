
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CleanArchitecture.WebUI.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService = null;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
      
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(UserViewModel model)
        {
          
            _userService.Add(model);
            return View();
        }

        //public IActionResult Delete(int id)
        //{
        //    (int)_userService.GetById(id);
        //    _userService.Delete((int)_userService.GetById(id));
        //}

        //public IActionResult Update(CommentViewModel model)
        //{
        //    //mapleme 
        //    _userService.Update(model);

        //}
    }
}
