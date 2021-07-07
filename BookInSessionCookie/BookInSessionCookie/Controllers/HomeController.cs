using BookInSessionCookie.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookInSessionCookie.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

        }
        List<BookViewModel> model = new List<BookViewModel>()
        {
            new BookViewModel
            {
            BookName = "Fareler ve İnsanlar",
            Author = "John Steinbeck"
            },
            new BookViewModel
            {
            BookName = "Dünya Çocukların Olsa",
            Author = "Gülten Dayıoğlu"
            },
            new BookViewModel
            {
            BookName = "Monte Kristo Kontu",
            Author = "Alexandre Dumas"
            },
            new BookViewModel
            {
            BookName = "Uçurtma Avcısı",
            Author = "Halit Hüseyni"
            }
        };



        public IActionResult GetList()
        {
            if (HttpContext.Session.Get<List<BookViewModel>>("book") == null){
                return RedirectToAction("Add", "Home");
            }

            return View(model);
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(BookViewModel bookViewModel)
        {
                 if(HttpContext.Session.Get<List<BookViewModel>>("book") == default)//session get call
            {
                model.Add(bookViewModel);//modele parametre eklendi
                HttpContext.Session.Set<List<BookViewModel>>("book", model);//session set call
            }
            return View("GetList", model);
        }

        public IActionResult Search()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Search(SearchViewModel model)
        {

            var models =  HttpContext.Session.Get<List<BookViewModel>>("book");
            var book = models.FirstOrDefault(x => x.BookName == model.BookName);
            ViewBag.Search = book.BookName;
            return RedirectToAction("Search");
        }


        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Favorite()
        {
            if (Request.Cookies.ContainsKey("favori"))
            {
                return View("Favorite", Request.Cookies.ContainsKey("favori"));
            }
            ViewBag.Cookie = Request.Cookies.ContainsKey("favori");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
