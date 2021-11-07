using System;
using System.ComponentModel.DataAnnotations;
using OnlineStore.PublicApi.Helpers.Logger;

namespace OnlineStore.PublicApi.Endpoints.ProductEndpoints
{
    public class UpdateProductRequest : BaseRequest
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Range(0.01, 10000)]
        public double Price { get; set; }

        [Range(1, 1000)]
        public int Quantity { get; set; }

        public bool IsDiscountinued { get; set; }
    }
}
