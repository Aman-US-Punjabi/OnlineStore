using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineStore.AdminBlazorServer.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter the Price")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Please enter the Quantity")]
        public int Quantity { get; set; }


        public bool IsDiscountinued { get; set; }

        public ProductDTO()
        {
        }
    }
}
