using Microsoft.AspNetCore.Mvc;
using KammalKada.Models.DataModel;

namespace KammalKada.Controllers
{
	public class ProductController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
