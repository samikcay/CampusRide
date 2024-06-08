using Microsoft.AspNetCore.Mvc;
using CampusRide.Models; // MessageViewModel buradan gelecek

namespace CampusRide.Controllers
{
    {
            // TODO: Veritabanına yeni bir mesaj oluştur ve kaydet
            //       Yanıtlanan mesajın kimden geldiğini, kime gittiğini ve yanıtın hangi mesaja ait olduğunu belirlemeyi unutma

            // Başarılı bir şekilde yanıtlandıktan sonra, mesajların listelendiği bir sayfaya yönlendirme yapabilirsiniz
            return RedirectToAction("Index", "Messages");
        }



    }
}
