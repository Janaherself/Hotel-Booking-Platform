using HotelBookingPlatform.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingPlatform.Infrastructure.Entities
{
    public class Booking : AuditEntity
    {
        public int BookingId { get; set; }
        public int UserId { get; set; }
        public DateOnly CheckInDate { get; set; }
        public DateOnly CheckOutDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status {  get; set; } = string.Empty;
        public User? User { get; set; }
        public List<Room>? Rooms { get; set; }
    }
}
