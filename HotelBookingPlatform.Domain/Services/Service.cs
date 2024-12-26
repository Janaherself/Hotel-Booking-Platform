using AutoMapper;
using HotelBookingPlatform.Domain.Interfaces;
using HotelBookingPlatform.Infrastructure.Interfaces;
using Microsoft.Extensions.Logging;

namespace HotelBookingPlatform.Domain.Services
{
    public class Service<T, TEntity>(
        IRepository<TEntity> repository,
        IMapper mapper, 
        ILogger<Service<T, TEntity>> logger)
        : IService<T, TEntity> 
        where T : class          // T => domain layer entity (Domain.ItemEntity)
        where TEntity : AuditEntity    // TEntity => infrastructure layer entity (Infrastructure.Item)
    {
        public async Task AddAsync(T item)
        {
            logger.LogInformation("Calling Add method on the {Repository} repository..", typeof(TEntity));
            var entity = mapper.Map<TEntity>(item);
            await repository.AddAsync(entity);
        }

        public void Delete(T item)
        {
            logger.LogInformation("Calling Delete method on the {Repository} repository..", typeof(TEntity));
            var entity = mapper.Map<TEntity>(item);
            repository.Delete(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync(int pageSize = 6, int pageNumer = 1)
        {
            logger.LogInformation("Calling GetAll method on the {Repository} repository..", typeof(TEntity));
            var entities = await repository.GetAllAsync(pageSize, pageNumer);
            return mapper.Map<IEnumerable<T>>(entities);
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            logger.LogInformation("Calling GetById method on the {Repository} repository..", typeof(TEntity));
            var entity = await repository.GetByIdAsync(id);
            return mapper.Map<T>(entity);
        }

        public async Task SaveAsync()
        {
            logger.LogInformation("Calling SaveAsync method on the {Repository} repository..", typeof(TEntity));
            await repository.SaveAsync();
        }

        public void Update(T item)
        {
            logger.LogInformation("Calling Update method on the {Repository} repository..", typeof(TEntity));
            var entity = mapper.Map<TEntity>(item);
            repository.Update(entity);
        }
    }
}
