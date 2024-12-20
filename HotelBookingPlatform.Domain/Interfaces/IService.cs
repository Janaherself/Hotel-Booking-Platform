namespace HotelBookingPlatform.Domain.Interfaces
{
    public interface IService<T, TEntity> 
        where T : class 
        where TEntity : class
    {
        Task<T?> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync(int pageSize = 6, int pageNumer = 1);
        void Delete(T item);
        void Update(T item);
        Task AddAsync(T item);
        Task SaveAsync();
    }
}
