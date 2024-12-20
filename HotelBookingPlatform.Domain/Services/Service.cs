using AutoMapper;
using HotelBookingPlatform.Domain.Interfaces;
using HotelBookingPlatform.Infrastructure.Interfaces;

namespace HotelBookingPlatform.Domain.Services
{
    public class Service<T, TEntity> : IService<T, TEntity> 
        where T : class 
        where TEntity : class
    {
        private readonly IRepository<TEntity> _repository;
        private readonly IMapper _mapper;

        public Service(IRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task AddAsync(T item)
        {
            var entity = _mapper.Map<TEntity>(item);
            await _repository.AddAsync(entity);
        }

        public void Delete(T item)
        {
            var entity = _mapper.Map<TEntity>(item);
            _repository.Delete(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync(int pageSize = 6, int pageNumer = 1)
        {
            var entities = await _repository.GetAllAsync(pageSize, pageNumer);
            return _mapper.Map<IEnumerable<T>>(entities);
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return _mapper.Map<T>(entity);
        }

        public async Task SaveAsync()
        {
            await _repository.SaveAsync();
        }

        public void Update(T item)
        {
            var entity = _mapper.Map<TEntity>(item);
            _repository.Update(entity);
        }
    }
}
