using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bookish.Models;

namespace Bookish.Controllers
{
    [Route("books")]
    public class BookController : Controller
    {
        private readonly ILogger<BookController> _logger;

        public BookController(ILogger<BookController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Index()
        {
            return View(new List<BookModel> {
                new BookModel() {Title = "Harry Potter and the Philisopher's Stone", Author = "J.K. Rowling"},
                new BookModel() {Title = "Harry Potter and the Chamber of Secrets", Author = "J.K. Rowling"},
                new BookModel() {Title = "Harry Potter and the Prisoner of Azkaban", Author = "J.K. Rowling"},
                new BookModel() {Title = "Harry Potter and the Goblet of Fire", Author = "J.K. Rowling"},
                new BookModel() {Title = "Harry Potter and the Order of the Pheonix", Author = "J.K. Rowling"},
                new BookModel() {Title = "Harry Potter and the Half Blood Prince", Author = "J.K. Rowling"},
                new BookModel() {Title = "Harry Potter and the Deathly Hallows", Author = "J.K. Rowling"}
            });
        }
    }
}
