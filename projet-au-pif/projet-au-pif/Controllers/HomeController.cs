using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using projet_au_pif.Models;

namespace projet_au_pif.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Result(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                ModelState.AddModelError("", "Input text is empty");
            }
            if (ModelState.IsValid)
            {
                return View("Result", input);
            }
            var modelErrorsMessages = ModelState.Values.Select(k => k.Errors).SelectMany(errorCollection => errorCollection.Select(e => e.ErrorMessage));
            return View("Errors", modelErrorsMessages.ToList());
        }
    }
}
