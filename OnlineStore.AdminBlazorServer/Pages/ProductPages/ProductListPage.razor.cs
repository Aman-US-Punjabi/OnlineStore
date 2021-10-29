using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using OnlineStore.AdminBlazorServer.Interfaces;
using OnlineStore.Core.Entities.Catalog;

namespace OnlineStore.AdminBlazorServer.Pages.ProductPages
{
    public partial class ProductListPage
    {
        [Inject]
        protected IProductService _productService { get; set; }

        private List<Product> Products;

        public ProductListPage()
        {
        }

        protected override async Task OnInitializedAsync()
        {
            Products = await _productService.GetProducts();
        }
    }
}
