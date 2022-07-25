using AutoMapper;
using WebApplication1.Dto;
using WebApplication1.Models;

namespace WebApplication1.Maps
{
    public class CustomerAutoMapperProfile:Profile
    {
        public CustomerAutoMapperProfile()
        {

            CreateMap<CustomerModel, Customer>().ForMember(opt => opt.Phone, ses => ses.MapFrom(src => src.PhoneNumber));
            CreateMap<Customer, CustomerModel>()
                  .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.Phone))
            .ForMember(dest => dest.IsAdult, opt => opt.MapFrom(src => src.Age > 18));
            CreateMap<Address, AddressModel>().ReverseMap();
        }
    }
}
