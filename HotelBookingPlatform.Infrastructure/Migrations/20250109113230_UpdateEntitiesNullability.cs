using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelBookingPlatform.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEntitiesNullability : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Users_UserId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_FeaturedDeals_Hotels_HotelId",
                table: "FeaturedDeals");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelImages_Hotels_HotelId",
                table: "HotelImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Cities_CityId",
                table: "Hotels");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Hotels_HotelId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_UserId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomImages_Rooms_RoomId",
                table: "RoomImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Hotels_HotelId",
                table: "Rooms");

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Rooms",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "IsAvailable",
                table: "Rooms",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "HotelId",
                table: "Rooms",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Rooms",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "ChildrenCapacity",
                table: "Rooms",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AdultsCapacity",
                table: "Rooms",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RoomId",
                table: "RoomImages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "RoomImages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "RoomImages",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Reviews",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ReviewText",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "IsConfirmedBooking",
                table: "Reviews",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "HotelId",
                table: "Reviews",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Reviews",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<float>(
                name: "Rating",
                table: "Hotels",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<string>(
                name: "Owner",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LocationOnMap",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Hotels",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "Hotels",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Amenities",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "HotelImages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "HotelId",
                table: "HotelImages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "HotelImages",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "FeaturedDeals",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<decimal>(
                name: "OriginalPrice",
                table: "FeaturedDeals",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "HotelId",
                table: "FeaturedDeals",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "FeaturedDeals",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<decimal>(
                name: "DiscountedPrice",
                table: "FeaturedDeals",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "FeaturedDeals",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "PostOffice",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "NumberOfHotels",
                table: "Cities",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Cities",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Bookings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPrice",
                table: "Bookings",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "CheckOutDate",
                table: "Bookings",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "CheckInDate",
                table: "Bookings",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1212));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1282));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1318));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 15,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 16,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 17,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 18,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 19,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 20,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 21,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 22,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 23,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 24,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1566));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 25,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 26,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1578));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 27,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1585));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 28,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1591));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 29,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1598));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 30,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 31,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 32,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1615));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 33,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 34,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 35,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 36,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 37,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 38,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1656));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(2698));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(2743));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(2754));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "FeaturedDeals",
                keyColumn: "FeaturedDealId",
                keyValue: 1,
                columns: new[] { "CreationDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3409), new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FeaturedDeals",
                keyColumn: "FeaturedDealId",
                keyValue: 2,
                columns: new[] { "CreationDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3431), new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FeaturedDeals",
                keyColumn: "FeaturedDealId",
                keyValue: 3,
                columns: new[] { "CreationDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3444), new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FeaturedDeals",
                keyColumn: "FeaturedDealId",
                keyValue: 4,
                columns: new[] { "CreationDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3459), new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FeaturedDeals",
                keyColumn: "FeaturedDealId",
                keyValue: 5,
                columns: new[] { "CreationDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3482), new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FeaturedDeals",
                keyColumn: "FeaturedDealId",
                keyValue: 6,
                columns: new[] { "CreationDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3497), new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3677));

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 15,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(2829));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(2894));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(2904));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 15,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(2908));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3199));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 15,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 16,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 17,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 18,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 19,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 20,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 21,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 22,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 23,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 24,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 25,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 26,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 27,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 28,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 29,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 30,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3314));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 15,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 16,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(894));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 17,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(898));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 18,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 19,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 20,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 21,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 22,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 23,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 24,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 25,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 26,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 27,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 28,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 29,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 31,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 32,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 33,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 34,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 35,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 36,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 37,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1105));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 38,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 39,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 40,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 41,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 42,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 43,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 44,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 45,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 46,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 47,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 48,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1158));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 49,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1163));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 50,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1167));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 51,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1171));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 52,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 53,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 54,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 55,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1193));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 56,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 57,
                column: "CreationDate",
                value: new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreationDate", "FirstName", "LastName", "Location", "PhoneNumber" },
                values: new object[] { new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(2980), null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreationDate", "FirstName", "LastName", "Location", "PhoneNumber" },
                values: new object[] { new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(2987), null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreationDate", "FirstName", "LastName", "Location", "PhoneNumber" },
                values: new object[] { new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(2991), null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreationDate", "FirstName", "LastName", "Location", "PhoneNumber" },
                values: new object[] { new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(2995), null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreationDate", "FirstName", "LastName", "Location", "PhoneNumber" },
                values: new object[] { new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(2999), null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreationDate", "FirstName", "LastName", "Location", "PhoneNumber" },
                values: new object[] { new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3003), null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreationDate", "FirstName", "LastName", "Location", "PhoneNumber" },
                values: new object[] { new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3007), null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreationDate", "FirstName", "LastName", "Location", "PhoneNumber" },
                values: new object[] { new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3011), null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreationDate", "FirstName", "LastName", "Location", "PhoneNumber" },
                values: new object[] { new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3016), null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreationDate", "FirstName", "LastName", "Location", "PhoneNumber" },
                values: new object[] { new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3091), null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "CreationDate", "FirstName", "LastName", "Location", "PhoneNumber" },
                values: new object[] { new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3098), null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "CreationDate", "FirstName", "LastName", "Location", "PhoneNumber" },
                values: new object[] { new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3101), null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "CreationDate", "FirstName", "LastName", "Location", "PhoneNumber" },
                values: new object[] { new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3105), null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "CreationDate", "FirstName", "LastName", "Location", "PhoneNumber" },
                values: new object[] { new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3109), null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "CreationDate", "FirstName", "LastName", "Location", "PhoneNumber" },
                values: new object[] { new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3113), null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "CreationDate", "FirstName", "LastName", "Location", "PhoneNumber" },
                values: new object[] { new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3117), null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "CreationDate", "FirstName", "LastName", "Location", "PhoneNumber" },
                values: new object[] { new DateTime(2025, 1, 9, 13, 32, 29, 702, DateTimeKind.Local).AddTicks(3121), null, null, null, null });

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Users_UserId",
                table: "Bookings",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_FeaturedDeals_Hotels_HotelId",
                table: "FeaturedDeals",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "HotelId");

            migrationBuilder.AddForeignKey(
                name: "FK_HotelImages_Hotels_HotelId",
                table: "HotelImages",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "HotelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_Cities_CityId",
                table: "Hotels",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Hotels_HotelId",
                table: "Reviews",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "HotelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomImages_Rooms_RoomId",
                table: "RoomImages",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Hotels_HotelId",
                table: "Rooms",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "HotelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Users_UserId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_FeaturedDeals_Hotels_HotelId",
                table: "FeaturedDeals");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelImages_Hotels_HotelId",
                table: "HotelImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Cities_CityId",
                table: "Hotels");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Hotels_HotelId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_UserId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomImages_Rooms_RoomId",
                table: "RoomImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Hotels_HotelId",
                table: "Rooms");

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Rooms",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsAvailable",
                table: "Rooms",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HotelId",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ChildrenCapacity",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AdultsCapacity",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RoomId",
                table: "RoomImages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "RoomImages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Reviews",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReviewText",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsConfirmedBooking",
                table: "Reviews",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HotelId",
                table: "Reviews",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Rating",
                table: "Hotels",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Owner",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LocationOnMap",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Hotels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "Hotels",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Amenities",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "HotelImages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HotelId",
                table: "HotelImages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "HotelImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "FeaturedDeals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OriginalPrice",
                table: "FeaturedDeals",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HotelId",
                table: "FeaturedDeals",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "FeaturedDeals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DiscountedPrice",
                table: "FeaturedDeals",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "FeaturedDeals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostOffice",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NumberOfHotels",
                table: "Cities",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Cities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPrice",
                table: "Bookings",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "CheckOutDate",
                table: "Bookings",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "CheckInDate",
                table: "Bookings",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 15,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 16,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 17,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 18,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 19,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(1093));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 20,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 21,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 22,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(1106));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 23,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 24,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 25,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 26,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 27,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 28,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 29,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 30,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 31,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 32,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(1152));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 33,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(1156));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 34,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(1162));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 35,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 36,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(1171));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 37,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(1175));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 38,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2551));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2555));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2562));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "FeaturedDeals",
                keyColumn: "FeaturedDealId",
                keyValue: 1,
                columns: new[] { "CreationDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3354), new DateTime(2025, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 12, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FeaturedDeals",
                keyColumn: "FeaturedDealId",
                keyValue: 2,
                columns: new[] { "CreationDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3372), new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 12, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FeaturedDeals",
                keyColumn: "FeaturedDealId",
                keyValue: 3,
                columns: new[] { "CreationDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3381), new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 12, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FeaturedDeals",
                keyColumn: "FeaturedDealId",
                keyValue: 4,
                columns: new[] { "CreationDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3389), new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 12, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FeaturedDeals",
                keyColumn: "FeaturedDealId",
                keyValue: 5,
                columns: new[] { "CreationDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3398), new DateTime(2024, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 12, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FeaturedDeals",
                keyColumn: "FeaturedDealId",
                keyValue: 6,
                columns: new[] { "CreationDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3405), new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 12, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3465));

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3468));

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3475));

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3499));

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 15,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2636));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2785));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 15,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3134));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3137));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3143));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3146));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3156));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 15,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 16,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 17,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 18,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 19,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 20,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 21,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 22,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 23,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 24,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 25,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 26,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 27,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 28,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 29,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 30,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(617));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 15,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 16,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 17,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 18,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 19,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 20,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 21,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 22,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(779));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 23,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 24,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 25,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 26,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 27,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 28,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 29,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 31,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 32,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 33,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 34,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 35,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 36,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 37,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 38,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 39,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 40,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 41,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 42,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 43,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 44,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 45,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 46,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(895));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 47,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 48,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 49,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 50,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(916));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 51,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 52,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 53,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 54,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 55,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 56,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 57,
                column: "CreationDate",
                value: new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreationDate", "FirstName", "LastName", "Location", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2869), "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreationDate", "FirstName", "LastName", "Location", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2877), "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreationDate", "FirstName", "LastName", "Location", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2882), "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreationDate", "FirstName", "LastName", "Location", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2886), "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreationDate", "FirstName", "LastName", "Location", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2890), "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreationDate", "FirstName", "LastName", "Location", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2894), "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreationDate", "FirstName", "LastName", "Location", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2898), "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreationDate", "FirstName", "LastName", "Location", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2903), "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreationDate", "FirstName", "LastName", "Location", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2907), "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreationDate", "FirstName", "LastName", "Location", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2911), "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "CreationDate", "FirstName", "LastName", "Location", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2915), "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "CreationDate", "FirstName", "LastName", "Location", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2918), "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "CreationDate", "FirstName", "LastName", "Location", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2922), "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "CreationDate", "FirstName", "LastName", "Location", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2926), "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "CreationDate", "FirstName", "LastName", "Location", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2930), "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "CreationDate", "FirstName", "LastName", "Location", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2934), "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "CreationDate", "FirstName", "LastName", "Location", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 12, 26, 10, 9, 42, 390, DateTimeKind.Local).AddTicks(2938), "", "", "", "" });

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Users_UserId",
                table: "Bookings",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FeaturedDeals_Hotels_HotelId",
                table: "FeaturedDeals",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "HotelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelImages_Hotels_HotelId",
                table: "HotelImages",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "HotelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_Cities_CityId",
                table: "Hotels",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "CityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Hotels_HotelId",
                table: "Reviews",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "HotelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomImages_Rooms_RoomId",
                table: "RoomImages",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "RoomId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Hotels_HotelId",
                table: "Rooms",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "HotelId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
