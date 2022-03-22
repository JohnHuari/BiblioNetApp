using BiblioNetApp.Models;
using BiblioNetApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace BiblioNetApp.Controllers
{
    public class BookController : Controller
    {
        private readonly IRepositorieBiblioNetApp repositorieBiblioNetApp;

        public BookController(IRepositorieBiblioNetApp repositorieBiblioNetApp)
        {
            this.repositorieBiblioNetApp = repositorieBiblioNetApp;
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (!ModelState.IsValid)
            {
                return View(book);
            }

            repositorieBiblioNetApp.Create(book);

            return View();
        }
    }
}
