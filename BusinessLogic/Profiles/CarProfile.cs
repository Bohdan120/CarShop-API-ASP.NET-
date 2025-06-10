using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using DataAccess.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Profiles
{
    public class CarProfile : Profile
    {
        public CarProfile(IFileService fileService)
        {
            CreateMap<CarDto, Car>()
                .ForMember(x => x.Category, opt => opt.Ignore());
            CreateMap<Car, CarDto>();

            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Order, OrderDto>().ReverseMap();

            CreateMap<CreateCarModel, Car>();               

            CreateMap<Order, OrderSummaryModel>()
                .ForMember(x => x.Number, opts => opts.MapFrom(src => src.Id))
                .ForMember(x => x.UserName, opts => opts.MapFrom(src => src.User.UserName));

            CreateMap<RegisterModel, User>()
                .ForMember(x => x.UserName, opts => opts.MapFrom(s => s.Email));

            CreateMap<Review, ReviewDto>()
                .ForMember(dest => dest.Car, opt => opt.MapFrom(src => src.Car));

            CreateMap<Car, CarShortDto>();

        }
    }
}
