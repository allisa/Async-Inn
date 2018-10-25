using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models
{
    public class Amenities
    {
        public int AmenitiesID { get; set; }
        public string Name { get; set; }
       
        ICollection<RoomAmenities> RoomAmenities { get; set; }
    }
}
