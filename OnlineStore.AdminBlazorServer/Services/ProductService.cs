using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using OnlineStore.AdminBlazorServer.DTOs;
using OnlineStore.AdminBlazorServer.Interfaces;
using OnlineStore.Core.Entities.Catalog;
using OnlineStore.Core.Interfaces.Repositories;
using OnlineStore.Infrastructure.Repositories;

namespace OnlineStore.AdminBlazorServer.Services
{
    public class ProductService : IProductService
    {
        private readonly IAsyncReadRepository<Product> _productReadRepository;
        private readonly IAsyncRepository<Product> _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IAsyncRepository<Product> productRepository, IAsyncReadRepository<Product> productReadRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _productReadRepository = productReadRepository;
            _mapper = mapper;
        }

        public async Task<Product> CreateProduct(ProductDTO productDTO)
        {
            Product productToCreate = _mapper.Map<ProductDTO, Product>(productDTO);

            var product = await _productRepository.AddAsync(productToCreate);
            return product;
        }

        public async Task<Product> GetProductById(int id)
        {
            var product = await _productReadRepository.GetByIdAsync(id);
            return product;
        }

        public async Task<List<Product>> GetProducts()
        {
            var products = await _productReadRepository.ListAsync();

            return products;
        }

        public async Task UpdateProduct(Product productToUpdate)
        {
            await _productRepository.UpdateAsync(productToUpdate);
        }
    }
}
