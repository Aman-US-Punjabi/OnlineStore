using System;
using OnlineStore.PublicApi.Helpers.Logger;

namespace OnlineStore.PublicApi.Endpoints.ProductEndpoints
{
    public class GetByIdProductRequest : BaseRequest
    {
        public int ProductId { get; set; }
    }
}
