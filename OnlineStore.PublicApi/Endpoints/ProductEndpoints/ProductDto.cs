using System;
using System.Collections.Generic;
using OnlineStore.Core.Entities.Catalog;

namespace OnlineStore.PublicApi.Endpoints.ProductEndpoints
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public bool IsDiscountinued { get; set; }

        public ICollection<ProductImage> Photos { get; set; }
    }
}
