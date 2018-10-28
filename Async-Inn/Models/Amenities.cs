using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models
{
    public class Amenities
    {
        public int AmenitiesID { get; set; }

        [Required(ErrorMessage = "Amenity name is required")]
        [Display(Name = "Amenity")]
        public string Name { get; set; }
       
        ICollection<RoomAmenities> RoomAmenities { get; set; }
    }
}
