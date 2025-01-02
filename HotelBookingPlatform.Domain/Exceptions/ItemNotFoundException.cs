namespace HotelBookingPlatform.Domain.Exceptions
{
    public class ItemNotFoundException : Exception
    {
        public ItemNotFoundException() : base("The requested item was not found.")
        {
        }

        public ItemNotFoundException(string message) : base(message)
        {
        }

        public ItemNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
