using AutoMapper;
using FluentAssertions;
using HotelBookingPlatform.Domain.Exceptions;
using HotelBookingPlatform.Domain.Services;
using HotelBookingPlatform.Infrastructure.Interfaces;
using Microsoft.Extensions.Logging;
using Moq;

namespace HotelBookingPlatform.Domain.Test
{
    public class DomainEntity { }           // domain entity mock
    public class Entity : AuditEntity { }   // infrastructure entity mock

    public class ServiceTests
    {
        private readonly Mock<IRepository<Entity>> _repositoryMock;
        private readonly Mock<IMapper> _mapperMock;
        private readonly Mock<ILogger<Service<DomainEntity, Entity>>> _loggerMock;
        private readonly Service<DomainEntity, Entity> _service;

        public ServiceTests()
        {
            _repositoryMock = new Mock<IRepository<Entity>>();
            _mapperMock = new Mock<IMapper>();
            _loggerMock = new Mock<ILogger<Service<DomainEntity, Entity>>>();
            _service = new Service<DomainEntity, Entity>(_repositoryMock.Object, _mapperMock.Object, _loggerMock.Object);
        }

        [Fact]
        public async Task DeleteAsync_ShouldReturnFalse_WhenItemNotFound()
        {
            var id = 1;
            _repositoryMock.Setup(repo => repo.GetByIdAsync(id)).ReturnsAsync(null as Entity);

            var result = await _service.DeleteAsync(id);

            result.Should().BeFalse();
        }

        [Fact]
        public async Task DeleteAsync_ShouldCallRepositoryDelete_WhenItemFound()
        {
            var id = 1;
            var auditEntity = new Entity();
            _repositoryMock.Setup(repo => repo.GetByIdAsync(id)).ReturnsAsync(auditEntity);

            var result = await _service.DeleteAsync(id);

            result.Should().BeTrue();
            _repositoryMock.Verify(repo => repo.Delete(auditEntity), Times.Once);
        }

        [Fact]
        public async Task GetByIdAsync_ShouldThrowItemNotFoundException_WhenItemNotFound()
        {
            var id = 1;
            _repositoryMock.Setup(repo => repo.GetByIdAsync(id)).ReturnsAsync(null as Entity);

            var act = async () => await _service.GetByIdAsync(id);

            await act.Should().ThrowAsync<ItemNotFoundException>();
        }

        [Fact]
        public async Task GetByIdAsync_ShouldReturnMappedEntity_WhenItemFound()
        {
            var id = 1;
            var auditEntity = new Entity();
            var domainEntity = new DomainEntity();

            _repositoryMock.Setup(repo => repo.GetByIdAsync(id)).ReturnsAsync(auditEntity);
            _mapperMock.Setup(mapper => mapper.Map<DomainEntity>(auditEntity)).Returns(domainEntity);

            var result = await _service.GetByIdAsync(id);

            result.Should().Be(domainEntity);
        }

        [Fact]
        public async Task SaveAsync_ShouldCallRepositorySaveAsync()
        {
            await _service.SaveAsync();

            _repositoryMock.Verify(repo => repo.SaveAsync(), Times.Once);
        }

        [Fact]
        public async Task UpdateAsync_ShouldReturnFalse_WhenItemNotFound()
        {
            var id = 1;
            var domainEntity = new DomainEntity();

            _repositoryMock.Setup(repo => repo.GetByIdAsync(id)).ReturnsAsync(null as Entity);

            var result = await _service.UpdateAsync(id, domainEntity);

            result.Should().BeFalse();
        }

        [Fact]
        public async Task UpdateAsync_ShouldCallRepositoryUpdate_WhenItemFound()
        {
            var id = 1;
            var domainEntity = new DomainEntity();
            var auditEntity = new Entity();

            _repositoryMock.Setup(repo => repo.GetByIdAsync(id)).ReturnsAsync(auditEntity);

            var result = await _service.UpdateAsync(id, domainEntity);

            result.Should().BeTrue();
            _repositoryMock.Verify(repo => repo.Update(auditEntity), Times.Once);
        }
    }
}