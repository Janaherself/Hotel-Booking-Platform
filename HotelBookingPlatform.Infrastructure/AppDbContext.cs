using HotelBookingPlatform.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingPlatform.Infrastructure
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<FeaturedDeal> FeaturedDeals { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelImage> HotelImages { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomImage> RoomImages { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-5RBHM2O9;Database=HotelBookingDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var bookingRoomBuilder = modelBuilder.Entity("BookingRoom");

            var rooms = new List<Room>
            {
                new() { RoomId = 1, HotelId = 1, Number = "201", Price = 800, AdultsCapacity = 2, ChildrenCapacity = 1, Type = "Deluxe Room", IsAvailable = true },
                new() { RoomId = 2, HotelId = 1, Number = "465", Price = 1500, AdultsCapacity = 3, ChildrenCapacity = 2, Type = "Executive Suite", IsAvailable = true },
                new() { RoomId = 3, HotelId = 1, Number = "1055", Price = 5000, AdultsCapacity = 4, ChildrenCapacity = 2, Type = "Presidential Suite", IsAvailable = false },
                new() { RoomId = 4, HotelId = 1, Number = "774", Price = 3000, AdultsCapacity = 2, ChildrenCapacity = 1, Type = "Junior Suite", IsAvailable = true },
                new() { RoomId = 5, HotelId = 1, Number = "612", Price = 1200, AdultsCapacity = 2, ChildrenCapacity = 0, Type = "Luxury King Room", IsAvailable = true },
                new() { RoomId = 6, HotelId = 2, Number = "1077", Price = 1500, AdultsCapacity = 2, ChildrenCapacity = 1, Type = "Deluxe Marina Suite", IsAvailable = false },
                new() { RoomId = 7, HotelId = 2, Number = "1133", Price = 3000, AdultsCapacity = 3, ChildrenCapacity = 2, Type = "Panoramic Suite", IsAvailable = true },
                new() { RoomId = 8, HotelId = 2, Number = "1174", Price = 10000, AdultsCapacity = 4, ChildrenCapacity = 2, Type = "Royal Two-Bedroom Suite", IsAvailable = true },
                new() { RoomId = 9, HotelId = 2, Number = "1200", Price = 5000, AdultsCapacity = 2, ChildrenCapacity = 1, Type = "Sky Suite", IsAvailable = true },
                new() { RoomId = 10, HotelId = 2, Number = "304", Price = 2000, AdultsCapacity = 2, ChildrenCapacity = 1, Type = "Club Room", IsAvailable = false },
                new() { RoomId = 11, HotelId = 3, Number = "105", Price = 400, AdultsCapacity = 2, ChildrenCapacity = 1, Type = "Deluxe Room", IsAvailable = true },
                new() { RoomId = 12, HotelId = 3, Number = "513", Price = 700, AdultsCapacity = 3, ChildrenCapacity = 1, Type = "Club Room", IsAvailable = true },
                new() { RoomId = 13, HotelId = 3, Number = "1101", Price = 1200, AdultsCapacity = 4, ChildrenCapacity = 2, Type = "Orchid Suite", IsAvailable = true },
                new() { RoomId = 14, HotelId = 3, Number = "1901", Price = 2500, AdultsCapacity = 4, ChildrenCapacity = 2, Type = "Skyline Suite", IsAvailable = true },
                new() { RoomId = 15, HotelId = 3, Number = "2000", Price = 3500, AdultsCapacity = 4, ChildrenCapacity = 2, Type = "Presidential Suite", IsAvailable = false },
                new() { RoomId = 16, HotelId = 4, Number = "161", Price = 900, AdultsCapacity = 2, ChildrenCapacity = 1, Type = "Deluxe Room", IsAvailable = true },
                new() { RoomId = 17, HotelId = 4, Number = "641", Price = 1500, AdultsCapacity = 3, ChildrenCapacity = 1, Type = "Junior Suite", IsAvailable = true },
                new() { RoomId = 18, HotelId = 4, Number = "883", Price = 7000, AdultsCapacity = 4, ChildrenCapacity = 2, Type = "Royal Suite", IsAvailable = true },
                new() { RoomId = 19, HotelId = 4, Number = "914", Price = 4000, AdultsCapacity = 4, ChildrenCapacity = 2, Type = "Penthouse Suite", IsAvailable = true },
                new() { RoomId = 20, HotelId = 4, Number = "555", Price = 1800, AdultsCapacity = 2, ChildrenCapacity = 1, Type = "Luxury King Room", IsAvailable = true },
                new() { RoomId = 21, HotelId = 5, Number = "122", Price = 600, AdultsCapacity = 2, ChildrenCapacity = 1, Type = "Luxury Room", IsAvailable = true },
                new() { RoomId = 22, HotelId = 5, Number = "804", Price = 1200, AdultsCapacity = 3, ChildrenCapacity = 1, Type = "Royal Suite", IsAvailable = false },
                new() { RoomId = 23, HotelId = 5, Number = "901", Price = 3500, AdultsCapacity = 4, ChildrenCapacity = 2, Type = "Grand Presidential Suite", IsAvailable = true },
                new() { RoomId = 24, HotelId = 5, Number = "735", Price = 2500, AdultsCapacity = 4, ChildrenCapacity = 2, Type = "Maharaja Suite", IsAvailable = true },
                new() { RoomId = 25, HotelId = 5, Number = "345", Price = 1000, AdultsCapacity = 2, ChildrenCapacity = 1, Type = "Lake View Room", IsAvailable = true },
                new() { RoomId = 26, HotelId = 6, Number = "430", Price = 700, AdultsCapacity = 2, ChildrenCapacity = 1, Type = "Premier Room", IsAvailable = true },
                new() { RoomId = 27, HotelId = 6, Number = "815", Price = 1200, AdultsCapacity = 3, ChildrenCapacity = 1, Type = "Executive Suite", IsAvailable = false },
                new() { RoomId = 28, HotelId = 6, Number = "910", Price = 4000, AdultsCapacity = 4, ChildrenCapacity = 2, Type = "Presidential Suite", IsAvailable = true },
                new() { RoomId = 29, HotelId = 6, Number = "1074", Price = 2000, AdultsCapacity = 2, ChildrenCapacity = 1, Type = "Terrace Suite", IsAvailable = true },
                new() { RoomId = 31, HotelId = 7, Number = "564", Price = 1000, AdultsCapacity = 2, ChildrenCapacity = 1, Type = "Luxury King Room", IsAvailable = true },
                new() { RoomId = 32, HotelId = 7, Number = "661", Price = 2500, AdultsCapacity = 3, ChildrenCapacity = 2, Type = "Junior Suite", IsAvailable = false },
                new() { RoomId = 33, HotelId = 7, Number = "2530", Price = 6000, AdultsCapacity = 4, ChildrenCapacity = 2, Type = "Thames View Suite", IsAvailable = true },
                new() { RoomId = 34, HotelId = 8, Number = "2042", Price = 900, AdultsCapacity = 2, ChildrenCapacity = 1, Type = "Deluxe Room", IsAvailable = true },
                new() { RoomId = 35, HotelId = 8, Number = "2068", Price = 2000, AdultsCapacity = 3, ChildrenCapacity = 2, Type = "Garden Suite", IsAvailable = true },
                new() { RoomId = 36, HotelId = 8, Number = "3125", Price = 5000, AdultsCapacity = 4, ChildrenCapacity = 2, Type = "Presidential Suite", IsAvailable = true },
                new() { RoomId = 37, HotelId = 9, Number = "240", Price = 1200, AdultsCapacity = 2, ChildrenCapacity = 1, Type = "Classic Room", IsAvailable = true },
                new() { RoomId = 38, HotelId = 9, Number = "6069", Price = 3000, AdultsCapacity = 3, ChildrenCapacity = 2, Type = "Sea View Suite", IsAvailable = true },
                new() { RoomId = 39, HotelId = 9, Number = "3307", Price = 8000, AdultsCapacity = 4, ChildrenCapacity = 2, Type = "Infinity Pool Suite", IsAvailable = true },
                new() { RoomId = 40, HotelId = 10, Number = "4036", Price = 1100, AdultsCapacity = 2, ChildrenCapacity = 1, Type = "Deluxe Harbor View Room", IsAvailable = true },
                new() { RoomId = 41, HotelId = 10, Number = "7004", Price = 3000, AdultsCapacity = 3, ChildrenCapacity = 2, Type = "Grand Suite", IsAvailable = true },
                new() { RoomId = 42, HotelId = 10, Number = "4004", Price = 7500, AdultsCapacity = 4, ChildrenCapacity = 2, Type = "Peninsula Suite", IsAvailable = false },
                new() { RoomId = 43, HotelId = 11, Number = "432", Price = 800, AdultsCapacity = 2, ChildrenCapacity = 1, Type = "Courtyard Room", IsAvailable = false },
                new() { RoomId = 44, HotelId = 11, Number = "969", Price = 2500, AdultsCapacity = 3, ChildrenCapacity = 2, Type = "Heritage Suite", IsAvailable = true },
                new() { RoomId = 45, HotelId = 11, Number = "992", Price = 6000, AdultsCapacity = 4, ChildrenCapacity = 2, Type = "Presidential Suite", IsAvailable = true },
                new() { RoomId = 46, HotelId = 12, Number = "1005", Price = 700, AdultsCapacity = 2, ChildrenCapacity = 1, Type = "Fairmont Room", IsAvailable = true },
                new() { RoomId = 47, HotelId = 12, Number = "1107", Price = 2200, AdultsCapacity = 3, ChildrenCapacity = 2, Type = "Mountain View Suite", IsAvailable = true },
                new() { RoomId = 48, HotelId = 12, Number = "1247", Price = 5000, AdultsCapacity = 4, ChildrenCapacity = 2, Type = "Royal Suite", IsAvailable = false },
                new() { RoomId = 49, HotelId = 13, Number = "4017", Price = 1200, AdultsCapacity = 2, ChildrenCapacity = 1, Type = "Premier Room", IsAvailable = true },
                new() { RoomId = 50, HotelId = 13, Number = "7096", Price = 3000, AdultsCapacity = 3, ChildrenCapacity = 2, Type = "Signature Suite", IsAvailable = true },
                new() { RoomId = 51, HotelId = 13, Number = "1700", Price = 7000, AdultsCapacity = 4, ChildrenCapacity = 2, Type = "Grands Appartements Suite", IsAvailable = true },
                new() { RoomId = 52, HotelId = 14, Number = "308", Price = 850, AdultsCapacity = 2, ChildrenCapacity = 1, Type = "Deluxe River View Room", IsAvailable = true },
                new() { RoomId = 53, HotelId = 14, Number = "717", Price = 2000, AdultsCapacity = 3, ChildrenCapacity = 2, Type = "Junior Suite", IsAvailable = true },
                new() { RoomId = 54, HotelId = 14, Number = "914", Price = 6000, AdultsCapacity = 4, ChildrenCapacity = 2, Type = "Chairman Suite", IsAvailable = false },
                new() { RoomId = 55, HotelId = 15, Number = "310", Price = 1100, AdultsCapacity = 2, ChildrenCapacity = 1, Type = "Harbor View Room", IsAvailable = true },
                new() { RoomId = 56, HotelId = 15, Number = "473", Price = 2500, AdultsCapacity = 3, ChildrenCapacity = 2, Type = "Opera View Suite", IsAvailable = true },
                new() { RoomId = 57, HotelId = 15, Number = "1010", Price = 7000, AdultsCapacity = 4, ChildrenCapacity = 2, Type = "Sydney Suite", IsAvailable = true }
            };

            var bookings = new List<Booking>
            {
                new() { BookingId = 1, UserId = 1, CheckInDate = new DateOnly(2024, 6, 1), CheckOutDate = new DateOnly(2024, 6, 5), TotalPrice = 1200, Status = "Completed" },
                new() { BookingId = 2, UserId = 2, CheckInDate = new DateOnly(2024, 5, 10), CheckOutDate = new DateOnly(2024, 5, 15), TotalPrice = 2000, Status = "Completed" },
                new() { BookingId = 3, UserId = 3, CheckInDate = new DateOnly(2024, 7, 20), CheckOutDate = new DateOnly(2024, 7, 25), TotalPrice = 1500, Status = "Completed" },
                new() { BookingId = 4, UserId = 4, CheckInDate = new DateOnly(2024, 8, 5), CheckOutDate = new DateOnly(2024, 8, 10), TotalPrice = 1800, Status = "Completed" },
                new() { BookingId = 5, UserId = 5, CheckInDate = new DateOnly(2024, 9, 1), CheckOutDate = new DateOnly(2024, 9, 3), TotalPrice = 800, Status = "Completed" },
                new() { BookingId = 6, UserId = 6, CheckInDate = new DateOnly(2024, 10, 12), CheckOutDate = new DateOnly(2024, 10, 15), TotalPrice = 2200, Status = "Completed" },
                new() { BookingId = 7, UserId = 7, CheckInDate = new DateOnly(2024, 11, 5), CheckOutDate = new DateOnly(2024, 11, 8), TotalPrice = 1000, Status = "Completed" },
                new() { BookingId = 8, UserId = 8, CheckInDate = new DateOnly(2024, 4, 20), CheckOutDate = new DateOnly(2024, 4, 22), TotalPrice = 500, Status = "Completed" },
                new() { BookingId = 9, UserId = 9, CheckInDate = new DateOnly(2024, 6, 15), CheckOutDate = new DateOnly(2024, 6, 18), TotalPrice = 1100, Status = "Completed" },
                new() { BookingId = 10, UserId = 10, CheckInDate = new DateOnly(2024, 7, 1), CheckOutDate = new DateOnly(2024, 7, 6), TotalPrice = 2500, Status = "Completed" },
                new() { BookingId = 11, UserId = 11, CheckInDate = new DateOnly(2024, 5, 1), CheckOutDate = new DateOnly(2024, 5, 3), TotalPrice = 600, Status = "Completed" },
                new() { BookingId = 12, UserId = 12, CheckInDate = new DateOnly(2024, 10, 10), CheckOutDate = new DateOnly(2024, 10, 12), TotalPrice = 700, Status = "Completed" },
                new() { BookingId = 13, UserId = 13, CheckInDate = new DateOnly(2024, 9, 15), CheckOutDate = new DateOnly(2024, 9, 20), TotalPrice = 1600, Status = "Completed" },
                new() { BookingId = 14, UserId = 14, CheckInDate = new DateOnly(2024, 6, 1), CheckOutDate = new DateOnly(2024, 6, 5), TotalPrice = 1200, Status = "Completed" },
                new() { BookingId = 15, UserId = 2, CheckInDate = new DateOnly(2024, 5, 10), CheckOutDate = new DateOnly(2024, 5, 15), TotalPrice = 2000, Status = "Completed" },
                new() { BookingId = 16, UserId = 3, CheckInDate = new DateOnly(2024, 7, 20), CheckOutDate = new DateOnly(2024, 7, 25), TotalPrice = 1500, Status = "Completed" },
                new() { BookingId = 17, UserId = 4, CheckInDate = new DateOnly(2024, 8, 5), CheckOutDate = new DateOnly(2024, 8, 10), TotalPrice = 1800, Status = "Completed" },
                new() { BookingId = 18, UserId = 5, CheckInDate = new DateOnly(2024, 9, 1), CheckOutDate = new DateOnly(2024, 9, 3), TotalPrice = 800, Status = "Completed" },
                new() { BookingId = 19, UserId = 6, CheckInDate = new DateOnly(2024, 10, 12), CheckOutDate = new DateOnly(2024, 10, 15), TotalPrice = 2200, Status = "Completed" },
                new() { BookingId = 20, UserId = 7, CheckInDate = new DateOnly(2024, 11, 5), CheckOutDate = new DateOnly(2024, 11, 8), TotalPrice = 1000, Status = "Completed" },
                new() { BookingId = 21, UserId = 8, CheckInDate = new DateOnly(2024, 4, 20), CheckOutDate = new DateOnly(2024, 4, 22), TotalPrice = 500, Status = "Completed" },
                new() { BookingId = 22, UserId = 9, CheckInDate = new DateOnly(2024, 6, 15), CheckOutDate = new DateOnly(2024, 6, 18), TotalPrice = 1100, Status = "Completed" },
                new() { BookingId = 23, UserId = 10, CheckInDate = new DateOnly(2024, 7, 1), CheckOutDate = new DateOnly(2024, 7, 6), TotalPrice = 2500, Status = "Completed" },
                new() { BookingId = 24, UserId = 11, CheckInDate = new DateOnly(2024, 5, 1), CheckOutDate = new DateOnly(2024, 5, 3), TotalPrice = 600, Status = "Completed" },
                new() { BookingId = 25, UserId = 12, CheckInDate = new DateOnly(2024, 10, 10), CheckOutDate = new DateOnly(2024, 10, 12), TotalPrice = 700, Status = "Completed" },
                new() { BookingId = 26, UserId = 13, CheckInDate = new DateOnly(2024, 9, 15), CheckOutDate = new DateOnly(2024, 9, 20), TotalPrice = 1600, Status = "Completed" },
                new() { BookingId = 27, UserId = 1, CheckInDate = new DateOnly(2024, 6, 1), CheckOutDate = new DateOnly(2024, 6, 5), TotalPrice = 1200, Status = "Completed" },
                new() { BookingId = 28, UserId = 14, CheckInDate = new DateOnly(2024, 5, 10), CheckOutDate = new DateOnly(2024, 5, 15), TotalPrice = 2000, Status = "Completed" },
                new() { BookingId = 29, UserId = 15, CheckInDate = new DateOnly(2024, 7, 20), CheckOutDate = new DateOnly(2024, 7, 25), TotalPrice = 1500, Status = "Completed" },
                new() { BookingId = 30, UserId = 4, CheckInDate = new DateOnly(2024, 8, 5), CheckOutDate = new DateOnly(2024, 8, 10), TotalPrice = 1800, Status = "Completed" },
                new() { BookingId = 31, UserId = 5, CheckInDate = new DateOnly(2024, 9, 1), CheckOutDate = new DateOnly(2024, 9, 3), TotalPrice = 800, Status = "Completed" },
                new() { BookingId = 32, UserId = 6, CheckInDate = new DateOnly(2024, 10, 12), CheckOutDate = new DateOnly(2024, 10, 15), TotalPrice = 2200, Status = "Completed" },
                new() { BookingId = 33, UserId = 7, CheckInDate = new DateOnly(2024, 11, 5), CheckOutDate = new DateOnly(2024, 11, 8), TotalPrice = 1000, Status = "Completed" },
                new() { BookingId = 34, UserId = 8, CheckInDate = new DateOnly(2024, 4, 20), CheckOutDate = new DateOnly(2024, 4, 22), TotalPrice = 500, Status = "Completed" },
                new() { BookingId = 35, UserId = 9, CheckInDate = new DateOnly(2024, 6, 15), CheckOutDate = new DateOnly(2024, 6, 18), TotalPrice = 1100, Status = "Completed" },
                new() { BookingId = 36, UserId = 10, CheckInDate = new DateOnly(2024, 7, 1), CheckOutDate = new DateOnly(2024, 7, 6), TotalPrice = 2500, Status = "Completed" },
                new() { BookingId = 37, UserId = 11, CheckInDate = new DateOnly(2024, 5, 1), CheckOutDate = new DateOnly(2024, 5, 3), TotalPrice = 600, Status = "Completed" },
                new() { BookingId = 38, UserId = 12, CheckInDate = new DateOnly(2024, 10, 10), CheckOutDate = new DateOnly(2024, 10, 12), TotalPrice = 5000, Status = "Completed" }
            };

            modelBuilder.Entity<Room>().HasData(rooms);

            modelBuilder.Entity<Booking>().HasData(bookings);

            bookingRoomBuilder.HasData(
                new { BookingsBookingId = bookings[0].BookingId, RoomsRoomId = rooms[0].RoomId },
                new { BookingsBookingId = bookings[0].BookingId, RoomsRoomId = rooms[1].RoomId },
                new { BookingsBookingId = bookings[1].BookingId, RoomsRoomId = rooms[2].RoomId },
                new { BookingsBookingId = bookings[2].BookingId, RoomsRoomId = rooms[7].RoomId },
                new { BookingsBookingId = bookings[3].BookingId, RoomsRoomId = rooms[9].RoomId },
                new { BookingsBookingId = bookings[4].BookingId, RoomsRoomId = rooms[10].RoomId },
                new { BookingsBookingId = bookings[5].BookingId, RoomsRoomId = rooms[14].RoomId },
                new { BookingsBookingId = bookings[6].BookingId, RoomsRoomId = rooms[16].RoomId },
                new { BookingsBookingId = bookings[7].BookingId, RoomsRoomId = rooms[15].RoomId },
                new { BookingsBookingId = bookings[8].BookingId, RoomsRoomId = rooms[20].RoomId },
                new { BookingsBookingId = bookings[9].BookingId, RoomsRoomId = rooms[21].RoomId },
                new { BookingsBookingId = bookings[10].BookingId, RoomsRoomId = rooms[25].RoomId },
                new { BookingsBookingId = bookings[11].BookingId, RoomsRoomId = rooms[28].RoomId },
                new { BookingsBookingId = bookings[12].BookingId, RoomsRoomId = rooms[30].RoomId },
                new { BookingsBookingId = bookings[13].BookingId, RoomsRoomId = rooms[31].RoomId },
                new { BookingsBookingId = bookings[14].BookingId, RoomsRoomId = rooms[36].RoomId },
                new { BookingsBookingId = bookings[15].BookingId, RoomsRoomId = rooms[37].RoomId },
                new { BookingsBookingId = bookings[16].BookingId, RoomsRoomId = rooms[39].RoomId },
                new { BookingsBookingId = bookings[17].BookingId, RoomsRoomId = rooms[40].RoomId },
                new { BookingsBookingId = bookings[18].BookingId, RoomsRoomId = rooms[42].RoomId },
                new { BookingsBookingId = bookings[19].BookingId, RoomsRoomId = rooms[44].RoomId },
                new { BookingsBookingId = bookings[20].BookingId, RoomsRoomId = rooms[45].RoomId },
                new { BookingsBookingId = bookings[21].BookingId, RoomsRoomId = rooms[46].RoomId },
                new { BookingsBookingId = bookings[22].BookingId, RoomsRoomId = rooms[50].RoomId },
                new { BookingsBookingId = bookings[23].BookingId, RoomsRoomId = rooms[49].RoomId },
                new { BookingsBookingId = bookings[24].BookingId, RoomsRoomId = rooms[51].RoomId },
                new { BookingsBookingId = bookings[25].BookingId, RoomsRoomId = rooms[51].RoomId },
                new { BookingsBookingId = bookings[26].BookingId, RoomsRoomId = rooms[33].RoomId },
                new { BookingsBookingId = bookings[26].BookingId, RoomsRoomId = rooms[34].RoomId },
                new { BookingsBookingId = bookings[27].BookingId, RoomsRoomId = rooms[54].RoomId },
                new { BookingsBookingId = bookings[28].BookingId, RoomsRoomId = rooms[55].RoomId },
                new { BookingsBookingId = bookings[29].BookingId, RoomsRoomId = rooms[26].RoomId },
                new { BookingsBookingId = bookings[30].BookingId, RoomsRoomId = rooms[22].RoomId },
                new { BookingsBookingId = bookings[31].BookingId, RoomsRoomId = rooms[34].RoomId },
                new { BookingsBookingId = bookings[32].BookingId, RoomsRoomId = rooms[48].RoomId },
                new { BookingsBookingId = bookings[33].BookingId, RoomsRoomId = rooms[47].RoomId },
                new { BookingsBookingId = bookings[34].BookingId, RoomsRoomId = rooms[5].RoomId },
                new { BookingsBookingId = bookings[35].BookingId, RoomsRoomId = rooms[8].RoomId },
                new { BookingsBookingId = bookings[36].BookingId, RoomsRoomId = rooms[29].RoomId },
                new { BookingsBookingId = bookings[37].BookingId, RoomsRoomId = rooms[3].RoomId },
                new { BookingsBookingId = bookings[37].BookingId, RoomsRoomId = rooms[4].RoomId }
            );

            modelBuilder.Entity<City>().HasData(
                    new City { CityId = 1, Name = "Paris", Country = "France", PostOffice = "75000", NumberOfHotels = 1820},
                    new City { CityId = 2, Name = "Dubai", Country = "UAE", PostOffice = "", NumberOfHotels = 783},
                    new City { CityId = 3, Name = "Singapore", Country = "Singapore", PostOffice = "", NumberOfHotels = 395},
                    new City { CityId = 4, Name = "New York City", Country = "USA", PostOffice = "10000", NumberOfHotels = 784},
                    new City { CityId = 5, Name = "Udaipur", Country = "India", PostOffice = "303001", NumberOfHotels = 466},
                    new City { CityId = 6, Name = "Tokyo", Country = "Japan", PostOffice = "1000000", NumberOfHotels = 607},
                    new City { CityId = 7, Name = "London", Country = "UK", PostOffice = "WC2N 5DU", NumberOfHotels = 1258},
                    new City { CityId = 8, Name = "Bangkok", Country = "Thailand", PostOffice = "10100", NumberOfHotels = 521},
                    new City { CityId = 9, Name = "Ravello", Country = "Italy", PostOffice = "84010", NumberOfHotels = 132},
                    new City { CityId = 10, Name = "Hong Kong", Country = "China", PostOffice = "999077", NumberOfHotels = 329},
                    new City { CityId = 11, Name = "Banff", Country = "Canada", PostOffice = "T1L 0A1", NumberOfHotels = 1481},
                    new City { CityId = 12, Name = "Shanghai", Country = "China", PostOffice = "200000", NumberOfHotels = 2500},
                    new City { CityId = 13, Name = "Sydney", Country = "Australia", PostOffice = "2000", NumberOfHotels = 598}
                );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel { HotelId = 1, CityId = 1, Name = "The Ritz-Carlton, Paris", Rating = 4.7f, Location = "15 Pl. Vendôme, 75001 Paris, France", Owner = "Marriott International", Description = "A luxurious haven of elegance situated in the heart of Paris.", Amenities = "Free Wi-Fi, Spa, Fine Dining, Gym, Concierge Services, Pet-Friendly", LocationOnMap = "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2624.4814062467813!2d2.3263182763411403!3d48.868098671333605!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x47e66f50e4922355%3A0x4e7e02b37682a099!2sRitz%20Paris!5e0!3m2!1sen!2s!4v1735056728204!5m2!1sen!2s\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>" },
                new Hotel { HotelId = 2, CityId = 2, Name = "Burj Al Arab Jumeirah", Rating = 4.7f, Location = "Umm Suqeim 3 - Dubai - United Arab Emirates", Owner = "Jumeirah Group", Description = "An architectural marvel rising above the Arabian Gulf.", Amenities = "Private Beach, Infinity Pool, Chauffeur Service, Michelin-Starred Restaurants, Spa", LocationOnMap = "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d1805.9132661352926!2d55.1849783!3d25.14155485!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3e5f6a576414cf2d%3A0xb3da71b879f0e038!2sBurj%20Al%20Arab!5e0!3m2!1sen!2s!4v1735057005413!5m2!1sen!2s\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>" },
                new Hotel { HotelId = 3, CityId = 3, Name = "Marina Bay Sands", Rating = 4.7f, Location = "10 Bayfront Ave, Singapore 018956", Owner = "Las Vegas Sands Corporation", Description = "Famous for its rooftop infinity pool and breathtaking views of the Singapore skyline.", Amenities = "Infinity Pool, Casino, Rooftop Bar, Shopping Mall, Theater", LocationOnMap = "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3988.816878626558!2d103.8591065!3d1.2837574999999999!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x31da19ee4cc09203%3A0x26c9afefa555dd7!2sMarina%20Bay%20Sands%20Singapore!5e0!3m2!1sen!2s!4v1735057059546!5m2!1sen!2s\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>" },
                new Hotel { HotelId = 4, CityId = 4, Name = "The Plaza, New York", Rating = 4.5f, Location = "768 5th Ave, New York, NY 10019, United States", Owner = "Katara Hospitality", Description = "Iconic luxury hotel on Fifth Avenue, renowned for its timeless elegance.", Amenities = "Afternoon Tea, Spa, Fine Dining, Event Spaces, Luxury Boutiques", LocationOnMap = "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3021.8814631648033!2d-73.9743251!3d40.7646318!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x89c258f07d5da561%3A0x61f6aa300ba8339d!2sThe%20Plaza!5e0!3m2!1sen!2s!4v1735057101458!5m2!1sen!2s\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>" },
                new Hotel { HotelId = 5, CityId = 5, Name = "Taj Lake Palace", Rating = 4.8f, Location = "Lake, Pichola, Hawala Kalan, Udaipur, Rajasthan 313001, India", Owner = "Tata Group", Description = "A floating palace on Lake Pichola, epitomizing royal grandeur.", Amenities = "Heritage Tours, Traditional Cuisine, Spa, Boat Rides, Yoga Classes", LocationOnMap = "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3628.39865437172!2d73.68003!3d24.5754345!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3967efecf87f0b8b%3A0x2708953a0e177443!2sTaj%20Lake%20Palace%2C%20Udaipur!5e0!3m2!1sen!2s!4v1735057211683!5m2!1sen!2s\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>" },
                new Hotel { HotelId = 6, CityId = 6, Name = "Four Seasons Hotel, Tokyo", Rating = 4.4f, Location = "1 Chome-2-1 Ōtemachi, Chiyoda City, Tokyo 100-0004, Japan", Owner = "Four Seasons Hotels and Resorts", Description = "A serene oasis in the heart of Tokyo, blending Japanese tradition with modern luxury.", Amenities = "Rooftop Bar, Michelin-Star Dining, Spa, Business Center, Fitness Studio", LocationOnMap = "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d6481.163587004862!2d139.75857051213367!3d35.687298196253174!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x60188d4fdf9d71ff%3A0xf06cbdfd6d5ce09e!2sFour%20Seasons%20Hotel%20Tokyo%20at%20Otemachi!5e0!3m2!1sen!2s!4v1735057369066!5m2!1sen!2s\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>" },
                new Hotel { HotelId = 7, CityId = 7, Name = "The Savoy", Rating = 4.7f, Location = "Strand, London WC2R 0EZ, United Kingdom", Owner = "Fairmont Hotels & Resorts", Description = "One of London's most iconic hotels, known for its heritage and grandeur.", Amenities = "Afternoon Tea, Riverside Dining, Spa, Concierge", LocationOnMap = "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2483.1585037438285!2d-0.1207561!3d51.510308!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x487604cbcfae5a4d%3A0x15f4effda4fbdc29!2sThe%20Savoy!5e0!3m2!1sen!2s!4v1735057436037!5m2!1sen!2s\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>" },
                new Hotel { HotelId = 8, CityId = 8, Name = "Mandarin Oriental, Bangkok", Rating = 4.7f, Location = "48 Oriental Ave, Bang Rak, Bangkok 10500, Thailand", Owner = "Mandarin Oriental Hotel Group", Description = "A riverside retreat offering legendary Thai hospitality.", Amenities = "Riverfront Dining, Spa, Fitness Center, Pool", LocationOnMap = "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d1937.9517336700158!2d100.5126621!3d13.72429385!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x30e298c4c9a7a0b3%3A0xbb2ce336689cae5!2sMandarin%20Oriental%2C%20Bangkok!5e0!3m2!1sen!2s!4v1735057518382!5m2!1sen!2s\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>" },
                new Hotel { HotelId = 9, CityId = 9, Name = "Belmond Hotel Caruso", Rating = 4.7f, Location = "Piazza S. Giovanni del Toro, 2, 84010 Ravello SA, Italy", Owner = "Belmond Ltd.", Description = "A former palace set on cliffs, offering stunning views of the Amalfi Coast.", Amenities = "Infinity Pool, Terrace Dining, Spa, Gardens", LocationOnMap = "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3027.0226460119015!2d14.612981099999999!3d40.6514312!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x133b959e2d70381f%3A0xec6cd160863392a7!2sCaruso%2C%20A%20Belmond%20Hotel%2C%20Amalfi%20Coast!5e0!3m2!1sen!2s!4v1735057558870!5m2!1sen!2s\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>" },
                new Hotel { HotelId = 10, CityId = 10, Name = "The Peninsula Hong Kong", Rating = 4.5f, Location = "Salisbury Rd, Tsim Sha Tsui, Hong Kong", Owner = "The Hongkong and Shanghai Hotels, Limited", Description = "Known as the 'Grande Dame of the Far East,' offering unmatched luxury.", Amenities = "Rooftop Dining, Spa, Rolls-Royce Transfers, Art Deco Decor", LocationOnMap = "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3691.5480833445445!2d114.1718537!3d22.295102399999994!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x340400f249551975%3A0xefa3d013e6ba94ab!2sThe%20Peninsula%20Hong%20Kong!5e0!3m2!1sen!2s!4v1735057622452!5m2!1sen!2s\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>" },
                new Hotel { HotelId = 11, CityId = 3, Name = "Raffles Hotel", Rating = 4.6f, Location = "1 Beach Rd, Singapore 189673", Owner = "Accor Hotels", Description = "An iconic colonial-style luxury hotel, home of the Singapore Sling.", Amenities = "Heritage Suites, Courtyard Dining, Spa, Shopping Arcade", LocationOnMap = "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3988.7994370111564!2d103.854483!3d1.2948890000000002!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x31da19a5bbca44c1%3A0x647f3845b65cdec2!2sRaffles%20Singapore!5e0!3m2!1sen!2s!4v1735057720523!5m2!1sen!2s\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>" },
                new Hotel { HotelId = 12, CityId = 11, Name = "Fairmont Banff Springs", Rating = 4.7f, Location = "405 Spray Ave, Banff, AB T1L 1J4, Canada", Owner = "Fairmont Hotels & Resorts", Description = "A castle in the heart of the Canadian Rockies.", Amenities = "Golf, Skiing, Spa, Fine Dining", LocationOnMap = "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2501.9705683837706!2d-115.56183!3d51.164331999999995!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x5370ca3b2e2fb8bf%3A0x99e9a92cf4f6ce!2sFairmont%20Banff%20Springs!5e0!3m2!1sen!2s!4v1735058605617!5m2!1sen!2s\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>" },
                new Hotel { HotelId = 13, CityId = 1, Name = "Hotel de Crillon", Rating = 4.7f, Location = "10 Pl. de la Concorde, 75008 Paris, France", Owner = "Rosewood Hotels & Resorts", Description = "A historical landmark offering refined Parisian elegance.", Amenities = "Spa, Terrace Dining, Butler Service, Art Collections", LocationOnMap = "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2624.524853421338!2d2.3210916!3d48.8672703!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x47e66fd2bde4f80b%3A0x7b976ab67fe636aa!2sHotel%20Crillon%2C%20A%20Rosewood%20Hotel!5e0!3m2!1sen!2s!4v1735058742431!5m2!1sen!2s\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>" },
                new Hotel { HotelId = 14, CityId = 12, Name = "The Langham, Shanghai", Rating = 4.5f, Location = "China, Shanghai, Huangpu, 马当路99号 邮政编码: 200021", Owner = "Langham Hospitality Group", Description = "Combining timeless elegance with modern luxury on the Bund.", Amenities = "Michelin-Starred Dining, Spa, Rooftop Bar", LocationOnMap = "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3411.9615078098177!2d121.47429709999999!3d31.2217958!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x35b270720732849d%3A0x78d772e5546adad4!2z5LiK5rW35paw5aSp5Zyw5pyX5bu36YWS5bqX!5e0!3m2!1sen!2s!4v1735058872633!5m2!1sen!2s\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>" },
                new Hotel { HotelId = 15, CityId = 13, Name = "Park Hyatt Sydney", Rating = 4.6f, Location = "7 Hickson Rd, The Rocks NSW 2000, Australia", Owner = "Hyatt Hotels Corporation", Description = "A contemporary waterfront retreat with views of the Sydney Opera House.", Amenities = "Harborfront Dining, Spa, Rooftop Pool, Fitness Center", LocationOnMap = "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3313.315685281136!2d151.2093354!3d-33.8557543!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x6b12ae5d85cd8021%3A0x8bd10336683856bb!2sPark%20Hyatt%20Sydney!5e0!3m2!1sen!2s!4v1735058998436!5m2!1sen!2s\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>" }
            );

            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, Email = "user1@example.com", PasswordHash = "hashedpassword1" },
                new User { UserId = 2, Email = "user2@example.com", PasswordHash = "hashedpassword2" },
                new User { UserId = 3, Email = "user3@example.com", PasswordHash = "hashedpassword3" },
                new User { UserId = 4, Email = "user4@example.com", PasswordHash = "hashedpassword4" },
                new User { UserId = 5, Email = "user5@example.com", PasswordHash = "hashedpassword5" },
                new User { UserId = 6, Email = "user6@example.com", PasswordHash = "hashedpassword6" },
                new User { UserId = 7, Email = "user7@example.com", PasswordHash = "hashedpassword7" },
                new User { UserId = 8, Email = "user8@example.com", PasswordHash = "hashedpassword8" },
                new User { UserId = 9, Email = "user9@example.com", PasswordHash = "hashedpassword9" },
                new User { UserId = 10, Email = "user10@example.com", PasswordHash = "hashedpassword10" },
                new User { UserId = 11, Email = "user11@example.com", PasswordHash = "hashedpassword11" },
                new User { UserId = 12, Email = "user12@example.com", PasswordHash = "hashedpassword12" },
                new User { UserId = 13, Email = "user13@example.com", PasswordHash = "hashedpassword13" },
                new User { UserId = 14, Email = "user14@example.com", PasswordHash = "hashedpassword14" },
                new User { UserId = 15, Email = "user15@example.com", PasswordHash = "hashedpassword15" },
                new User { UserId = 16, Email = "user16@example.com", PasswordHash = "hashedpassword16" },
                new User { UserId = 17, Email = "user17@example.com", PasswordHash = "hashedpassword17" }
            );

            modelBuilder.Entity<Review>().HasData(
                new Review { ReviewId = 1, UserId = 1, HotelId = 1, ReviewText = "Absolutely loved the elegance and charm of The Ritz-Carlton in Paris. Exceptional service!", IsConfirmedBooking = true },
                new Review { ReviewId = 2, UserId = 2, HotelId = 1, ReviewText = "The rooms were immaculate and the food was divine. Perfect romantic getaway.", IsConfirmedBooking = true },
                new Review { ReviewId = 3, UserId = 3, HotelId = 2, ReviewText = "Burj Al Arab truly lives up to its reputation. A luxurious experience like no other.", IsConfirmedBooking = true },
                new Review { ReviewId = 4, UserId = 4, HotelId = 2, ReviewText = "The staff went above and beyond to make our stay memorable. The views are unforgettable!", IsConfirmedBooking = true },
                new Review { ReviewId = 5, UserId = 5, HotelId = 3, ReviewText = "The infinity pool at Marina Bay Sands is breathtaking. Worth every penny!", IsConfirmedBooking = true },
                new Review { ReviewId = 6, UserId = 6, HotelId = 3, ReviewText = "Fantastic location with world-class facilities. Highly recommend the Skyline Suite.", IsConfirmedBooking = true },
                new Review { ReviewId = 7, UserId = 7, HotelId = 4, ReviewText = "The Plaza offers a classic NYC luxury stay. Amazing location and incredible staff.", IsConfirmedBooking = true },
                new Review { ReviewId = 8, UserId = 8, HotelId = 4, ReviewText = "From the iconic decor to the warm hospitality, everything was perfect. A must-visit!", IsConfirmedBooking = true },
                new Review { ReviewId = 9, UserId = 9, HotelId = 5, ReviewText = "Taj Lake Palace feels like a dream. Stunning architecture and serene atmosphere.", IsConfirmedBooking = true },
                new Review { ReviewId = 10, UserId = 10, HotelId = 5, ReviewText = "A truly royal experience. The lake views and heritage charm are unparalleled.", IsConfirmedBooking = true },
                new Review { ReviewId = 11, UserId = 11, HotelId = 6, ReviewText = "Four Seasons in Tokyo is a perfect blend of modern luxury and traditional charm.", IsConfirmedBooking = true },
                new Review { ReviewId = 12, UserId = 12, HotelId = 6, ReviewText = "An oasis of calm in the bustling city. The terrace views are stunning!", IsConfirmedBooking = true },
                new Review { ReviewId = 13, UserId = 13, HotelId = 7, ReviewText = "The Savoy exceeded my expectations. Iconic and timeless, with top-notch hospitality.", IsConfirmedBooking = true },
                new Review { ReviewId = 14, UserId = 14, HotelId = 7, ReviewText = "Beautiful interiors and excellent service. Perfect for a special occasion.", IsConfirmedBooking = true },
                new Review { ReviewId = 15, UserId = 15, HotelId = 8, ReviewText = "The Mandarin Oriental redefines luxury in Bangkok. Exceptional attention to detail.", IsConfirmedBooking = true },
                new Review { ReviewId = 16, UserId = 1, HotelId = 8, ReviewText = "The spa experience was heavenly. Highly recommend for a relaxing retreat.", IsConfirmedBooking = true },
                new Review { ReviewId = 17, UserId = 2, HotelId = 9, ReviewText = "Belmond Hotel Caruso is a slice of paradise. The infinity pool is a dream!", IsConfirmedBooking = true },
                new Review { ReviewId = 18, UserId = 3, HotelId = 9, ReviewText = "Charming and picturesque. The sea view suite is worth every cent.", IsConfirmedBooking = true },
                new Review { ReviewId = 19, UserId = 4, HotelId = 10, ReviewText = "The Peninsula offers timeless luxury and impeccable service. A true gem.", IsConfirmedBooking = true },
                new Review { ReviewId = 20, UserId = 5, HotelId = 10, ReviewText = "The harbor view is spectacular. A luxurious stay with unforgettable memories.", IsConfirmedBooking = true },
                new Review { ReviewId = 21, UserId = 6, HotelId = 11, ReviewText = "Raffles Hotel is steeped in history. Loved the colonial charm and excellent service.", IsConfirmedBooking = true },
                new Review { ReviewId = 22, UserId = 7, HotelId = 11, ReviewText = "The courtyard was serene and the heritage suite was exceptional.", IsConfirmedBooking = true },
                new Review { ReviewId = 23, UserId = 8, HotelId = 12, ReviewText = "The Fairmont Banff Springs is a fairytale come true. Stunning mountain views!", IsConfirmedBooking = true },
                new Review { ReviewId = 24, UserId = 9, HotelId = 12, ReviewText = "A magical experience in the Rockies. The Royal Suite is pure luxury.", IsConfirmedBooking = true },
                new Review { ReviewId = 25, UserId = 10, HotelId = 13, ReviewText = "Hotel de Crillon is an embodiment of Parisian luxury. Incredible attention to detail.", IsConfirmedBooking = true },
                new Review { ReviewId = 26, UserId = 11, HotelId = 13, ReviewText = "The Grands Appartements Suite is extraordinary. A flawless stay in every way.", IsConfirmedBooking = true },
                new Review { ReviewId = 27, UserId = 12, HotelId = 14, ReviewText = "The Langham combines modern luxury with classic elegance. A fantastic experience.", IsConfirmedBooking = true },
                new Review { ReviewId = 28, UserId = 13, HotelId = 14, ReviewText = "The Chairman Suite offers unparalleled comfort and sophistication. Loved it!", IsConfirmedBooking = true },
                new Review { ReviewId = 29, UserId = 14, HotelId = 15, ReviewText = "The Park Hyatt Sydney offers the best views of the Opera House. A true gem.", IsConfirmedBooking = true },
                new Review { ReviewId = 30, UserId = 15, HotelId = 15, ReviewText = "The Sydney Suite is a dream! Outstanding service and breathtaking location.", IsConfirmedBooking = true }
            );

            modelBuilder.Entity<FeaturedDeal>().HasData(
                new FeaturedDeal { FeaturedDealId = 1, HotelId = 1, OriginalPrice = 750, DiscountedPrice = 674.33m, StartDate = DateTime.Today, EndDate = DateTime.Today.AddDays(9) },
                new FeaturedDeal { FeaturedDealId = 2, HotelId = 4, OriginalPrice = 1715, DiscountedPrice = 1587.48m, StartDate = DateTime.Today, EndDate = DateTime.Today.AddDays(2) },
                new FeaturedDeal { FeaturedDealId = 3, HotelId = 2, OriginalPrice = 1140, DiscountedPrice = 1024, StartDate = DateTime.Today, EndDate = DateTime.Today.AddDays(7) },
                new FeaturedDeal { FeaturedDealId = 4, HotelId = 1, OriginalPrice = 536.5m, DiscountedPrice = 489.75m, StartDate = DateTime.Today, EndDate = DateTime.Today.AddDays(2) },
                new FeaturedDeal { FeaturedDealId = 5, HotelId = 6, OriginalPrice = 400, DiscountedPrice = 299, StartDate = DateTime.Today, EndDate = DateTime.Today.AddDays(3) },
                new FeaturedDeal { FeaturedDealId = 6, HotelId = 10, OriginalPrice = 630, DiscountedPrice = 595.5m, StartDate = DateTime.Today, EndDate = DateTime.Today.AddDays(5) }
            );

            modelBuilder.Entity<HotelImage>().HasData(
                new HotelImage { HotelImageId = 1, HotelId = 1, ImagePath = "https://innfinity.blob.core.windows.net/images/1TheRitzCarlton.jpg" },
                new HotelImage { HotelImageId = 2, HotelId = 2, ImagePath = "https://innfinity.blob.core.windows.net/images/2BurjAlArab.jpg" },
                new HotelImage { HotelImageId = 3, HotelId = 3, ImagePath = "https://innfinity.blob.core.windows.net/images/3MarinaBaySands.jpeg" },
                new HotelImage { HotelImageId = 4, HotelId = 4, ImagePath = "https://innfinity.blob.core.windows.net/images/4ThePlaza.jpg" },
                new HotelImage { HotelImageId = 5, HotelId = 5, ImagePath = "https://innfinity.blob.core.windows.net/images/5TajLakePalace.jpg" },
                new HotelImage { HotelImageId = 6, HotelId = 6, ImagePath = "https://innfinity.blob.core.windows.net/images/6FourSeasons.jpg" },
                new HotelImage { HotelImageId = 7, HotelId = 7, ImagePath = "https://innfinity.blob.core.windows.net/images/7TheSavoy.jpeg" },
                new HotelImage { HotelImageId = 8, HotelId = 8, ImagePath = "https://innfinity.blob.core.windows.net/images/8MandarinOriental.jpg" },
                new HotelImage { HotelImageId = 9, HotelId = 9, ImagePath = "https://innfinity.blob.core.windows.net/images/9BelmondHotelCaruso.jpg" },
                new HotelImage { HotelImageId = 10, HotelId = 10, ImagePath = "https://innfinity.blob.core.windows.net/images/10ThePeninsula.png" },
                new HotelImage { HotelImageId = 11, HotelId = 11, ImagePath = "https://innfinity.blob.core.windows.net/images/11Raffles.jpeg" },
                new HotelImage { HotelImageId = 12, HotelId = 12, ImagePath = "https://innfinity.blob.core.windows.net/images/12FairmontBanffSprings.jpg" },
                new HotelImage { HotelImageId = 13, HotelId = 13, ImagePath = "https://innfinity.blob.core.windows.net/images/13HoteldeCrillon.png" },
                new HotelImage { HotelImageId = 14, HotelId = 14, ImagePath = "https://innfinity.blob.core.windows.net/images/14TheLangham.jpeg" },
                new HotelImage { HotelImageId = 15, HotelId = 15, ImagePath = "https://innfinity.blob.core.windows.net/images/15ParkHyatt.jpg" }
            );
        }
    }
}
