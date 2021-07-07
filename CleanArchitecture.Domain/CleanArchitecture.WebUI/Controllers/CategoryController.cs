using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService = null;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(CategoryViewModel category)
        {
            _categoryService.Add(category);
            return RedirectToAction("Add");
        }

        //public IActionResult Delete(int id)
        //{
        //    (int)_categoryService.GetById(id);
        //    _categoryService.Delete((int)_categoryService.GetById(id));
        //}

        //public IActionResult Update(CategoryViewModel model)
        //{
        //    //mapleme 
        //    _categoryService.Update(model);

        //}
    }
}
