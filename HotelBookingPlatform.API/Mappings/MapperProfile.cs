using AutoMapper;
using HotelBookingPlatform.API.DTOs;
using HotelBookingPlatform.Domain.DomainEntities;
using HotelBookingPlatform.Infrastructure.Entities;

namespace HotelBookingPlatform.API.Mappings
{
    public class MapperProfile : Profile
    {
        public MapperProfile() 
        {
            CreateMap<BookingEntity, BookingReadDto>();
            CreateMap<BookingCreateDto, BookingEntity>();
            CreateMap<BookingUpdateDto, BookingEntity>()
                .ForAllMembers(config => config.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<CityEntity, CityReadDto>();
            CreateMap<CityCreateDto, CityEntity>();
            CreateMap<CityUpdateDto, CityEntity>()
                .ForAllMembers(config => config.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<FeaturedDealEntity, FeaturedDealReadDto>();
            CreateMap<FeaturedDealCreateDto, FeaturedDealEntity>();
            CreateMap<FeaturedDealUpdateDto, FeaturedDealEntity>()
                .ForAllMembers(config => config.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<HotelEntity, HotelReadDto>();
            CreateMap<HotelCreateDto, HotelEntity>();
            CreateMap<HotelUpdateDto, HotelEntity>()
                .ForAllMembers(config => config.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<RoomEntity, RoomReadDto>();
            CreateMap<RoomCreateDto, RoomEntity>();
            CreateMap<RoomUpdateDto, RoomEntity>()
                .ForAllMembers(config => config.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<UserEntity, UserReadDto>();
            CreateMap<UserUpdateDto, UserEntity>()
                .ForAllMembers(config => config.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<HotelImageEntity, HotelImageReadDto>();

            CreateMap<LoginEntity, LoginDto>().ReverseMap();

            CreateMap<ReviewEntity, ReviewReadDto>();

        }
    }
}
