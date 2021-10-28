using System;
using System.ComponentModel.DataAnnotations.Schema;
using OnlineStore.Core.Entities.BaseEntities;
using OnlineStore.Core.Interfaces;

namespace OnlineStore.Core.Entities.Catalog
{
    public class ProductImage : AuditableEntity, IAggregateRoot
    {
        public string Url { get; set; }
        public string Title { get; set; }
        public bool IsMain { get; set; }

        public int ProductId { get; set; }
        //[ForeignKey("ProductID")]
        public virtual Product Product { get; set; }

        public ProductImage()
        {
        }
    }
}
