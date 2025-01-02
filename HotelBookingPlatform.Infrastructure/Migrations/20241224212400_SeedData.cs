using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelBookingPlatform.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EndsDate",
                table: "FeaturedDeals",
                newName: "EndDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificationDate",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificationDate",
                table: "RoomImages",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocationOnMap",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "HotelImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificationDate",
                table: "HotelImages",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "Country", "CreationDate", "ModificationDate", "Name", "NumberOfHotels", "PostOffice" },
                values: new object[,]
                {
                    { 1, "France", new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6300), null, "Paris", 1820, "75000" },
                    { 2, "UAE", new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6314), null, "Dubai", 783, "" },
                    { 3, "Singapore", new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6319), null, "Singapore", 395, "" },
                    { 4, "USA", new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6324), null, "New York City", 784, "10000" },
                    { 5, "India", new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6328), null, "Udaipur", 466, "303001" },
                    { 6, "Japan", new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6333), null, "Tokyo", 607, "1000000" },
                    { 7, "UK", new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6338), null, "London", 1258, "WC2N 5DU" },
                    { 8, "Thailand", new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6342), null, "Bangkok", 521, "10100" },
                    { 9, "Italy", new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6347), null, "Ravello", 132, "84010" },
                    { 10, "China", new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6352), null, "Hong Kong", 329, "999077" },
                    { 11, "Canada", new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6357), null, "Banff", 1481, "T1L 0A1" },
                    { 12, "China", new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6361), null, "Shanghai", 2500, "200000" },
                    { 13, "Australia", new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6364), null, "Sydney", 598, "2000" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreationDate", "Email", "FirstName", "LastName", "Location", "ModificationDate", "PasswordHash", "PhoneNumber", "Role" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6714), "user1@example.com", "", "", "", null, "hashedpassword1", "", "" },
                    { 2, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6721), "user2@example.com", "", "", "", null, "hashedpassword2", "", "" },
                    { 3, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6726), "user3@example.com", "", "", "", null, "hashedpassword3", "", "" },
                    { 4, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6730), "user4@example.com", "", "", "", null, "hashedpassword4", "", "" },
                    { 5, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6735), "user5@example.com", "", "", "", null, "hashedpassword5", "", "" },
                    { 6, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6739), "user6@example.com", "", "", "", null, "hashedpassword6", "", "" },
                    { 7, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6743), "user7@example.com", "", "", "", null, "hashedpassword7", "", "" },
                    { 8, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6747), "user8@example.com", "", "", "", null, "hashedpassword8", "", "" },
                    { 9, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6752), "user9@example.com", "", "", "", null, "hashedpassword9", "", "" },
                    { 10, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6756), "user10@example.com", "", "", "", null, "hashedpassword10", "", "" },
                    { 11, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6761), "user11@example.com", "", "", "", null, "hashedpassword11", "", "" },
                    { 12, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6765), "user12@example.com", "", "", "", null, "hashedpassword12", "", "" },
                    { 13, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6769), "user13@example.com", "", "", "", null, "hashedpassword13", "", "" },
                    { 14, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6774), "user14@example.com", "", "", "", null, "hashedpassword14", "", "" },
                    { 15, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6778), "user15@example.com", "", "", "", null, "hashedpassword15", "", "" },
                    { 16, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6783), "user16@example.com", "", "", "", null, "hashedpassword16", "", "" },
                    { 17, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6788), "user17@example.com", "", "", "", null, "hashedpassword17", "", "" }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "BookingId", "CheckInDate", "CheckOutDate", "CreationDate", "ModificationDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { 1, new DateOnly(2024, 6, 1), new DateOnly(2024, 6, 5), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4893), null, "Completed", 1200m, 1 },
                    { 2, new DateOnly(2024, 5, 10), new DateOnly(2024, 5, 15), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4907), null, "Completed", 2000m, 2 },
                    { 3, new DateOnly(2024, 7, 20), new DateOnly(2024, 7, 25), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4913), null, "Completed", 1500m, 3 },
                    { 4, new DateOnly(2024, 8, 5), new DateOnly(2024, 8, 10), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4918), null, "Completed", 1800m, 4 },
                    { 5, new DateOnly(2024, 9, 1), new DateOnly(2024, 9, 3), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4923), null, "Completed", 800m, 5 },
                    { 6, new DateOnly(2024, 10, 12), new DateOnly(2024, 10, 15), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4931), null, "Completed", 2200m, 6 },
                    { 7, new DateOnly(2024, 11, 5), new DateOnly(2024, 11, 8), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4978), null, "Completed", 1000m, 7 },
                    { 8, new DateOnly(2024, 4, 20), new DateOnly(2024, 4, 22), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4986), null, "Completed", 500m, 8 },
                    { 9, new DateOnly(2024, 6, 15), new DateOnly(2024, 6, 18), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4992), null, "Completed", 1100m, 9 },
                    { 10, new DateOnly(2024, 7, 1), new DateOnly(2024, 7, 6), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(5000), null, "Completed", 2500m, 10 },
                    { 11, new DateOnly(2024, 5, 1), new DateOnly(2024, 5, 3), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(5006), null, "Completed", 600m, 11 },
                    { 12, new DateOnly(2024, 10, 10), new DateOnly(2024, 10, 12), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(5012), null, "Completed", 700m, 12 },
                    { 13, new DateOnly(2024, 9, 15), new DateOnly(2024, 9, 20), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(5018), null, "Completed", 1600m, 13 },
                    { 14, new DateOnly(2024, 6, 1), new DateOnly(2024, 6, 5), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(5024), null, "Completed", 1200m, 14 },
                    { 15, new DateOnly(2024, 5, 10), new DateOnly(2024, 5, 15), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(5030), null, "Completed", 2000m, 2 },
                    { 16, new DateOnly(2024, 7, 20), new DateOnly(2024, 7, 25), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(5035), null, "Completed", 1500m, 3 },
                    { 17, new DateOnly(2024, 8, 5), new DateOnly(2024, 8, 10), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(5041), null, "Completed", 1800m, 4 },
                    { 18, new DateOnly(2024, 9, 1), new DateOnly(2024, 9, 3), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(5047), null, "Completed", 800m, 5 },
                    { 19, new DateOnly(2024, 10, 12), new DateOnly(2024, 10, 15), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(5053), null, "Completed", 2200m, 6 },
                    { 20, new DateOnly(2024, 11, 5), new DateOnly(2024, 11, 8), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(5059), null, "Completed", 1000m, 7 },
                    { 21, new DateOnly(2024, 4, 20), new DateOnly(2024, 4, 22), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(5063), null, "Completed", 500m, 8 },
                    { 22, new DateOnly(2024, 6, 15), new DateOnly(2024, 6, 18), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(5069), null, "Completed", 1100m, 9 },
                    { 23, new DateOnly(2024, 7, 1), new DateOnly(2024, 7, 6), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(5075), null, "Completed", 2500m, 10 },
                    { 24, new DateOnly(2024, 5, 1), new DateOnly(2024, 5, 3), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(5081), null, "Completed", 600m, 11 },
                    { 25, new DateOnly(2024, 10, 10), new DateOnly(2024, 10, 12), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(5086), null, "Completed", 700m, 12 },
                    { 26, new DateOnly(2024, 9, 15), new DateOnly(2024, 9, 20), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(5091), null, "Completed", 1600m, 13 },
                    { 27, new DateOnly(2024, 6, 1), new DateOnly(2024, 6, 5), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(5097), null, "Completed", 1200m, 1 },
                    { 28, new DateOnly(2024, 5, 10), new DateOnly(2024, 5, 15), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(5102), null, "Completed", 2000m, 14 },
                    { 29, new DateOnly(2024, 7, 20), new DateOnly(2024, 7, 25), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(5108), null, "Completed", 1500m, 15 },
                    { 30, new DateOnly(2024, 8, 5), new DateOnly(2024, 8, 10), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(5113), null, "Completed", 1800m, 4 },
                    { 31, new DateOnly(2024, 9, 1), new DateOnly(2024, 9, 3), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(5118), null, "Completed", 800m, 5 },
                    { 32, new DateOnly(2024, 10, 12), new DateOnly(2024, 10, 15), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(5123), null, "Completed", 2200m, 6 },
                    { 33, new DateOnly(2024, 11, 5), new DateOnly(2024, 11, 8), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(5129), null, "Completed", 1000m, 7 },
                    { 34, new DateOnly(2024, 4, 20), new DateOnly(2024, 4, 22), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(5138), null, "Completed", 500m, 8 },
                    { 35, new DateOnly(2024, 6, 15), new DateOnly(2024, 6, 18), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(5144), null, "Completed", 1100m, 9 },
                    { 36, new DateOnly(2024, 7, 1), new DateOnly(2024, 7, 6), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(5150), null, "Completed", 2500m, 10 },
                    { 37, new DateOnly(2024, 5, 1), new DateOnly(2024, 5, 3), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(5156), null, "Completed", 600m, 11 },
                    { 38, new DateOnly(2024, 10, 10), new DateOnly(2024, 10, 12), new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(5162), null, "Completed", 5000m, 12 }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelId", "Amenities", "CityId", "CreationDate", "Description", "Location", "LocationOnMap", "ModificationDate", "Name", "Owner", "Rating" },
                values: new object[,]
                {
                    { 1, "Free Wi-Fi, Spa, Fine Dining, Gym, Concierge Services, Pet-Friendly", 1, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6446), "A luxurious haven of elegance situated in the heart of Paris.", "15 Pl. Vendôme, 75001 Paris, France", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2624.4814062467813!2d2.3263182763411403!3d48.868098671333605!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x47e66f50e4922355%3A0x4e7e02b37682a099!2sRitz%20Paris!5e0!3m2!1sen!2s!4v1735056728204!5m2!1sen!2s\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", null, "The Ritz-Carlton, Paris", "Marriott International", 4.7f },
                    { 2, "Private Beach, Infinity Pool, Chauffeur Service, Michelin-Starred Restaurants, Spa", 2, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6458), "An architectural marvel rising above the Arabian Gulf.", "Umm Suqeim 3 - Dubai - United Arab Emirates", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d1805.9132661352926!2d55.1849783!3d25.14155485!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3e5f6a576414cf2d%3A0xb3da71b879f0e038!2sBurj%20Al%20Arab!5e0!3m2!1sen!2s!4v1735057005413!5m2!1sen!2s\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", null, "Burj Al Arab Jumeirah", "Jumeirah Group", 4.7f },
                    { 3, "Infinity Pool, Casino, Rooftop Bar, Shopping Mall, Theater", 3, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6464), "Famous for its rooftop infinity pool and breathtaking views of the Singapore skyline.", "10 Bayfront Ave, Singapore 018956", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3988.816878626558!2d103.8591065!3d1.2837574999999999!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x31da19ee4cc09203%3A0x26c9afefa555dd7!2sMarina%20Bay%20Sands%20Singapore!5e0!3m2!1sen!2s!4v1735057059546!5m2!1sen!2s\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", null, "Marina Bay Sands", "Las Vegas Sands Corporation", 4.7f },
                    { 4, "Afternoon Tea, Spa, Fine Dining, Event Spaces, Luxury Boutiques", 4, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6470), "Iconic luxury hotel on Fifth Avenue, renowned for its timeless elegance.", "768 5th Ave, New York, NY 10019, United States", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3021.8814631648033!2d-73.9743251!3d40.7646318!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x89c258f07d5da561%3A0x61f6aa300ba8339d!2sThe%20Plaza!5e0!3m2!1sen!2s!4v1735057101458!5m2!1sen!2s\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", null, "The Plaza, New York", "Katara Hospitality", 4.5f },
                    { 5, "Heritage Tours, Traditional Cuisine, Spa, Boat Rides, Yoga Classes", 5, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6477), "A floating palace on Lake Pichola, epitomizing royal grandeur.", "Lake, Pichola, Hawala Kalan, Udaipur, Rajasthan 313001, India", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3628.39865437172!2d73.68003!3d24.5754345!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3967efecf87f0b8b%3A0x2708953a0e177443!2sTaj%20Lake%20Palace%2C%20Udaipur!5e0!3m2!1sen!2s!4v1735057211683!5m2!1sen!2s\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", null, "Taj Lake Palace", "Tata Group", 4.8f },
                    { 6, "Rooftop Bar, Michelin-Star Dining, Spa, Business Center, Fitness Studio", 6, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6483), "A serene oasis in the heart of Tokyo, blending Japanese tradition with modern luxury.", "1 Chome-2-1 Ōtemachi, Chiyoda City, Tokyo 100-0004, Japan", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d6481.163587004862!2d139.75857051213367!3d35.687298196253174!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x60188d4fdf9d71ff%3A0xf06cbdfd6d5ce09e!2sFour%20Seasons%20Hotel%20Tokyo%20at%20Otemachi!5e0!3m2!1sen!2s!4v1735057369066!5m2!1sen!2s\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", null, "Four Seasons Hotel, Tokyo", "Four Seasons Hotels and Resorts", 4.4f },
                    { 7, "Afternoon Tea, Riverside Dining, Spa, Concierge", 7, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6489), "One of London's most iconic hotels, known for its heritage and grandeur.", "Strand, London WC2R 0EZ, United Kingdom", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2483.1585037438285!2d-0.1207561!3d51.510308!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x487604cbcfae5a4d%3A0x15f4effda4fbdc29!2sThe%20Savoy!5e0!3m2!1sen!2s!4v1735057436037!5m2!1sen!2s\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", null, "The Savoy", "Fairmont Hotels & Resorts", 4.7f },
                    { 8, "Riverfront Dining, Spa, Fitness Center, Pool", 8, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6494), "A riverside retreat offering legendary Thai hospitality.", "48 Oriental Ave, Bang Rak, Bangkok 10500, Thailand", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d1937.9517336700158!2d100.5126621!3d13.72429385!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x30e298c4c9a7a0b3%3A0xbb2ce336689cae5!2sMandarin%20Oriental%2C%20Bangkok!5e0!3m2!1sen!2s!4v1735057518382!5m2!1sen!2s\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", null, "Mandarin Oriental, Bangkok", "Mandarin Oriental Hotel Group", 4.7f },
                    { 9, "Infinity Pool, Terrace Dining, Spa, Gardens", 9, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6499), "A former palace set on cliffs, offering stunning views of the Amalfi Coast.", "Piazza S. Giovanni del Toro, 2, 84010 Ravello SA, Italy", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3027.0226460119015!2d14.612981099999999!3d40.6514312!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x133b959e2d70381f%3A0xec6cd160863392a7!2sCaruso%2C%20A%20Belmond%20Hotel%2C%20Amalfi%20Coast!5e0!3m2!1sen!2s!4v1735057558870!5m2!1sen!2s\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", null, "Belmond Hotel Caruso", "Belmond Ltd.", 4.7f },
                    { 10, "Rooftop Dining, Spa, Rolls-Royce Transfers, Art Deco Decor", 10, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6504), "Known as the 'Grande Dame of the Far East,' offering unmatched luxury.", "Salisbury Rd, Tsim Sha Tsui, Hong Kong", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3691.5480833445445!2d114.1718537!3d22.295102399999994!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x340400f249551975%3A0xefa3d013e6ba94ab!2sThe%20Peninsula%20Hong%20Kong!5e0!3m2!1sen!2s!4v1735057622452!5m2!1sen!2s\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", null, "The Peninsula Hong Kong", "The Hongkong and Shanghai Hotels, Limited", 4.5f },
                    { 11, "Heritage Suites, Courtyard Dining, Spa, Shopping Arcade", 3, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6510), "An iconic colonial-style luxury hotel, home of the Singapore Sling.", "1 Beach Rd, Singapore 189673", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3988.7994370111564!2d103.854483!3d1.2948890000000002!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x31da19a5bbca44c1%3A0x647f3845b65cdec2!2sRaffles%20Singapore!5e0!3m2!1sen!2s!4v1735057720523!5m2!1sen!2s\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", null, "Raffles Hotel", "Accor Hotels", 4.6f },
                    { 12, "Golf, Skiing, Spa, Fine Dining", 11, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6516), "A castle in the heart of the Canadian Rockies.", "405 Spray Ave, Banff, AB T1L 1J4, Canada", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2501.9705683837706!2d-115.56183!3d51.164331999999995!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x5370ca3b2e2fb8bf%3A0x99e9a92cf4f6ce!2sFairmont%20Banff%20Springs!5e0!3m2!1sen!2s!4v1735058605617!5m2!1sen!2s\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", null, "Fairmont Banff Springs", "Fairmont Hotels & Resorts", 4.7f },
                    { 13, "Spa, Terrace Dining, Butler Service, Art Collections", 1, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6522), "A historical landmark offering refined Parisian elegance.", "10 Pl. de la Concorde, 75008 Paris, France", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2624.524853421338!2d2.3210916!3d48.8672703!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x47e66fd2bde4f80b%3A0x7b976ab67fe636aa!2sHotel%20Crillon%2C%20A%20Rosewood%20Hotel!5e0!3m2!1sen!2s!4v1735058742431!5m2!1sen!2s\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", null, "Hotel de Crillon", "Rosewood Hotels & Resorts", 4.7f },
                    { 14, "Michelin-Starred Dining, Spa, Rooftop Bar", 12, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6621), "Combining timeless elegance with modern luxury on the Bund.", "China, Shanghai, Huangpu, 马当路99号 邮政编码: 200021", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3411.9615078098177!2d121.47429709999999!3d31.2217958!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x35b270720732849d%3A0x78d772e5546adad4!2z5LiK5rW35paw5aSp5Zyw5pyX5bu36YWS5bqX!5e0!3m2!1sen!2s!4v1735058872633!5m2!1sen!2s\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", null, "The Langham, Shanghai", "Langham Hospitality Group", 4.5f },
                    { 15, "Harborfront Dining, Spa, Rooftop Pool, Fitness Center", 13, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6629), "A contemporary waterfront retreat with views of the Sydney Opera House.", "7 Hickson Rd, The Rocks NSW 2000, Australia", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3313.315685281136!2d151.2093354!3d-33.8557543!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x6b12ae5d85cd8021%3A0x8bd10336683856bb!2sPark%20Hyatt%20Sydney!5e0!3m2!1sen!2s!4v1735058998436!5m2!1sen!2s\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", null, "Park Hyatt Sydney", "Hyatt Hotels Corporation", 4.6f }
                });

            migrationBuilder.InsertData(
                table: "FeaturedDeals",
                columns: new[] { "FeaturedDealId", "CreationDate", "DiscountedPrice", "EndDate", "HotelId", "ModificationDate", "OriginalPrice", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(7144), 674.33m, new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 750m, new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(7164), 1587.48m, new DateTime(2024, 12, 26, 0, 0, 0, 0, DateTimeKind.Local), 4, null, 1715m, new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(7175), 1024m, new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Local), 2, null, 1140m, new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 4, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(7187), 489.75m, new DateTime(2024, 12, 26, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 536.5m, new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 5, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(7198), 299m, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), 6, null, 400m, new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 6, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(7209), 595.5m, new DateTime(2024, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), 10, null, 630m, new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "HotelImages",
                columns: new[] { "HotelImageId", "CreationDate", "HotelId", "ImagePath", "ModificationDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(7283), 1, "https://innfinity.blob.core.windows.net/images/1TheRitzCarlton.jpg", null },
                    { 2, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(7289), 2, "https://innfinity.blob.core.windows.net/images/2BurjAlArab.jpg", null },
                    { 3, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(7293), 3, "https://innfinity.blob.core.windows.net/images/3MarinaBaySands.jpeg", null },
                    { 4, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(7296), 4, "https://innfinity.blob.core.windows.net/images/4ThePlaza.jpg", null },
                    { 5, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(7300), 5, "https://innfinity.blob.core.windows.net/images/5TajLakePalace.jpg", null },
                    { 6, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(7304), 6, "https://innfinity.blob.core.windows.net/images/6FourSeasons.jpg", null },
                    { 7, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(7308), 7, "https://innfinity.blob.core.windows.net/images/7TheSavoy.jpeg", null },
                    { 8, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(7312), 8, "https://innfinity.blob.core.windows.net/images/8MandarinOriental.jpg", null },
                    { 9, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(7315), 9, "https://innfinity.blob.core.windows.net/images/9BelmondHotelCaruso.jpg", null },
                    { 10, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(7318), 10, "https://innfinity.blob.core.windows.net/images/10ThePeninsula.png", null },
                    { 11, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(7322), 11, "https://innfinity.blob.core.windows.net/images/11Raffles.jpeg", null },
                    { 12, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(7325), 12, "https://innfinity.blob.core.windows.net/images/12FairmontBanffSprings.jpg", null },
                    { 13, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(7329), 13, "https://innfinity.blob.core.windows.net/images/13HoteldeCrillon.png", null },
                    { 14, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(7333), 14, "https://innfinity.blob.core.windows.net/images/14TheLangham.jpeg", null },
                    { 15, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(7337), 15, "https://innfinity.blob.core.windows.net/images/15ParkHyatt.jpg", null }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "CreationDate", "HotelId", "IsConfirmedBooking", "ModificationDate", "ReviewText", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6868), 1, true, null, "Absolutely loved the elegance and charm of The Ritz-Carlton in Paris. Exceptional service!", 1 },
                    { 2, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6876), 1, true, null, "The rooms were immaculate and the food was divine. Perfect romantic getaway.", 2 },
                    { 3, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6880), 2, true, null, "Burj Al Arab truly lives up to its reputation. A luxurious experience like no other.", 3 },
                    { 4, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6884), 2, true, null, "The staff went above and beyond to make our stay memorable. The views are unforgettable!", 4 },
                    { 5, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6888), 3, true, null, "The infinity pool at Marina Bay Sands is breathtaking. Worth every penny!", 5 },
                    { 6, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6892), 3, true, null, "Fantastic location with world-class facilities. Highly recommend the Skyline Suite.", 6 },
                    { 7, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6896), 4, true, null, "The Plaza offers a classic NYC luxury stay. Amazing location and incredible staff.", 7 },
                    { 8, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6900), 4, true, null, "From the iconic decor to the warm hospitality, everything was perfect. A must-visit!", 8 },
                    { 9, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6904), 5, true, null, "Taj Lake Palace feels like a dream. Stunning architecture and serene atmosphere.", 9 },
                    { 10, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6908), 5, true, null, "A truly royal experience. The lake views and heritage charm are unparalleled.", 10 },
                    { 11, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6911), 6, true, null, "Four Seasons in Tokyo is a perfect blend of modern luxury and traditional charm.", 11 },
                    { 12, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6915), 6, true, null, "An oasis of calm in the bustling city. The terrace views are stunning!", 12 },
                    { 13, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6919), 7, true, null, "The Savoy exceeded my expectations. Iconic and timeless, with top-notch hospitality.", 13 },
                    { 14, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6923), 7, true, null, "Beautiful interiors and excellent service. Perfect for a special occasion.", 14 },
                    { 15, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6928), 8, true, null, "The Mandarin Oriental redefines luxury in Bangkok. Exceptional attention to detail.", 15 },
                    { 16, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6932), 8, true, null, "The spa experience was heavenly. Highly recommend for a relaxing retreat.", 1 },
                    { 17, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6936), 9, true, null, "Belmond Hotel Caruso is a slice of paradise. The infinity pool is a dream!", 2 },
                    { 18, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6940), 9, true, null, "Charming and picturesque. The sea view suite is worth every cent.", 3 },
                    { 19, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6944), 10, true, null, "The Peninsula offers timeless luxury and impeccable service. A true gem.", 4 },
                    { 20, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6949), 10, true, null, "The harbor view is spectacular. A luxurious stay with unforgettable memories.", 5 },
                    { 21, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6952), 11, true, null, "Raffles Hotel is steeped in history. Loved the colonial charm and excellent service.", 6 },
                    { 22, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6955), 11, true, null, "The courtyard was serene and the heritage suite was exceptional.", 7 },
                    { 23, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6959), 12, true, null, "The Fairmont Banff Springs is a fairytale come true. Stunning mountain views!", 8 },
                    { 24, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6963), 12, true, null, "A magical experience in the Rockies. The Royal Suite is pure luxury.", 9 },
                    { 25, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6968), 13, true, null, "Hotel de Crillon is an embodiment of Parisian luxury. Incredible attention to detail.", 10 },
                    { 26, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6972), 13, true, null, "The Grands Appartements Suite is extraordinary. A flawless stay in every way.", 11 },
                    { 27, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6976), 14, true, null, "The Langham combines modern luxury with classic elegance. A fantastic experience.", 12 },
                    { 28, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6980), 14, true, null, "The Chairman Suite offers unparalleled comfort and sophistication. Loved it!", 13 },
                    { 29, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6984), 15, true, null, "The Park Hyatt Sydney offers the best views of the Opera House. A true gem.", 14 },
                    { 30, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(6987), 15, true, null, "The Sydney Suite is a dream! Outstanding service and breathtaking location.", 15 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomId", "AdultsCapacity", "ChildrenCapacity", "CreationDate", "HotelId", "IsAvailable", "ModificationDate", "Number", "Price", "Type" },
                values: new object[,]
                {
                    { 1, 2, 1, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4421), 1, true, null, "201", 800m, "Deluxe Room" },
                    { 2, 3, 2, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4494), 1, true, null, "465", 1500m, "Executive Suite" },
                    { 3, 4, 2, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4501), 1, false, null, "1055", 5000m, "Presidential Suite" },
                    { 4, 2, 1, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4507), 1, true, null, "774", 3000m, "Junior Suite" },
                    { 5, 2, 0, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4513), 1, true, null, "612", 1200m, "Luxury King Room" },
                    { 6, 2, 1, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4527), 2, false, null, "1077", 1500m, "Deluxe Marina Suite" },
                    { 7, 3, 2, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4532), 2, true, null, "1133", 3000m, "Panoramic Suite" },
                    { 8, 4, 2, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4537), 2, true, null, "1174", 10000m, "Royal Two-Bedroom Suite" },
                    { 9, 2, 1, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4543), 2, true, null, "1200", 5000m, "Sky Suite" },
                    { 10, 2, 1, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4551), 2, false, null, "304", 2000m, "Club Room" },
                    { 11, 2, 1, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4557), 3, true, null, "105", 400m, "Deluxe Room" },
                    { 12, 3, 1, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4563), 3, true, null, "513", 700m, "Club Room" },
                    { 13, 4, 2, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4570), 3, true, null, "1101", 1200m, "Orchid Suite" },
                    { 14, 4, 2, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4577), 3, true, null, "1901", 2500m, "Skyline Suite" },
                    { 15, 4, 2, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4583), 3, false, null, "2000", 3500m, "Presidential Suite" },
                    { 16, 2, 1, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4589), 4, true, null, "161", 900m, "Deluxe Room" },
                    { 17, 3, 1, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4595), 4, true, null, "641", 1500m, "Junior Suite" },
                    { 18, 4, 2, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4603), 4, true, null, "883", 7000m, "Royal Suite" },
                    { 19, 4, 2, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4607), 4, true, null, "914", 4000m, "Penthouse Suite" },
                    { 20, 2, 1, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4612), 4, true, null, "555", 1800m, "Luxury King Room" },
                    { 21, 2, 1, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4691), 5, true, null, "122", 600m, "Luxury Room" },
                    { 22, 3, 1, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4698), 5, false, null, "804", 1200m, "Royal Suite" },
                    { 23, 4, 2, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4704), 5, true, null, "901", 3500m, "Grand Presidential Suite" },
                    { 24, 4, 2, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4710), 5, true, null, "735", 2500m, "Maharaja Suite" },
                    { 25, 2, 1, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4716), 5, true, null, "345", 1000m, "Lake View Room" },
                    { 26, 2, 1, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4722), 6, true, null, "430", 700m, "Premier Room" },
                    { 27, 3, 1, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4728), 6, false, null, "815", 1200m, "Executive Suite" },
                    { 28, 4, 2, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4734), 6, true, null, "910", 4000m, "Presidential Suite" },
                    { 29, 2, 1, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4740), 6, true, null, "1074", 2000m, "Terrace Suite" },
                    { 31, 2, 1, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4745), 7, true, null, "564", 1000m, "Luxury King Room" },
                    { 32, 3, 2, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4750), 7, false, null, "661", 2500m, "Junior Suite" },
                    { 33, 4, 2, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4754), 7, true, null, "2530", 6000m, "Thames View Suite" },
                    { 34, 2, 1, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4759), 8, true, null, "2042", 900m, "Deluxe Room" },
                    { 35, 3, 2, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4766), 8, true, null, "2068", 2000m, "Garden Suite" },
                    { 36, 4, 2, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4771), 8, true, null, "3125", 5000m, "Presidential Suite" },
                    { 37, 2, 1, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4776), 9, true, null, "240", 1200m, "Classic Room" },
                    { 38, 3, 2, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4782), 9, true, null, "6069", 3000m, "Sea View Suite" },
                    { 39, 4, 2, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4787), 9, true, null, "3307", 8000m, "Infinity Pool Suite" },
                    { 40, 2, 1, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4792), 10, true, null, "4036", 1100m, "Deluxe Harbor View Room" },
                    { 41, 3, 2, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4797), 10, true, null, "7004", 3000m, "Grand Suite" },
                    { 42, 4, 2, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4802), 10, false, null, "4004", 7500m, "Peninsula Suite" },
                    { 43, 2, 1, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4807), 11, false, null, "432", 800m, "Courtyard Room" },
                    { 44, 3, 2, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4812), 11, true, null, "969", 2500m, "Heritage Suite" },
                    { 45, 4, 2, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4817), 11, true, null, "992", 6000m, "Presidential Suite" },
                    { 46, 2, 1, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4823), 12, true, null, "1005", 700m, "Fairmont Room" },
                    { 47, 3, 2, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4828), 12, true, null, "1107", 2200m, "Mountain View Suite" },
                    { 48, 4, 2, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4834), 12, false, null, "1247", 5000m, "Royal Suite" },
                    { 49, 2, 1, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4840), 13, true, null, "4017", 1200m, "Premier Room" },
                    { 50, 3, 2, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4846), 13, true, null, "7096", 3000m, "Signature Suite" },
                    { 51, 4, 2, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4851), 13, true, null, "1700", 7000m, "Grands Appartements Suite" },
                    { 52, 2, 1, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4857), 14, true, null, "308", 850m, "Deluxe River View Room" },
                    { 53, 3, 2, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4863), 14, true, null, "717", 2000m, "Junior Suite" },
                    { 54, 4, 2, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4869), 14, false, null, "914", 6000m, "Chairman Suite" },
                    { 55, 2, 1, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4874), 15, true, null, "310", 1100m, "Harbor View Room" },
                    { 56, 3, 2, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4881), 15, true, null, "473", 2500m, "Opera View Suite" },
                    { 57, 4, 2, new DateTime(2024, 12, 24, 23, 23, 59, 300, DateTimeKind.Local).AddTicks(4886), 15, true, null, "1010", 7000m, "Sydney Suite" }
                });

            migrationBuilder.InsertData(
                table: "BookingRoom",
                columns: new[] { "BookingsBookingId", "RoomsRoomId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 3 },
                    { 3, 8 },
                    { 4, 10 },
                    { 5, 11 },
                    { 6, 15 },
                    { 7, 17 },
                    { 8, 16 },
                    { 9, 21 },
                    { 10, 22 },
                    { 11, 26 },
                    { 12, 29 },
                    { 13, 32 },
                    { 14, 33 },
                    { 15, 38 },
                    { 16, 39 },
                    { 17, 41 },
                    { 18, 42 },
                    { 19, 44 },
                    { 20, 46 },
                    { 21, 47 },
                    { 22, 48 },
                    { 23, 52 },
                    { 24, 51 },
                    { 25, 53 },
                    { 26, 53 },
                    { 27, 35 },
                    { 27, 36 },
                    { 28, 56 },
                    { 29, 57 },
                    { 30, 27 },
                    { 31, 23 },
                    { 32, 36 },
                    { 33, 50 },
                    { 34, 49 },
                    { 35, 6 },
                    { 36, 9 },
                    { 37, 31 },
                    { 38, 4 },
                    { 38, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 5, 11 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 6, 15 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 7, 17 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 8, 16 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 9, 21 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 10, 22 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 11, 26 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 12, 29 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 13, 32 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 14, 33 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 15, 38 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 16, 39 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 17, 41 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 18, 42 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 19, 44 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 20, 46 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 21, 47 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 22, 48 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 23, 52 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 24, 51 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 25, 53 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 26, 53 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 27, 35 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 27, 36 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 28, 56 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 29, 57 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 30, 27 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 31, 23 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 32, 36 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 33, 50 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 34, 49 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 35, 6 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 36, 9 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 37, 31 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 38, 4 });

            migrationBuilder.DeleteData(
                table: "BookingRoom",
                keyColumns: new[] { "BookingsBookingId", "RoomsRoomId" },
                keyValues: new object[] { 38, 5 });

            migrationBuilder.DeleteData(
                table: "FeaturedDeals",
                keyColumn: "FeaturedDealId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FeaturedDeals",
                keyColumn: "FeaturedDealId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FeaturedDeals",
                keyColumn: "FeaturedDealId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FeaturedDeals",
                keyColumn: "FeaturedDealId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FeaturedDeals",
                keyColumn: "FeaturedDealId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FeaturedDeals",
                keyColumn: "FeaturedDealId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "HotelImageId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 13);

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ModificationDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "RoomImages");

            migrationBuilder.DropColumn(
                name: "ModificationDate",
                table: "RoomImages");

            migrationBuilder.DropColumn(
                name: "LocationOnMap",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "HotelImages");

            migrationBuilder.DropColumn(
                name: "ModificationDate",
                table: "HotelImages");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "FeaturedDeals",
                newName: "EndsDate");
        }
    }
}
