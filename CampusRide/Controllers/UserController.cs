using CampusRide.Models;
using Microsoft.AspNetCore.Mvc;

namespace CampusRide.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            //if (ModelState.IsValid)
            //{
                // Kullanıcı doğrulama işlemini burada gerçekleştirin
                // Örnek:
                if (user.Email == "admin" && user.Password == "123")
                {
                    // Giriş başarılı, yönlendirme yapabilirsiniz
                    return RedirectToAction("UserPage", "User");
                }
                else
                {
                    // Hata mesajı
                    ModelState.AddModelError("", "Geçersiz kullanıcı adı veya şifre.");
                }
            //}
            return View(user);
        }

        public IActionResult UserPage() 
        {
            return View(); 
        }
    }
}
