using System;
using OnlineStore.PublicApi.Helpers.Logger;

namespace OnlineStore.PublicApi.Endpoints.ProductEndpoints
{
    public class UpdateProductResponse : BaseResponse
    {
        public UpdateProductResponse(Guid correlationId) : base(correlationId)
        {
        }

        public UpdateProductResponse()
        {
        }

        public ProductDto Product { get; set; }
    }
}
