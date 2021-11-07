using System;
using OnlineStore.PublicApi.Helpers.Logger;

namespace OnlineStore.PublicApi.Endpoints.ProductEndpoints
{
    public class CreateProductResponse : BaseResponse
    {
        public CreateProductResponse(Guid correlationId) : base(correlationId)
        {
        }

        public CreateProductResponse()
        {
        }

        public ProductDto Product { get; set; }
    }
}
