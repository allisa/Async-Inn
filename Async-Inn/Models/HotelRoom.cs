using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models
{
    public class HotelRoom
    {
        [ForeignKey("Hotel")]
        [Display(Name = "Hotel")]
        public int HotelID { get; set; }

        [Required(ErrorMessage = "Enter a roome number")]
        [Display(Name = "Room Number")]
        public int RoomNumber { get; set; }

        [ForeignKey("Room")]
        [Display(Name = "Room ID")]
        public int RoomID { get; set; }

        [Required(ErrorMessage = "Please provide a valid price")]
        public decimal Rate { get; set; }

        [Required]
        [Display(Name = "Pet Friendly")]
        public bool PetFriendly { get; set; }

        public Hotel Hotel { get; set; }
        public Room Room { get; set; }

    }
}
