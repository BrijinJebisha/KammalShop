using KammalKada.Models;
using KammalKada.Models.DataModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Text;

namespace KammalKada.Controllers
{
	public class SecurityController : Controller
	{
		private readonly HttpClient httpClient;
		private readonly string baseurl;
		public SecurityController(IConfiguration configuration)
		{
			baseurl = configuration["ApiSettings:baseUrl"];
			httpClient = new HttpClient
			{
				BaseAddress = new Uri(baseurl)
			};
		}
		// GET: SecurityController
		public ActionResult Index()
		{
			return View();
		}

		public async Task<IActionResult> Login( LoginViewModel model)
		{
			try
			{
				if (!ModelState.IsValid)
				{
					return RedirectToAction("Error", "Home");
				}

				var logindata = new
				{
					Email = model.Username,
					Password = model.Password
				};

				var claim = new List<Claim>
				{
					new Claim(ClaimTypes.Name, model.Username),
					//new Claim(ClaimTypes.Email, user.EmailId),
					//new Claim(ClaimTypes.MobilePhone, user.PhoneNumber)
				};

				var identity = new ClaimsIdentity(claim, CookieAuthenticationDefaults.AuthenticationScheme);
				var principal = new ClaimsPrincipal(identity);

				await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

				return RedirectToAction("Index", "Home");

				//var data = new StringContent(
				//	System.Text.Json.JsonSerializer.Serialize(logindata),
				//	Encoding.UTF8,
				//	"application/json");

				//HttpResponseMessage response = await httpClient.PostAsync("/api/Employee/login", data);
				//if (response.IsSuccessStatusCode)
				//{
				//	var user = await response.Content.ReadFromJsonAsync<UserDM>();
				//	var claim = new List<Claim>
				//{
				//	new Claim(ClaimTypes.Name, user.EmployeeName),
				//	new Claim(ClaimTypes.Email, user.EmailId),
				//	new Claim(ClaimTypes.MobilePhone, user.PhoneNumber)
				//};

				//	var identity = new ClaimsIdentity(claim, CookieAuthenticationDefaults.AuthenticationScheme);
				//	var principal = new ClaimsPrincipal(identity);

				//	await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

				//	return RedirectToAction("Index", "Home");
				//}

				//return View();
			}
			catch(Exception ex)
			{
				return RedirectToAction("Error", "Home");
			}
			
		}

		// GET: SecurityController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: SecurityController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: SecurityController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: SecurityController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: SecurityController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: SecurityController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: SecurityController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
