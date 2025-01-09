using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace HotelBookingPlatform.Infrastructure.IntegrationTests.IntegrationTests
{
    public class IntegrationTestBase : IDisposable
    {
        protected readonly AppDbContext _context;
        private readonly DbTransaction _transaction;

        public IntegrationTestBase()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer("Server=LAPTOP-5RBHM2O9;Database=HotelBookingDB;Trusted_Connection=True;TrustServerCertificate=True;")
                .Options;

            var dbContext = new AppDbContext(options);
            dbContext.Database.EnsureCreated();

            _context = dbContext;

            var connection = _context.Database.GetDbConnection();
            connection.Open();
            _transaction = connection.BeginTransaction();
            _context.Database.UseTransaction(_transaction);
        }

        public void Dispose()
        {
            _transaction.Rollback();

            _transaction.Dispose();
            _context.Dispose();

            GC.SuppressFinalize(this);
        }
    }
}
