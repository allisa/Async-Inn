using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models
{
    public class Hotel
    {

        public int HotelID { get; set; }

        [Required(ErrorMessage = "Hotel name is required")]
        [Display(Name = "Hotel Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Hotel address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Hotel phone number is required")]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        public ICollection<HotelRoom> HotelRooms { get; set; }
    }
}
