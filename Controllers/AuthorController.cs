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
    [Route("authors")]
    public class AuthorController : Controller
    {
        private readonly ILogger<AuthorController> _logger;
        private readonly IAuthorService _authorservice;

        public AuthorController(ILogger<AuthorController> logger, IAuthorService authorService)
        {
            _logger = logger;
            _authorservice = authorService;
        }

        // 1) createauthorview , httpget, route: create, method: createauthorview
        [HttpGet("create")]
        public IActionResult CreateAuthorView()
        {
            ViewBag.authors = _authorservice.GetAuthorList();
            return View();
        }
        // 2) createauthor, httppost, route
        [HttpPost("create")]
        public IActionResult CreateAuthor(Author author)
        {
            _authorservice.CreateAuthor(author);
            return RedirectToAction("CreateAuthorView");
        }

    }
}