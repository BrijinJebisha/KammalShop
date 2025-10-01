using System.Diagnostics;
using KammalKada.Models;
using KammalKada.Models.DataModel;
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

		public IActionResult OverView()
		{
			var images = new List<ImageModel>
			{
				new ImageModel { Name="Diamond Bangle",Path=Url.Content("~/Images/Diamond_bangle_for_Girls.jpg") },
				new ImageModel { Name="Diamond Earrings",Path=Url.Content("~/Images/Diamond_Earrings.jpg") },
				new ImageModel { Name="Diamond Necklace",Path=Url.Content("~/Images/Diamond_Necklace.png") },
				new ImageModel { Name="Diamond Ring",Path=Url.Content("~/Images/Diamond_Ring.jpg") },
				new ImageModel { Name="Gold Bracelet",Path=Url.Content("~/Images/Gold_Bracelet.jpg") },
				new ImageModel { Name="Gold Earrings",Path=Url.Content("~/Images/Gold_Earrings.jpg") },
				new ImageModel { Name="Gold Ring",Path=Url.Content("~/Images/Gold_Ring.jpg") },
				new ImageModel { Name="Gold Ring Men",Path=Url.Content("~/Images/Gold_Ring_Men.jpg") },
				new ImageModel { Name="Diamond Bangle",Path=Url.Content("~/Images/Platinum_Diamond_Bangle.jpg") },
				new ImageModel { Name="Diamond Bangle",Path=Url.Content("~/Images/Diamond_Bangle.jpg") }
			};
			return PartialView("_overview", images);
		}

        public IActionResult Cart()
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
