using Microsoft.EntityFrameworkCore.Migrations;

namespace Async_Inn.Migrations
{
    public partial class dataseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "AmenitiesID", "Name" },
                values: new object[,]
                {
                    { 1, "Coffee Maker" },
                    { 2, "Air Conditioning" },
                    { 3, "Waterfront View" },
                    { 4, "Mini-bar" },
                    { 5, "Personal Chef" }
                });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "HotelID", "Address", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "123 Forest Dr", "Evergreen Inn", "206-555-5555" },
                    { 2, "123 Tree St", "Birch Inn", "206-555-4444" },
                    { 3, "123 Branch St", "Oak Hotel", "206-555-6666" },
                    { 4, "123 Fir Dr", "Pine Inn", "206-555-7777" },
                    { 5, "123 Needle St", "Douglas Fir Hotel", "206-555-8888" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "RoomID", "Layout", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Cedar" },
                    { 2, 2, "Redwood" },
                    { 3, 0, "Maple" },
                    { 4, 1, "Juniper" },
                    { 5, 2, "Maple" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenitiesID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenitiesID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenitiesID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenitiesID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenitiesID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "HotelID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "HotelID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "HotelID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "HotelID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "HotelID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 5);
        }
    }
}
