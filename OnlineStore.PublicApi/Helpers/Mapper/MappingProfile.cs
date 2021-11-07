using System;
using AutoMapper;
using OnlineStore.Core.Entities.Catalog;
using OnlineStore.PublicApi.Endpoints.ProductEndpoints;

namespace OnlineStore.PublicApi.Helpers.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<CreateProductRequest, Product>();

        }
    }
}
