namespace CampusRide.Models
{
    public class User
    {
        public ulong Id { get; set; }
        public string? Name { get; set; } = string.Empty;
        public string? Surname { get; set; } = string.Empty;
        public string? FullName { get; } 
        public string? Email { get; set; } = string.Empty;
        public DateTime RegistryTime { get; set; }
        public User()
        {
            RegistryTime = DateTime.Now;
            FullName = Name + Surname;
        }
    }
}
