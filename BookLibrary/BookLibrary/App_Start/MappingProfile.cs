using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using BookLibrary.Dtos;
using BookLibrary.Models;

namespace BookLibrary.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Domain to Dto
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Book, BookDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<BookLanguage, BookLanguageDto>();
 

            //Dto to Domain
            Mapper.CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());           
            Mapper.CreateMap<BookDto, Book>().ForMember(b => b.Id, opt => opt.Ignore());
        }
    }
}