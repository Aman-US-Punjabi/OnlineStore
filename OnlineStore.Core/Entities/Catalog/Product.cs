using System;
using System.Collections;
using System.Collections.Generic;
using OnlineStore.Core.Entities.BaseEntities;
using OnlineStore.Core.Interfaces;

namespace OnlineStore.Core.Entities.Catalog
{
    public class Product : AuditableEntity, IAggregateRoot
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public bool IsDiscountinued { get; set; }

        public ICollection<ProductImage> Photos { get; set; }

        public string GetFormattedBasePrice() => Price.ToString("0.00");

        public Product()
        {
        }
    }
}
