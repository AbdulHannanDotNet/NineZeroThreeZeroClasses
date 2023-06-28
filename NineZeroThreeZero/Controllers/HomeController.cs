using Microsoft.AspNetCore.Mvc;
using NineZeroThreeZero.Models;
using System.Diagnostics;

namespace NineZeroThreeZero.Controllers
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
            //This is a new comment you will get this once you pull
            return View();
        }

        public IActionResult Privacy()
        {
          //My name is Nematullah khan
            return View();
        }

        public IActionResult Privacy1()
        {
            //My name is Faisal uddin mohammed
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}