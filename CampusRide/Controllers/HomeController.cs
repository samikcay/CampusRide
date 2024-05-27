using CampusRide.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CampusRide.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
