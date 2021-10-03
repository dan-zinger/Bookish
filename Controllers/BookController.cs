using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bookish.Models;
using Bookish.Services;

namespace Bookish.Controllers
{
    [Route("books")]
    public class BookController : Controller
    {
        private readonly ILogger<BookController> _logger;
        private readonly IBookService _bookService;
        private readonly IAuthorService _authorservice;

        public BookController(
            ILogger<BookController> logger, 
            IBookService bookService,
            IAuthorService authorservice)
        {
            _logger = logger;
            _bookService = bookService;
            _authorservice = authorservice;
        }
        
        public IActionResult BookListview()
        {
            return View(_bookService.GetAllBooks());
        }

        [HttpGet("{BookId}")]
        public IActionResult BookView(int id)
        {
            return View(_bookService.GetBook(id));
        }

        [HttpPost("book")]     //Needs to be post, via ajax
        public IActionResult AddCopyOfBook(Book book)   //change to a redirect
        {
            _bookService.AddCopyOfBook(book.BookId);
            return RedirectToAction("BookView", "book", new {id=15});
        }

        [HttpGet("create")]   // fine
        public IActionResult CreateBookView()
        {
            ViewBag.authors = _authorservice.GetAuthorList();
            return View();
        }

        [HttpPost("create")] //fine
        public IActionResult CreateBook(Book book)  
        {
            
            _bookService.CreateBook(book);
            return RedirectToAction("CreateBookView");
        }

        [HttpGet("delete")]   // needs to be a DELETE http request, via an ajax action link
        public IActionResult DeleteBookSuccess(int id)    // change to a redutide
        {
            _bookService.DeleteBook(id);
            return View();
        }
    }
}
