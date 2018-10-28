using Async_Inn.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Data
{
    public class AsyncInnDbContext : DbContext
    {
        public AsyncInnDbContext(DbContextOptions<AsyncInnDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HotelRoom>().HasKey(
                hr => new { hr.HotelID, hr.RoomNumber }
                );
            modelBuilder.Entity<RoomAmenities>().HasKey(
                ra => new { ra.AmenitiesID, ra.RoomID }
                );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    HotelID = 1,
                    Name = "Evergreen Inn",
                    Address = "123 Forest Dr",
                    Phone = "206-555-5555"

                },
                new Hotel
                {
                    HotelID = 2,
                    Name = "Birch Inn",
                    Address = "123 Tree St",
                    Phone = "206-555-4444"
                },
                 new Hotel
                 {
                     HotelID = 3,
                     Name = "Oak Hotel",
                     Address = "123 Branch St",
                     Phone = "206-555-6666"
                 },
                  new Hotel
                  {
                      HotelID = 4,
                      Name = "Pine Inn",
                      Address = "123 Fir Dr",
                      Phone = "206-555-7777"
                  },
                   new Hotel
                   {
                       HotelID = 5,
                       Name = "Douglas Fir Hotel",
                       Address = "123 Needle St",
                       Phone = "206-555-8888"
                   }
                );

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomID = 1,
                    Name = "Cedar",
                    Layout = Layout.OneBedroom
                },
                new Room
                {
                    RoomID = 2,
                    Name = "Redwood",
                    Layout = Layout.TwoBedroom
                },
                new Room
                {
                    RoomID = 3,
                    Name = "Maple",
                    Layout = Layout.Studio
                },
                new Room
                {
                    RoomID = 4,
                    Name = "Juniper",
                    Layout = Layout.OneBedroom
                },
                new Room
                {
                    RoomID = 5,
                    Name = "Maple",
                    Layout = Layout.TwoBedroom
                },
                 new Room
                 {
                     RoomID = 6,
                     Name = "Alder",
                     Layout = Layout.Studio
                 }
                );
            modelBuilder.Entity<Amenities>().HasData(
                new Amenities
                {
                    AmenitiesID = 1,
                    Name = "Coffee Maker"
                },
                 new Amenities
                 {
                     AmenitiesID = 2,
                     Name = "Air Conditioning"
                 },
                  new Amenities
                  {
                      AmenitiesID = 3,
                      Name = "Waterfront View"
                  },
                   new Amenities
                   {
                       AmenitiesID = 4,
                       Name = "Mini-bar"
                   },
                    new Amenities
                    {
                        AmenitiesID = 5,
                        Name = "Personal Chef"
                    }
                );
        }

        public DbSet<Room> Room { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Amenities> Amenities { get; set; }
        public DbSet<RoomAmenities> RoomAmenities { get; set; }
        public DbSet<HotelRoom> HotelRoom { get; set; }
    }
}
