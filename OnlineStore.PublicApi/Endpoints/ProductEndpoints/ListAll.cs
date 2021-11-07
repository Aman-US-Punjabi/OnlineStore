using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Core.Entities.Catalog;
using OnlineStore.Core.Interfaces.Repositories;
using Swashbuckle.AspNetCore.Annotations;

namespace OnlineStore.PublicApi.Endpoints.ProductEndpoints
{
    public class ListAll : ControllerBase
    {
        private readonly IAsyncReadRepository<Product> _productReadRepository;

        public ListAll(IAsyncReadRepository<Product> productReadRepisotry)
        {
            _productReadRepository = productReadRepisotry;
        }

        [HttpGet("api/product")]
        [SwaggerOperation(
            Summary = "List Products",
            Description = "List Products",
            OperationId = "products.ListAll",
            Tags = new[] { "ProductEndpoints" }
        )]
        public async Task<ActionResult<ListAllProductResponse>> ListAllHandler(ListAllProductRequest request, CancellationToken cancellationToken)
        {
            var response = new ListAllProductResponse(request.CorrelationId());


            var products = await _productReadRepository.ListAsync();


            response.Products = products;

            return Ok(response);
        }
    }
}
