using AutoMapper;
using RentaCar.Dtos;
using RentaCar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentaCar.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Domain to Dto
            Mapper.CreateMap<Car, CarDto>();
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Rent, RentDto>();
            Mapper.CreateMap<TypeOfCar, TypeOfCarDto>();


            //Dto to domain
            Mapper.CreateMap<CarDto, Car>().ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());

        }

      
    }
}