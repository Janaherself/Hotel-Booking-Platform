namespace HotelBookingPlatform.Domain.Interfaces
{
    public interface IService<T, TEntity> 
        where T : class 
        where TEntity : class
    {
        Task<T?> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync(int pageSize = 6, int pageNumer = 1);
        Task<bool> Delete(int id);
        Task<bool> Update(int id, T item);
        void Add(T item);
        Task SaveAsync();
    }
}
