using System.Diagnostics;
using KammalKada.Models;
using Microsoft.AspNetCore.Mvc;

namespace KammalKada.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly string contactNumber;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            contactNumber = configuration["WhatsappContact:ContactNum"];
        }

        public IActionResult Index()
        {
            ViewBag.contactNumber = contactNumber;
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
