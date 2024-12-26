namespace HotelBookingPlatform.Infrastructure.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity?> GetByIdAsync(int id);
        Task<List<TEntity>> GetAllAsync(int pageSize = 6, int pageNumer = 1);
        void Delete(TEntity item);
        void Update(TEntity item);
        Task<TEntity?> AddAsync(TEntity item);
        Task SaveAsync();
    }
}
