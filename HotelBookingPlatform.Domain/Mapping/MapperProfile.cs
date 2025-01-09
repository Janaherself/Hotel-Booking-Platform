using AutoMapper;
using HotelBookingPlatform.Domain.DomainEntities;
using HotelBookingPlatform.Infrastructure.Entities;

namespace HotelBookingPlatform.Domain.Mapping
{
    public class GenericMapperProfile : Profile
    {
        public GenericMapperProfile()
        {
            CreateMap<BookingEntity, Booking>()
                .ForAllMembers(options =>
                {
                    options.AllowNull();
                    options.Condition((src, dest, srcMember) => srcMember != null);
                });

            CreateMap<Booking, BookingEntity>()
                .ForAllMembers(options =>
                {
                    options.AllowNull();
                    options.Condition((src, dest, srcMember) => srcMember != null);
                });

            CreateMap<CityEntity, City>()
                .ForAllMembers(options =>
                {
                    options.AllowNull();
                    options.Condition((src, dest, srcMember) => srcMember != null);
                });

            CreateMap<City, CityEntity>()
                .ForAllMembers(options =>
                {
                    options.AllowNull();
                    options.Condition((src, dest, srcMember) => srcMember != null);
                });

            CreateMap<FeaturedDealEntity, FeaturedDeal>()
                .ForAllMembers(options =>
                {
                    options.AllowNull();
                    options.Condition((src, dest, srcMember) => srcMember != null);
                });

            CreateMap<FeaturedDeal, FeaturedDealEntity>()
                .ForAllMembers(options =>
                {
                    options.AllowNull();
                    options.Condition((src, dest, srcMember) => srcMember != null);
                });

            CreateMap<HotelEntity, Hotel>()
                .ForAllMembers(options =>
                {
                    options.AllowNull();
                    options.Condition((src, dest, srcMember) => srcMember != null);
                });

            CreateMap<Hotel, HotelEntity>()
                .ForAllMembers(options =>
                {
                    options.AllowNull();
                    options.Condition((src, dest, srcMember) => srcMember != null);
                });

            CreateMap<ReviewEntity, Review>()
                .ForAllMembers(options =>
                {
                    options.AllowNull();
                    options.Condition((src, dest, srcMember) => srcMember != null);
                });

            CreateMap<Review, ReviewEntity>()
                .ForAllMembers(options =>
                {
                    options.AllowNull();
                    options.Condition((src, dest, srcMember) => srcMember != null);
                });

            CreateMap<RoomEntity, Room>()
                .ForAllMembers(options =>
                {
                    options.AllowNull();
                    options.Condition((src, dest, srcMember) => srcMember != null);
                });

            CreateMap<Room, RoomEntity>()
                .ForAllMembers(options =>
                {
                     options.AllowNull();
                     options.Condition((src, dest, srcMember) => srcMember != null);
                });

            CreateMap<UserEntity, User>()
                .ForAllMembers(options =>
                {
                    options.AllowNull();
                    options.Condition((src, dest, srcMember) => srcMember != null);
                });

            CreateMap<User, UserEntity>()
                .ForAllMembers(options =>
                {
                    options.AllowNull();
                    options.Condition((src, dest, srcMember) => srcMember != null);
                });

            CreateMap<HotelImageEntity, HotelImage>()
                .ForAllMembers(options =>
                {
                    options.AllowNull();
                    options.Condition((src, dest, srcMember) => srcMember != null);
                });

            CreateMap<HotelImage, HotelImageEntity>()
                .ForAllMembers(options =>
                {
                    options.AllowNull();
                    options.Condition((src, dest, srcMember) => srcMember != null);
                });
        }
    }
}
