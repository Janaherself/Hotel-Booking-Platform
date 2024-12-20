using AutoMapper;
using HotelBookingPlatform.Domain.DomainEntities;
using HotelBookingPlatform.Infrastructure.Entities;

namespace HotelBookingPlatform.Domain.Mapping
{
    public class GenericMapperProfile : Profile
    {
        public GenericMapperProfile()
        {
            CreateMap<BookingEntity, Booking>().ReverseMap();
            CreateMap<CityEntity, City>().ReverseMap();
            CreateMap<FeaturedDeal, FeaturedDeal>().ReverseMap();
            CreateMap<HotelEntity, Hotel>().ReverseMap();
            CreateMap<ReviewEntity, Review>().ReverseMap();
            CreateMap<RoomEntity, Room>().ReverseMap();
            CreateMap<UserEntity, User>().ReverseMap();
        }
    }
}
