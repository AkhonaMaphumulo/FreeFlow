using System.Diagnostics;
using FreeFlow.Models;
using Microsoft.AspNetCore.Mvc;

namespace FreeFlow.Controllers
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
        public IActionResult Learn()
        {
            return View();
        }
        public IActionResult Tracker()
        {
            // Returns the standalone tracker page or partial view
            return View("_PeriodTrackerPartial");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
