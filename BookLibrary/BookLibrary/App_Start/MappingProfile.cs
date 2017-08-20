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

            Mapper.CreateMap<Customer, CustomerDto>();
            //.ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<Book, BookDto>();
            //.ForMember(b => b.Id, opt => opt.Ignore());
            Mapper.CreateMap<BookDto, Book>().ForMember(b => b.Id, opt => opt.Ignore());
        }
    }
}