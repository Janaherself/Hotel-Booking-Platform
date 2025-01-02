using AutoMapper;
using HotelBookingPlatform.Domain.DomainEntities;
using HotelBookingPlatform.Infrastructure.Entities;

namespace HotelBookingPlatform.Domain.Mapping
{
    public class GenericMapperProfile : Profile
    {
        public GenericMapperProfile()
        {
            CreateMap<BookingEntity, Booking>().ReverseMap()
                .ForAllMembers(options =>
                {
                    options.AllowNull();
                    options.Condition((src, dest, srcMember) => srcMember != null);
                });

            CreateMap<CityEntity, City>().ReverseMap()
                .ForAllMembers(options =>
                {
                    options.AllowNull();
                    options.Condition((src, dest, srcMember) => srcMember != null);
                });

            CreateMap<FeaturedDeal, FeaturedDeal>().ReverseMap()
                .ForAllMembers(options =>
                {
                    options.AllowNull();
                    options.Condition((src, dest, srcMember) => srcMember != null);
                });

            CreateMap<HotelEntity, Hotel>().ReverseMap()
                .ForAllMembers(options =>
                {
                    options.AllowNull();
                    options.Condition((src, dest, srcMember) => srcMember != null);
                });

            CreateMap<ReviewEntity, Review>().ReverseMap()
                .ForAllMembers(options =>
                {
                    options.AllowNull();
                    options.Condition((src, dest, srcMember) => srcMember != null);
                });

            CreateMap<RoomEntity, Room>().ReverseMap()
                .ForAllMembers(options =>
                {
                    options.AllowNull();
                    options.Condition((src, dest, srcMember) => srcMember != null);
                });

            CreateMap<UserEntity, User>().ReverseMap()
                .ForAllMembers(options =>
                {
                    options.AllowNull();
                    options.Condition((src, dest, srcMember) => srcMember != null);
                });

            CreateMap<HotelImageEntity, HotelImage>().ReverseMap()
                .ForAllMembers(options =>
                {
                    options.AllowNull();
                    options.Condition((src, dest, srcMember) => srcMember != null);
                });
        }
    }
}
