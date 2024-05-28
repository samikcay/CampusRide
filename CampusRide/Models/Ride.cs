using System.ComponentModel.DataAnnotations;

namespace CampusRide.Models
{
	public class Ride
	{
		public int Id { get; set; }
		[Required]
		public string StartingLocation { get; set; } = string.Empty;
		[Required]
		public string EndingLocation { get; set; } = string.Empty;
		public DateTime StartingTime { get; set; }
		public DateTime EndingTime { get; set;}
		public int Cost { get; set; }
	}
}
