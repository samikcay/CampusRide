using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CampusRide.Models
{
    public class Ride
    {
        [Required]
        public string StartingLocation { get; set; }
        [Required]
        public string EndingLocation { get; set; }
        [Required]
        [DataType(DataType.Time)]
        public DateTime StartingTime { get; set; }
        [Required]
        [DataType(DataType.Time)]
        public DateTime EndingTime { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime TravelDate { get; set; }=DateTime.Now.Date;

        public List<SelectListItem> StartingLocations { get; set; }
        public List<SelectListItem> EndingLocations { get; set; }
    }
}
