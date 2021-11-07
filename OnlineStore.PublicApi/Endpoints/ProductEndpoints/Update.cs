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
    public class Update : ControllerBase
    {
        private readonly IAsyncRepository<Product> _productRepository;
        private readonly IMapper _mapper;

        public Update(IAsyncRepository<Product> productReposiotiry, IMapper mapper)
        {
            _productRepository = productReposiotiry;
            _mapper = mapper;
        }


        [HttpPut("api/product")]
        [SwaggerOperation(
            Summary = "Update a Product",
            Description = "Update a Product",
            OperationId = "product.update",
            Tags = new[] { "ProductEndpoints" }
        )]
        public async Task<ActionResult<UpdateProductResponse>> UpdateProduct(UpdateProductRequest request, CancellationToken cancellationToken)
        {
            var response = new UpdateProductResponse(request.CorrelationId());

            var existingItem = await _productRepository.GetByIdAsync(request.Id, cancellationToken);

            if (existingItem is null)
            {
                return NotFound();
            }

            existingItem.UpdateDetails(request.Name, request.Description, request.Price, request.Quantity, request.IsDiscountinued);

            await _productRepository.UpdateAsync(existingItem, cancellationToken);

            response.Product = _mapper.Map<Product, ProductDto>(existingItem);

            return response;
        }
    }
}
