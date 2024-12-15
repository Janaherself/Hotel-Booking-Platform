using HotelBookingPlatform.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingPlatform.Infrastructure.Entities
{
    public class Review : AuditEntity
    {
        public int ReviewId { get; set; }
        public int UserId { get; set; }
        public int HotelId { get; set; }
        public string ReviewText { get; set; } = string.Empty;
        public bool IsConfirmedBooking { get; set; }
    }
}
