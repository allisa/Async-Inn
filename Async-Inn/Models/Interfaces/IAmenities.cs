﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models.Interfaces
{
    public interface IAmenities
    {
        Task CreateAmenity(Amenities amenity);

        Task<Amenities> GetAmenity(int? id);

        Task<IEnumerable<Amenities>> GetAmenities();

        Task UpdateAmenities(Amenities amenity);

        Task DeleteAmenities(int id);
    }
}
