using AutoMapper;
using Discount.Grpc.Entities;
using Discount.Grpc.Protos;

namespace Discount.Grpc.Mapper
{
    public class DiscountProfile : Profile
    {
        public DiscountProfile()
        {
            CreateMap<Coupon, CouponModel>().ReverseMap();
        }
    }
}

//DiscountProfile class creates the mapping between our User domain object and UserViewModel. 
//As soon as our application starts and initializes AutoMapper,
//AutoMapper will scan our application and look for classes that inherit from the Profile class 
//    and load their mapping configurations.