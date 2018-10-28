using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models
{
    public class RoomAmenities
    {
        [ForeignKey("Amenities")]
        [Display(Name = "Amenity")]
        public int AmenitiesID { get; set; }

        [ForeignKey("Room")]
        [Display(Name = "Room")]
        public int RoomID { get; set; }

        public Amenities Amenities { get; set; }
        public Room Room { get; set; }
    }
}
