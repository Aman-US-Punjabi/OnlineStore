using System;
using Ardalis.Specification;
using OnlineStore.Core.Entities.Catalog;

namespace OnlineStore.Core.Specifications.ProductSpecifications
{
    public class ProductNameSpecification : Specification<Product>
    {
        public ProductNameSpecification(string productName)
        {
            Query.Where(item => productName == item.Name);
        }
    }
}
