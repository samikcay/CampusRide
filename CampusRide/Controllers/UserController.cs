using Microsoft.AspNetCore.Mvc;

namespace CampusRide.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
