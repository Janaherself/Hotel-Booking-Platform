using AutoMapper;
using HotelBookingPlatform.Domain.Exceptions;
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
        public virtual void Add(T item)
        {
            logger.LogInformation("Calling Add method on the {Repository} repository..", typeof(TEntity));
            var entity = mapper.Map<TEntity>(item);
            repository.Add(entity);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var item = await repository.GetByIdAsync(id);
            if (item == null)
            {
                logger.LogInformation("No record of type {Type} in the database corresponds to the Id of {Id}.", typeof(TEntity), id);
                return false;
            }

            logger.LogInformation("Calling Delete method on the {Repository} repository..", typeof(TEntity));
            repository.Delete(item);
            return true;
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
            var entity = await repository.GetByIdAsync(id) ?? throw new ItemNotFoundException($"Item {typeof(TEntity)} with id {id} was not found.");
            return mapper.Map<T>(entity);
        }

        public async Task SaveAsync()
        {
            logger.LogInformation("Calling SaveAsync method on the {Repository} repository..", typeof(TEntity));
            await repository.SaveAsync();
        }

        public virtual async Task<bool> UpdateAsync(int id, T item)
        {
            var entity = await repository.GetByIdAsync(id);
            if (entity == null)
            {
                logger.LogInformation("No record of type {Type} in the database corresponds to the Id of {Id}.", typeof(TEntity), id);
                return false;
            }

            logger.LogInformation("Calling Update method on the {Repository} repository..", typeof(TEntity));
            mapper.Map(item, entity);
            repository.Update(entity);
            return true;
        }
    }
}
