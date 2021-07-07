using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.WebUI.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService = null;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
           
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
        public IActionResult Add(CommentViewModel model)
        {
          
            _commentService.Add(model);
            return View();
        }

        //public IActionResult Delete(int id)
        //{
        //    (int)_commentService.GetById(id);
        //    _blogService.Delete((int)_commentService.GetById(id));
        //}

        //public IActionResult Update(CommentViewModel model)
        //{
        //    //mapleme 
        //    _commentService.Update(model);

        //}
    }
}
