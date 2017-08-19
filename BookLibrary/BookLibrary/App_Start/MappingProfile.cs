﻿using System;
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
            Mapper.CreateMap<CustomerDto, Customer>();
            Mapper.CreateMap<Book, BookDto>();
            Mapper.CreateMap<BookDto, Book>();
        }
    }
}