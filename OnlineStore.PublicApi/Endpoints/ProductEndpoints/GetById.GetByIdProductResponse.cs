using System;
using OnlineStore.PublicApi.Helpers.Logger;

namespace OnlineStore.PublicApi.Endpoints.ProductEndpoints
{
    public class GetByIdProductResponse : BaseResponse
    {
        public GetByIdProductResponse(Guid correlationId) : base(correlationId)
        {
        }

        public GetByIdProductResponse()
        {
        }

        public ProductDto ProductDto { get; set; }
    }
}
