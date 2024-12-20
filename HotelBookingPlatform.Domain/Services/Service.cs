using HotelBookingPlatform.Domain.Interfaces;

namespace HotelBookingPlatform.Domain.Services
{
    public class Service<T> : IService<T> where T : class
    {
        public Task AddAsync(T item)
        {
            throw new NotImplementedException();
        }

        public void Delete(T item)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAllAsync(int pageSize = 6, int pageNumer = 1)
        {
            throw new NotImplementedException();
        }

        public Task<T?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
