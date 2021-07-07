using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.WebUI.Controllers
{
    public class TagController : Controller
    {
        private readonly ITagService _tagService = null;

        public TagController(ITagService tagService)
        {
            _tagService = tagService;
        }
        public IActionResult Add()
        {
            ViewBag.Tags = _tagService.GetAll();
            return View();
        }
        [HttpPost]
        public IActionResult Add(TagViewModel model)
        {
            _tagService.Add(model);
            return RedirectToAction("Add");
        }

        //public IActionResult Delete(int id)
        //{
        //    (int)_tagService.GetById(id);
        //    _tagService.Delete((int)_tagService.GetById(id));
        //}

        //public IActionResult Update(TagViewModel model)
        //{
        //    //mapleme 
        //    _tagService.Update(model);

        //}
    }
}
