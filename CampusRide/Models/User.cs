using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CampusRide.Models
{
    public class User
    {
        [Required]
        [Key]
        [Phone]
        public string? PhoneNumber { get; set; }
        [Required]
        public string? Name { get; set; } = string.Empty;
		[Required]
		public string? Surname { get; set; } = string.Empty;
        [Required]
        public string? Gender {  get; set; } = string.Empty;
        [Required]
        [Range(18, 100)]
        public int Age { get; set; }
		[Required]
        [EmailAddress]
		public string? Email { get; set; } = string.Empty;
        [Required]
        [PasswordPropertyText]
        public string? Password {  get; set; } = string.Empty;
        public string? About { get; set; } = string.Empty;
        public DateTime RegistryTime { get; set; }
        public User()
        {
            RegistryTime = DateTime.Now;
        }
    }
}
