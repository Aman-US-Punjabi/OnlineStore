using System;
using AutoMapper;
using Moq;
using OnlineStore.AdminBlazorServer.Services;
using OnlineStore.Core.Entities.Catalog;
using OnlineStore.Core.Interfaces.Repositories;
using OnlineStore.Infrastructure.Repositories;

namespace OnlineStore.AdminBlazorServer.Tests
{
    public class ProductServiceTests
    {
        // Arrange
        private Mock<IAsyncRepository<Product>> _productRepositoryMock;
        private Mock<IAsyncReadRepository<Product>> _productReadRepositoryMock;
        private Mock<IMapper> _mapperMock;
        private ProductService _productService;

        public ProductServiceTests()
        {
            //_productRepositoryMock = new Mock<IAsyncRepository<Product>>();
            //_productReadRepositoryMock = new Mock<IAsyncReadRepository<Product>>();
            //_productService = new ProductService(
            //    _productRepositoryMock,
            //    _productReadRepositoryMock,
            //    _mapperMock
            //    );
        }

        // Act


        // Assert
    }
}
