using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Moq;
using OnlineStore.AdminBlazorServer.DTOs;
using OnlineStore.AdminBlazorServer.Services;
using OnlineStore.Core.Entities.Catalog;
using OnlineStore.Core.Interfaces.Repositories;
using OnlineStore.Infrastructure.Repositories;
using Xunit;

namespace OnlineStore.AdminBlazorServer.Tests
{
    public class ProductServiceTests
    {
        private Mock<IAsyncRepository<Product>> _productRepositoryMock;
        private Mock<IAsyncReadRepository<Product>> _productReadRepositoryMock;
        private Mock<IMapper> _mapperMock;
        private ProductService _productService;

        public ProductServiceTests()
        {
            _productRepositoryMock = new Mock<IAsyncRepository<Product>>();
            _productReadRepositoryMock = new Mock<IAsyncReadRepository<Product>>();
            _mapperMock = new Mock<IMapper>();

            _productService = new ProductService(
                _productRepositoryMock.Object,
                _productReadRepositoryMock.Object,
                _mapperMock.Object
                );
        }

        [Fact]
        public void GetProducts_InvokesMethod_CheckIfRepoIsCalled()
        {
            // Act
            _productService.GetProducts();

            // Assert 
            _productReadRepositoryMock.Verify(x => x.ListAsync(It.IsAny<System.Threading.CancellationToken>()), Times.Once);
        }

        [Fact]
        public async void CreateProduct_ReturnResult()
        {
            // Arange
            Product resultProduct = null;
            ProductDTO productToCreateInDb = new ProductDTO
            {
                Id = 12,
                Name = "iPhone1",
                Description = "This is the description of the product",
                Price = 550,
                Quantity = 10
            };

            Product productToReturnFromDb = new Product
            {
                Id = 12,
                Name = "iPhone1",
                Description = "This is the description of the product",
                Price = 550,
                Quantity = 10
            };

            //// When _productRepository's AddAsync method is called, it should return 
            _productRepositoryMock
                .Setup(x => x.AddAsync(It.IsAny<Product>(), default))
                .ReturnsAsync(productToReturnFromDb);

            // Act
            resultProduct = await _productService.CreateProduct(productToCreateInDb);

            // Assert
            // Check is AddAsync func is called only once in the CreateProduct Method
            _productRepositoryMock.Verify(x => x.AddAsync(It.IsAny<Product>(), default), Times.Once);

            Assert.NotNull(resultProduct);
            Assert.Equal(productToCreateInDb.Name, resultProduct.Name);
            Assert.Equal(productToCreateInDb.Price, resultProduct.Price);
            Assert.Equal(productToCreateInDb.Description, resultProduct.Description);
            Assert.Equal(productToCreateInDb.Quantity, resultProduct.Quantity);
            Assert.Equal(productToCreateInDb.Id, resultProduct.Id);

        }
    }
}
