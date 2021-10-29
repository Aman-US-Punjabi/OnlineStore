using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OnlineStore.AdminBlazorServer.DTOs;
using OnlineStore.Core.Entities.Catalog;

namespace OnlineStore.AdminBlazorServer.Interfaces
{
    public interface IProductService
    {
        Task<List<Product>> GetProducts();

        Task<Product> GetProductById(int id);

        Task<Product> CreateProduct(ProductDTO productDTO);

        Task UpdateProduct(Product productToUpdate);
    }
}
