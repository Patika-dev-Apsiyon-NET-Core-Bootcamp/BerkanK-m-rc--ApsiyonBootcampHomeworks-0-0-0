using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService = null;
        private readonly ICategoryService _categoryService = null;

        public BlogController(IBlogService blogService, ICategoryService categoryService)
        {
            _blogService = blogService;
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            ViewBag.Categories = _categoryService.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Add(BlogViewModel model)
        {
            //foreach (var id in model.SelectedCategories)
            //{
            //  CategoryViewModel categoryViewModel =  _categoryService.GetById(id)
            //}
            //model.Categories = 
            _blogService.AddWithCategories(model);
            return View();
        }
       
        //public IActionResult Delete(int id)
        //{
        //    (int)_blogService.GetById(id);
        //    _blogService.Delete((int)_blogService.GetById(id));
        //}

        //public IActionResult Update(BlogViewModel model)
        //{
        //    //mapleme 
        //    _blogService.Update(model);
          
        //}
    }
}
