using Microsoft.AspNetCore.Mvc;
using CampusRide.Models; // MessageViewModel buradan gelecek

namespace CampusRide.Controllers
{
    public class MessagesController : Controller
    {
        private readonly RepositoryContext _context;

        public MessagesController(RepositoryContext context)
        {
            _context = context;
        }
        // Mesajları listeleme işlemi
        public IActionResult Index()
        {
            // Mevcut kullanıcıya ait gelen mesajları getir
            var currentUserMessages = _context.Messages;

            // Gelen mesajları görüntülemek için view'e aktar
            return View(currentUserMessages);
        }

        // Yeni mesaj oluşturma işlemi
        public IActionResult Create()
        {
            // Yeni mesaj oluşturma formunu gösteren bir görünüm döndürün
            return View();
        }

        // Yeni mesaj oluşturma formundan gelen verileri işleme işlemi
        [HttpPost]
        public IActionResult Create(MessageViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Yeni mesajı veritabanına kaydetme işlemi
                // Örneğin: _messageService.CreateMessage(model);

                // Başarılı bir şekilde kaydedildikten sonra kullanıcıyı yönlendirme işlemi
                return RedirectToAction("Index");
            }

            // Model geçerli değilse, tekrar oluşturma formunu gösterin
            return View(model);
        }

        [HttpPost]
        public IActionResult Reply(int messageId, string replyContent)
        {
            // TODO: Veritabanına yeni bir mesaj oluştur ve kaydet
            //       Yanıtlanan mesajın kimden geldiğini, kime gittiğini ve yanıtın hangi mesaja ait olduğunu belirlemeyi unutma

            // Başarılı bir şekilde yanıtlandıktan sonra, mesajların listelendiği bir sayfaya yönlendirme yapabilirsiniz
            return RedirectToAction("Index", "Messages");
        }



    }
}
