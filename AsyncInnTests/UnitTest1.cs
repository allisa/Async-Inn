using Async_Inn.Data;
using Async_Inn.Models;
using Microsoft.EntityFrameworkCore;
using System;
using Xunit;

namespace AsyncInnTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Test to get an amenity
        /// </summary>
        [Fact]
        public void TestGetAmenityName()
        {
            Amenities amenity = new Amenities();
            amenity.Name = "TestAmenity";

            Assert.Equal("TestAmenity", amenity.Name);
        }

        /// <summary>
        /// Test to set an amenity name
        /// </summary>
        [Fact]
        public void TestSetAmenityName()
        {
            Amenities amenity = new Amenities();
            amenity.Name = "TestAmenity";

            amenity.Name = "TestAmenity2";

            Assert.Equal("TestAmenity2", amenity.Name);
        }

        /// <summary>
        /// Test to get a hotel name, address, phone
        /// </summary>
        [Fact]
        public void TestGetHotelInfo()
        {
            Hotel hotel = new Hotel();
            hotel.Name = "TestHotel";
            hotel.Address = "123 Test";
            hotel.Phone = "555-555-5555";

            Assert.Equal("TestHotel", hotel.Name);
            Assert.Equal("123 Test", hotel.Address);
            Assert.Equal("555-555-5555", hotel.Phone);
        }

        /// <summary>
        /// Test to set a hotel name, address, phone
        /// </summary>
        [Fact]
        public void TestSetHotelInfo()
        {
            Hotel hotel = new Hotel();
            hotel.Name = "TestHotel";
            hotel.Address = "123 Test";
            hotel.Phone = "555-555-5555";

            hotel.Name = "TestHotel2";
            hotel.Address = "456 Test";
            hotel.Phone = "666-555-5555";

            Assert.Equal("TestHotel2", hotel.Name);
            Assert.Equal("456 Test", hotel.Address);
            Assert.Equal("666-555-5555", hotel.Phone);
        }

        /// <summary>
        /// Test to get a hotel room number, rate, and pet friendly
        /// </summary>
        [Fact]
        public void TestGetHotelRoomInfo()
        {
            HotelRoom hotelRoom = new HotelRoom();
            hotelRoom.RoomNumber = 444;
            hotelRoom.Rate = 100;
            hotelRoom.PetFriendly = true;

            Assert.Equal(444, hotelRoom.RoomNumber);
            Assert.Equal(100, hotelRoom.Rate);
            Assert.True(hotelRoom.PetFriendly);
        }

        /// <summary>
        /// Test to set a hotel room number, rate, and pet friendly
        /// </summary>
        [Fact]
        public void TestSetHotelRoomInfo()
        {
            HotelRoom hotelRoom = new HotelRoom();
            hotelRoom.RoomNumber = 444;
            hotelRoom.Rate = 100;
            hotelRoom.PetFriendly = true;

            hotelRoom.RoomNumber = 222;
            hotelRoom.Rate = 200;
            hotelRoom.PetFriendly = false;

            Assert.Equal(222, hotelRoom.RoomNumber);
            Assert.Equal(200, hotelRoom.Rate);
            Assert.False(hotelRoom.PetFriendly);
        }

        /// <summary>
        /// Test to get a room name and layout
        /// </summary>
        [Fact]
        public void TestGetRoomInfo()
        {
            Room room = new Room();
            room.Name = "TestRoom";
            room.Layout = Layout.OneBedroom;

            Assert.Equal("TestRoom", room.Name);
            Assert.Equal(Layout.OneBedroom, room.Layout);
        }

        /// <summary>
        /// Test to set a room name and layout
        /// </summary>
        [Fact]
        public void TestSetRoomInfo()
        {
            Room room = new Room();
            room.Name = "TestRoom";
            room.Layout = Layout.OneBedroom;

            room.Name = "TestRoom2";
            room.Layout = Layout.Studio;

            Assert.Equal("TestRoom2", room.Name);
            Assert.Equal(Layout.Studio, room.Layout);
        }

        /// <summary>
        /// Test to get room amenities
        /// </summary>
        [Fact]
        public void TestGetRoomAmenities()
        {
            RoomAmenities roomAmenities = new RoomAmenities();
            Amenities amenity = new Amenities();
            roomAmenities.Amenities = amenity;
            amenity.Name = "TestAmenity";

            Assert.Equal("TestAmenity", amenity.Name);
        }

        /// <summary>
        /// Test to set room amenities
        /// </summary>
        [Fact]
        public void TestSetRoomAmenities()
        {
            RoomAmenities roomAmenities = new RoomAmenities();
            Amenities amenity = new Amenities();
            roomAmenities.Amenities = amenity;
            amenity.Name = "TestAmenity";

            amenity.Name = "TestAmenity2";

            Assert.Equal("TestAmenity2", amenity.Name);
        }

        /// <summary>
        /// Test to create and read amenities
        /// </summary>
        [Fact]
        public async void TestToSaveAmenity()
        {
            DbContextOptions<AsyncInnDbContext> options =
                new DbContextOptionsBuilder<AsyncInnDbContext>()
                .UseInMemoryDatabase("GetAmenityName")
                .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                Amenities amenity = new Amenities();
                amenity.Name = "TestAmenity";

                context.Amenities.Add(amenity);
                context.SaveChanges();

                var amenityName = await context.Amenities.FirstOrDefaultAsync(a => a.Name == amenity.Name);

                Assert.Equal("TestAmenity", amenityName.Name);
            }
        }

        /// <summary>
        /// Test to update amenities
        /// </summary>
        [Fact]
        public async void TestToUpdateAmenityInDB()
        {
            DbContextOptions<AsyncInnDbContext> options =
                new DbContextOptionsBuilder<AsyncInnDbContext>()
                .UseInMemoryDatabase("GetAmenityName")
                .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                Amenities amenity = new Amenities();
                amenity.Name = "TestAmenity";

                amenity.Name = "TestAmenity2";

                context.Amenities.Update(amenity);
                context.SaveChanges();

                var amenityName = await context.Amenities.FirstOrDefaultAsync(a => a.Name == amenity.Name);

                Assert.Equal("TestAmenity2", amenityName.Name);
            }
        }

        /// <summary>
        /// Test to delete an amenity
        /// </summary>
        [Fact]
        public async void TestToDeleteAmenityInDB()
        {
            DbContextOptions<AsyncInnDbContext> options =
                new DbContextOptionsBuilder<AsyncInnDbContext>()
                .UseInMemoryDatabase("GetAmenityName")
                .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                Amenities amenity = new Amenities();
                amenity.Name = "TestAmenity";

                context.Amenities.Add(amenity);
                context.SaveChanges();

                context.Amenities.Remove(amenity);
                context.SaveChanges();

                var amenities = await context.Amenities.ToListAsync();

                Assert.DoesNotContain(amenity, amenities);
            }
        }

        /// <summary>
        /// Test to create on hotels table in database
        /// </summary>
        [Fact]
        public async void TestToSaveHotel()
        {
            DbContextOptions<AsyncInnDbContext> options =
                new DbContextOptionsBuilder<AsyncInnDbContext>()
                .UseInMemoryDatabase("GetHotelName")
                .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                Hotel hotel = new Hotel();
                hotel.Name = "HotelTest";

                context.Hotel.Add(hotel);
                context.SaveChanges();

                var hotelName = await context.Hotel.FirstOrDefaultAsync(h => h.Name == hotel.Name);

                Assert.Equal("HotelTest", hotelName.Name);
            }
        }

        /// <summary>
        /// Test to update on hotels table in database
        /// </summary>
        [Fact]
        public async void TestToUpdateHotelInDB()
        {
            DbContextOptions<AsyncInnDbContext> options =
                new DbContextOptionsBuilder<AsyncInnDbContext>()
                .UseInMemoryDatabase("GetHotelName")
                .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                Hotel hotel = new Hotel();
                hotel.Name = "HotelTest";

                context.Hotel.Add(hotel);
                context.SaveChanges();

                hotel.Name = "TestHotel2";

                context.Hotel.Update(hotel);
                context.SaveChanges();

                var hotelName = await context.Hotel.FirstOrDefaultAsync(x => x.Name == hotel.Name);

                Assert.Equal("TestHotel2", hotelName.Name);
            }
        }

        /// <summary>
        /// Test to delete on hotels table in database
        /// </summary>
        [Fact]
        public async void TestToDeleteOnHotels()
        {
            DbContextOptions<AsyncInnDbContext> options =
                new DbContextOptionsBuilder<AsyncInnDbContext>()
                .UseInMemoryDatabase("GetHotelName")
                .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                Hotel hotel = new Hotel();
                hotel.Name = "TestHotel";

                context.Hotel.Add(hotel);
                context.SaveChanges();

                context.Hotel.Remove(hotel);
                context.SaveChanges();

                var hotels = await context.Hotel.ToListAsync();

                Assert.DoesNotContain(hotel, hotels);
            }
        }

        /// <summary>
        /// Test to create on rooms table in database
        /// </summary>
        [Fact]
        public async void TestToCreateRoomDB()
        {
            DbContextOptions<AsyncInnDbContext> options =
                new DbContextOptionsBuilder<AsyncInnDbContext>()
                .UseInMemoryDatabase("GetRoomName")
                .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                Room room = new Room();
                room.Name = "TestRoom";

                context.Room.Add(room);
                context.SaveChanges();

                var roomName = await context.Room.FirstOrDefaultAsync(x => x.Name == room.Name);

                Assert.Equal("TestRoom", roomName.Name);
            }
        }

        /// <summary>
        /// Test to update rooms table in database
        /// </summary>
        [Fact]
        public async void TestToUpdateRoomsDB()
        {
            DbContextOptions<AsyncInnDbContext> options =
                new DbContextOptionsBuilder<AsyncInnDbContext>()
                .UseInMemoryDatabase("GetRoomName")
                .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                Room room = new Room();
                room.Name = "TestRoom";

                context.Room.Add(room);
                context.SaveChanges();

                room.Name = "TestRoom2";

                context.Room.Update(room);
                context.SaveChanges();

                var roomName = await context.Room.FirstOrDefaultAsync(x => x.Name == room.Name);

                Assert.Equal("TestRoom2", roomName.Name);
            }
        }

        /// <summary>
        /// Test to delete on room table in database
        /// </summary>
        [Fact]
        public async void TestToDeleteRoomTableDB()
        {
            DbContextOptions<AsyncInnDbContext> options =
                new DbContextOptionsBuilder<AsyncInnDbContext>()
                .UseInMemoryDatabase("GetRoomName")
                .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                Room room = new Room();
                room.Name = "TestRoom";

                context.Room.Add(room);
                context.SaveChanges();

                context.Room.Remove(room);
                context.SaveChanges();

                var rooms = await context.Room.ToListAsync();

                Assert.DoesNotContain(room, rooms);
            }
        }

        /// <summary>
        /// Test to create on hotel rooms table in database
        /// </summary>
        [Fact]
        public async void CanSaveHotelRoomsDB()
        {
            DbContextOptions<AsyncInnDbContext> options =
                new DbContextOptionsBuilder<AsyncInnDbContext>()
                .UseInMemoryDatabase("GetHotelRoomRate")
                .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                HotelRoom hotelRoom = new HotelRoom();
                hotelRoom.Rate = 200;

                context.HotelRoom.Add(hotelRoom);
                context.SaveChanges();

                var hotelRate = await context.HotelRoom.FirstOrDefaultAsync(h => h.Rate == hotelRoom.Rate);

                Assert.Equal(200, hotelRate.Rate);
            }
        }

        /// <summary>
        /// Test to update hotel rooms table in database
        /// </summary>
        [Fact]
        public async void TestToUpdateHotelRoom()
        {
            DbContextOptions<AsyncInnDbContext> options =
                new DbContextOptionsBuilder<AsyncInnDbContext>()
                .UseInMemoryDatabase("GetHotelRoomRate")
                .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                HotelRoom hotelRoom = new HotelRoom();
                hotelRoom.Rate = 100;

                context.HotelRoom.Add(hotelRoom);
                context.SaveChanges();

                hotelRoom.Rate = 200;

                context.HotelRoom.Update(hotelRoom);
                context.SaveChanges();

                var hotelRate = await context.HotelRoom.FirstOrDefaultAsync(hr => hr.Rate == hotelRoom.Rate);

                Assert.Equal(200, hotelRate.Rate);
            }
        }

        /// <summary>
        /// Test to delete hotel rooms in database
        /// </summary>
        [Fact]
        public async void TestToDeleteHotelRoom()
        {
            DbContextOptions<AsyncInnDbContext> options =
                new DbContextOptionsBuilder<AsyncInnDbContext>()
                .UseInMemoryDatabase("GetHotelRoomName")
                .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                HotelRoom hotelRoom = new HotelRoom();
                hotelRoom.Rate = 100;

                context.HotelRoom.Add(hotelRoom);
                context.SaveChanges();

                context.HotelRoom.Remove(hotelRoom);
                context.SaveChanges();

                var hotelrooms = await context.HotelRoom.ToListAsync();

                Assert.DoesNotContain(hotelRoom, hotelrooms);
            }
        }

        /// <summary>
        /// Test to create on room amenities table
        /// </summary>
        [Fact]
        public async void CanSaveRoomAmenityDb()
        {
            DbContextOptions<AsyncInnDbContext> options =
                new DbContextOptionsBuilder<AsyncInnDbContext>()
                .UseInMemoryDatabase("GetRoomAmenityName")
                .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                Amenities amenity = new Amenities();
                amenity.Name = "TestAmenity";
                RoomAmenities roomAmenity = new RoomAmenities();
                roomAmenity.Amenities = amenity;

                context.RoomAmenities.Add(roomAmenity);
                context.SaveChanges();

                var amenityName = await context.RoomAmenities.FirstOrDefaultAsync(ra => ra.Amenities == amenity);

                Assert.Contains("TestAmenity", amenityName.Amenities.Name);
            }
        }

        /// <summary>
        /// Test to delete room amenities table
        /// </summary>
        [Fact]
        public async void TestToDeleteRoomAmenities()
        {
            DbContextOptions<AsyncInnDbContext> options =
                new DbContextOptionsBuilder<AsyncInnDbContext>()
                .UseInMemoryDatabase("GetRoomAmenityName")
                .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                RoomAmenities roomAmenity = new RoomAmenities();
                Amenities amenity = new Amenities();
                amenity.Name = "TestAmenity";

                roomAmenity.Amenities = amenity;

                context.RoomAmenities.Add(roomAmenity);
                context.SaveChanges();

                context.RoomAmenities.Remove(roomAmenity);
                context.SaveChanges();

                var roomamenities = await context.RoomAmenities.ToListAsync();

                Assert.DoesNotContain(roomAmenity, roomamenities);
            }
        }
    }
}
