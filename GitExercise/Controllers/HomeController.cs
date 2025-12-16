using System.Diagnostics;
using GitExercise.Models;
using Microsoft.AspNetCore.Mvc;

namespace GitExercise.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            Console.WriteLine("Constructor");
            _logger = logger;
        }

        public IActionResult Index()
        {
            Console.WriteLine("Index");
            return View();
        }

        public IActionResult Privacy()
        {
            Console.WriteLine("Privacy");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            Console.WriteLine("Error");
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
