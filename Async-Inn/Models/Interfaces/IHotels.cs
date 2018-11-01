﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models.Interfaces
{
    public interface IHotels
    {
        Task CreateHotel(Hotel hotel);

        Task<Hotel> GetHotel(int? id);

        Task<IEnumerable<Hotel>> GetHotels();

        Task UpdateHotel(Hotel hotel);

        Task DeleteHotel(int id);
    }
}
