using System;
using System.Collections.Generic;
using OnlineStore.Core.Entities.Catalog;
using OnlineStore.PublicApi.Helpers.Logger;

namespace OnlineStore.PublicApi.Endpoints.ProductEndpoints
{
    public class ListAllProductResponse : BaseResponse
    {
        public ListAllProductResponse(Guid correlationId) : base(correlationId)
        {
        }

        public ListAllProductResponse()
        {
        }

        public List<Product> Products { get; set; } = new List<Product>();
    }
}
