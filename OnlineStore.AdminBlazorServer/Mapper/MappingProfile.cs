using System;
using AutoMapper;
using OnlineStore.AdminBlazorServer.DTOs;
using OnlineStore.Core.Entities.Catalog;

namespace OnlineStore.AdminBlazorServer.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
        }
    }
}
