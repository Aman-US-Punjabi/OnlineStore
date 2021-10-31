using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Components;
using OnlineStore.AdminBlazorServer.DTOs;
using OnlineStore.AdminBlazorServer.Interfaces;
using OnlineStore.Core.Entities.Catalog;

namespace OnlineStore.AdminBlazorServer.Pages.ProductPages
{
    public partial class ProductUpsert
    {
        [Parameter]
        public int? Id { get; set; }

        [Inject]
        protected IProductService _productService { get; set; }

        [Inject]
        protected NavigationManager _navigationManager { get; set; }

        [Inject]
        protected IMapper _mapper { get; set; }

        private ProductDTO ProductModel { get; set; } = new ProductDTO();
        private Product ProductFromDb = new Product();

        private string Title { get; set; } = "Create";


        public ProductUpsert()
        {
        }

        protected override async Task OnInitializedAsync()
        {
            if (Id != null)
            {
                // Update Product
                Title = "Update";
                ProductFromDb = await _productService.GetProductById(Id.Value);
                ProductModel = _mapper.Map<Product, ProductDTO>(ProductFromDb);
            }
        }


        private async Task HandleProductUpsert()
        {
            try
            {
                if (ProductModel.Id != 0 && Title == "Update")
                {
                    // Update
                    // provide existing object instead of letting Automapper create new destination object for you.
                    // It should be something like _mapper.Map<CustomerDto, Customer>(customerDtoObject, customerEntityObjectFetchedThroughEF).
                    ProductFromDb = _mapper.Map<ProductDTO, Product>(ProductModel, ProductFromDb);
                    await _productService.UpdateProduct(ProductFromDb);
                }
                else
                {
                    // Create Product
                    await _productService.CreateProduct(ProductModel);
                }

                // TODO Sucess notification

                // Navigate to Products Page
                _navigationManager.NavigateTo("products");
            }
            catch (Exception ex)
            {
                // TODO Log Error
                Console.WriteLine("-----------------------  Error  -----------------------");
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
