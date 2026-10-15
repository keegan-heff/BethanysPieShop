using BethanysPieShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
	public class ContactController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(Contact model)
		{
			if (!ModelState.IsValid)
				return View(model);

			StaticContactData.Add(model);
			TempData["ContactSuccess"] = "Thanks for your message. We'll get back to you soon!";

			return RedirectToAction(nameof(Thanks));
		}

		[HttpGet]
		public IActionResult Thanks()
		{
			return View();
		}
	}
}
