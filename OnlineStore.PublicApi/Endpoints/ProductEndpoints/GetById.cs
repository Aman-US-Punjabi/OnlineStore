using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Core.Entities.Catalog;
using OnlineStore.Core.Interfaces.Repositories;
using Swashbuckle.AspNetCore.Annotations;

namespace OnlineStore.PublicApi.Endpoints.ProductEndpoints
{
    public class GetById : ControllerBase
    {
        private readonly IAsyncReadRepository<Product> _productRepository;
        private readonly IMapper _mapper;

        public GetById(IAsyncReadRepository<Product> productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        [HttpGet("api/product/{ProductId}")]
        [SwaggerOperation(
            Summary = "Get a Product by ID",
            Description = "Gets a Product by ID",
            OperationId = "product.GetById",
            Tags = new[] { "ProductEndpoints" }

         )]
        public async Task<ActionResult<GetByIdProductResponse>> GetByID([FromRoute] GetByIdProductRequest request, CancellationToken cancellationToken)
        {
            var response = new GetByIdProductResponse(request.CorrelationId());

            var product = await _productRepository.GetByIdAsync(request.ProductId, cancellationToken);
            if (product is null) return NotFound();

            response.ProductDto = _mapper.Map<Product, ProductDto>(product);

            return Ok(response);
        }
    }
}
