using Microsoft.EntityFrameworkCore.Migrations;

namespace Async_Inn.Migrations
{
    public partial class fixData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelRoom_Room_RoomID",
                table: "HotelRoom");

            migrationBuilder.DropIndex(
                name: "IX_HotelRoom_RoomID",
                table: "HotelRoom");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Room",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Hotel",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Hotel",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Hotel",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Amenities",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HotelRoom_RoomNumber",
                table: "HotelRoom",
                column: "RoomNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_HotelRoom_Room_RoomNumber",
                table: "HotelRoom",
                column: "RoomNumber",
                principalTable: "Room",
                principalColumn: "RoomID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelRoom_Room_RoomNumber",
                table: "HotelRoom");

            migrationBuilder.DropIndex(
                name: "IX_HotelRoom_RoomNumber",
                table: "HotelRoom");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Room",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Hotel",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Hotel",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Hotel",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Amenities",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_HotelRoom_RoomID",
                table: "HotelRoom",
                column: "RoomID");

            migrationBuilder.AddForeignKey(
                name: "FK_HotelRoom_Room_RoomID",
                table: "HotelRoom",
                column: "RoomID",
                principalTable: "Room",
                principalColumn: "RoomID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
