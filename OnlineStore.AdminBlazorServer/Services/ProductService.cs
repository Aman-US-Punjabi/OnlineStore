using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using OnlineStore.AdminBlazorServer.DTOs;
using OnlineStore.AdminBlazorServer.Interfaces;
using OnlineStore.Core.Entities.Catalog;
using OnlineStore.Infrastructure.Repositories;

namespace OnlineStore.AdminBlazorServer.Services
{
    public class ProductService : IProductService
    {
        private readonly EfReadRepository<Product> _productReadRepository;
        private readonly EfRepository<Product> _productRepository;
        private readonly IMapper _mapper;

        public ProductService(EfRepository<Product> productRepository, EfReadRepository<Product> productReadRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _productReadRepository = productReadRepository;
            _mapper = mapper;
        }

        public Task<Product> CreateProduct(ProductDTO productDTO)
        {
            Product productToCreate = _mapper.Map<ProductDTO, Product>(productDTO);

            return _productRepository.AddAsync(productToCreate);
        }

        public Task<Product> GetProductById(int id)
        {
            return _productReadRepository.GetByIdAsync(id);
        }

        public Task<List<Product>> GetProducts()
        {
            return _productReadRepository.ListAsync();
        }

        public async Task UpdateProduct(Product productToUpdate)
        {
            await _productRepository.UpdateAsync(productToUpdate);
        }
    }
}
