﻿namespace HotelBookingPlatform.Infrastructure.Entities
{
    public class HotelImage
    {
        public int HotelImageId { get; set; }
        public int HotelId { get; set; }
        public string ImagePath { get; set; } = string.Empty;
    }
}
