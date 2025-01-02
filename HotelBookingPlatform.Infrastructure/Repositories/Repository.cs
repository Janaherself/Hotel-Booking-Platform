using HotelBookingPlatform.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace HotelBookingPlatform.Infrastructure.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : AuditEntity
    {
        protected readonly AppDbContext _context;
        protected readonly DbSet<TEntity> _dbSet;
        private readonly ILogger<Repository<TEntity>> _logger;

        public Repository(AppDbContext context, ILogger<Repository<TEntity>> logger)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
            _logger = logger;
        }

        public async Task<TEntity?> GetByIdAsync(int id)
        {
            _logger.LogInformation("Getting {Item} with id {Id}..", typeof(TEntity), id);
            return await _dbSet.FindAsync(id);
        }

        public async Task<List<TEntity>> GetAllAsync(int pageSize = 6, int pageNumber = 1)
        {
            _logger.LogInformation("Getting {PageSize} items from page {PageNumber}..", pageSize, pageNumber);
            return await _dbSet
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }

        public void Delete(TEntity item)
        {
            _dbSet.Remove(item);
            _logger.LogInformation("Waiting for context to delete {Item}..", item);
        }

        public void Update(TEntity item)
        {
            item.ModificationDate = DateTime.Now;
            _dbSet.Update(item);
            _logger.LogInformation("Waiting for context to update {Item}..", item);
        }

        public void Add(TEntity item)
        {
            _logger.LogInformation("Waiting for context to add {Item}..", item);
            _dbSet.Add(item);
        }

        public async Task SaveAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
                _logger.LogInformation("Changes to database was successfuly saved.");
            }
            catch (DbUpdateConcurrencyException ex)
            {
                _logger.LogError(ex, "A database concurrency update exception was thrown.");
                throw;
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex, "A database update exception was thrown.");
                throw;
            }
        }
    }
}
