using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Core.Entities.Catalog;
using OnlineStore.Core.Exceptions;
using OnlineStore.Core.Interfaces.Repositories;
using OnlineStore.Core.Specifications.ProductSpecifications;
using Swashbuckle.AspNetCore.Annotations;

namespace OnlineStore.PublicApi.Endpoints.ProductEndpoints
{
    public class Create : ControllerBase
    {
        private readonly IAsyncRepository<Product> _productRepository;
        private readonly IMapper _mapper;

        public Create(IAsyncRepository<Product> productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        [HttpPost("api/product")]
        [SwaggerOperation(
            Summary = "Create a new Product",
            Description = "Create a new Product",
            OperationId = "product.create",
            Tags = new[] { "ProductEndpoints" }
        )]
        public async Task<ActionResult<CreateProductResponse>> CreateProduct(CreateProductRequest request, CancellationToken cancellationToken)
        {
            var response = new CreateProductResponse(request.CorrelationId());

            var productNameSpecification = new ProductNameSpecification(request.Name);
            var existingProduct = await _productRepository.CountAsync(productNameSpecification, cancellationToken);

            if (existingProduct > 0)
            {
                throw new DuplicateException($"A product with name {request.Name} already exists");
            }

            var productToCreateFromRequest = _mapper.Map<CreateProductRequest, Product>(request);
            var newProduct = await _productRepository.AddAsync(productToCreateFromRequest);

            response.Product = _mapper.Map<Product, ProductDto>(newProduct);
            return Ok(response);
        }
    }
}
