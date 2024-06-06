using System.ComponentModel.DataAnnotations;

namespace CampusRide.Models
{
    public class Message
    {
        public int Id { get; set; }

        [Required]
        public string SenderId { get; set; }

        [Required]
        public string ReceiverId { get; set; }

        [Required]
        public string Content { get; set; }

        // Yanıtın hangi mesaja ait olduğunu belirten alan
        public int? ReplyTo { get; set; }
    }
}
