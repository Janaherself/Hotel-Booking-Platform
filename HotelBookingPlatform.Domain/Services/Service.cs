using AutoMapper;
using HotelBookingPlatform.Domain.Interfaces;
using HotelBookingPlatform.Infrastructure.Interfaces;

namespace HotelBookingPlatform.Domain.Services
{
    public class Service<T, TEntity>(IRepository<TEntity> repository, IMapper mapper) : IService<T, TEntity> 
        where T : class 
        where TEntity : class
    {
        public async Task AddAsync(T item)
        {
            var entity = mapper.Map<TEntity>(item);
            await repository.AddAsync(entity);
        }

        public void Delete(T item)
        {
            var entity = mapper.Map<TEntity>(item);
            repository.Delete(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync(int pageSize = 6, int pageNumer = 1)
        {
            var entities = await repository.GetAllAsync(pageSize, pageNumer);
            return mapper.Map<IEnumerable<T>>(entities);
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            var entity = await repository.GetByIdAsync(id);
            return mapper.Map<T>(entity);
        }

        public async Task SaveAsync()
        {
            await repository.SaveAsync();
        }

        public void Update(T item)
        {
            var entity = mapper.Map<TEntity>(item);
            repository.Update(entity);
        }
    }
}
