using Microsoft.AspNetCore.Mvc;
using CampusRide.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CampusRide.Controllers
{
    public class RideController : Controller
    {
        public ActionResult Create()
        {
            var startingLocations = new List<SelectListItem>
            {
                new SelectListItem { Text = "Keçiören", Value = "Kecioren" },
                new SelectListItem { Text = "Pursaklar", Value = "Pursaklar" },
                new SelectListItem { Text = "Çankaya", Value = "Cankaya" }
            };

            var endingLocations = new List<SelectListItem>
            {
                new SelectListItem { Text = "Mühendislik Fakültesi", Value = "MuhendislikFakultesi" },
                new SelectListItem { Text = "Merkez Kampüs", Value = "MerkezKampus" },
                new SelectListItem { Text = "Gölbaşı", Value = "Golbasi" }
            };

            var model = new Ride
            {
                StartingLocations = startingLocations,
                EndingLocations = endingLocations
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Create(Ride model)
        {
            if (ModelState.IsValid)
            {
                // Model verilerini işleme (örneğin, veritabanına kaydetme)
                return RedirectToAction("Success");
            }

            // Eğer model geçerli değilse, dropdown listelerini tekrar oluştur
            model.StartingLocations = new List<SelectListItem>
            {
                new SelectListItem { Text = "Keçiören", Value = "Kecioren" },
                new SelectListItem { Text = "Pursaklar", Value = "Pursaklar" },
                new SelectListItem { Text = "Çankaya", Value = "Cankaya" }
            };

            model.EndingLocations = new List<SelectListItem>
            {
                new SelectListItem { Text = "Mühendislik Fakültesi", Value = "MuhendislikFakultesi" },
                new SelectListItem { Text = "Merkez Kampüs", Value = "MerkezKampus" },
                new SelectListItem { Text = "Gölbaşı", Value = "Golbasi" }
            };

            return View(model);
        }

        public ActionResult Success()
        {
            return View();
        }
    }
}
