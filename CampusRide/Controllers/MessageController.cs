using Microsoft.AspNetCore.Mvc;
using CampusRide.Models;

namespace CampusRide.Controllers
{
    public class MessagesController : Controller
    {
        private readonly RepositoryContext _context;

        public MessagesController(RepositoryContext context)
        {
            _context = context;
        }

        // Index eylemi: Kullanıcının gelen mesajlarını listeler
        public IActionResult Index()
        {
            // Mevcut kullanıcıya ait gelen mesajları getir
            var currentUserMessages = _context.Messages;

            // Gelen mesajları görüntülemek için view'e aktar
            return View(currentUserMessages);
        }

        // Reply eylemi: Mesajlara yanıt verme işlemini gerçekleştirir
        [HttpPost]
        public IActionResult Reply(int messageId, string replyContent)
        {
            // Yanıtı işleme alma kodu buraya gelecek
            // Yeni bir mesaj oluştur ve veritabanına kaydet

            var originalMessage = _context.Messages.Find(messageId);
            if (originalMessage == null)
            {
                return NotFound();
            }

            var newMessage = new Message
            {
                SenderId = originalMessage.ReceiverId,
                ReceiverId = originalMessage.SenderId,
                Content = replyContent,
                ReplyTo = originalMessage.Id
            };

            _context.Messages.Add(newMessage);
            _context.SaveChanges();

            return RedirectToAction("Index", "Messages");
        }

        public  IActionResult Create()
        {
            return View();
        }
    }
}
