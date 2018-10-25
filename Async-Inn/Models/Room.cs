using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models
{
    public class Room
    {
        public int RoomID { get; set; }
        public string Name { get; set; }
        public Layout Layout { get; set; }

        ICollection<HotelRoom> HotelRooms { get; set; }

        ICollection<RoomAmenities> RoomAmenities { get; set; }
    }

    public enum Layout
    {
        Studio = 0,
        OneBedroom = 1,
        TwoBedroom = 2
    }
}
