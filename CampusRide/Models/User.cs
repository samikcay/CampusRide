using System.ComponentModel.DataAnnotations;

namespace CampusRide.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; } = string.Empty;
		[Required]
		public string? Surname { get; set; } = string.Empty;
        public string? FullName { get; }
		[Required]
		public string? Email { get; set; } = string.Empty;
        public DateTime RegistryTime { get; set; }
        public User()
        {
            RegistryTime = DateTime.Now;
            FullName = Name + Surname;
        }
    }
}
