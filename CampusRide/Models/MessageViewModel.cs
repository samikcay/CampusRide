using System.ComponentModel.DataAnnotations;

namespace CampusRide.Models
{
    public class MessageViewModel
    {
        [Required(ErrorMessage = "Gönderen kimliği gereklidir.")]
        public string SenderId { get; set; }

        [Required(ErrorMessage = "Alıcı kimliği gereklidir.")]
        public string ReceiverId { get; set; }

        [Required(ErrorMessage = "Mesaj içeriği gereklidir.")]
        public string Content { get; set; }
    }
}
