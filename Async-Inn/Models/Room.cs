using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models
{
    public class Room
    {
        public int RoomID { get; set; }
        [Display(Name = "Room Name")]
        public string Name { get; set; }

        [EnumDataType(typeof(Layout))]
        public Layout Layout { get; set; }

        ICollection<HotelRoom> HotelRooms { get; set; }

        ICollection<RoomAmenities> RoomAmenities { get; set; }
    }

    public enum Layout
    {
        Studio = 0,
        [Display(Name = "One Bedroom")]
        OneBedroom = 1,
        [Display(Name = "Two Bedroom")]
        TwoBedroom = 2
    }
}
