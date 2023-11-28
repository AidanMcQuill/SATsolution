using Microsoft.AspNetCore.Mvc;
using SATapp.UI.MVC.Models;
using System.Diagnostics;

namespace SATapp.UI.MVC.Controllers
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

        public IActionResult Courses()
        {
            return View();
        }

        public IActionResult Enrollment()
        {
            return View();
        }

        public IActionResult Classes()
        {
            return View();
        }

        public IActionResult Students()
        {
            return View();
        }        

        public IActionResult Contact()
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
    }
}