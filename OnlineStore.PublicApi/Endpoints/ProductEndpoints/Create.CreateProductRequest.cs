using System;
using OnlineStore.PublicApi.Helpers.Logger;

namespace OnlineStore.PublicApi.Endpoints.ProductEndpoints
{
    public class CreateProductRequest : BaseRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
