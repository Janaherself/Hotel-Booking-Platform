﻿using HotelBookingPlatform.Domain.DomainEntities;
using HotelBookingPlatform.Infrastructure.Entities;

namespace HotelBookingPlatform.Domain.Interfaces
{
    public interface IUserService : IService<UserEntity, User>
    {
        Task<UserEntity> GetByEmailAsync(string email);

        Task<string?> LoginAsync(LoginEntity loginEntity);

        Task<string?> RegisterAsync(LoginEntity loginEntity);
    }
}
