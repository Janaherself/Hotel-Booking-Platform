namespace HotelBookingPlatform.Domain.Exceptions
{
    class InvalidRoomIdException : Exception
    {
        public InvalidRoomIdException() : base("One or more RoomIds are invalid.")
        {   
        }

        public InvalidRoomIdException(string message) : base(message)
        {   
        }

        public InvalidRoomIdException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
