using System;
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
        [StringLength(500)]
        public string Content { get; set; }

        public DateTime SentTime { get; set; }
    }
}
