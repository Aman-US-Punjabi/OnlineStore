#pragma checksum "/Users/amandeepsingh/Projects/Dotnet6/OnlineStore/OnlineStore.AdminBlazorServer/Pages/ProductPages/ProductListPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99afe8445c9527d6357ac6bc21aaa9dfcd5cb828"
// <auto-generated/>
#pragma warning disable 1591
namespace OnlineStore.AdminBlazorServer.Pages.ProductPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/amandeepsingh/Projects/Dotnet6/OnlineStore/OnlineStore.AdminBlazorServer/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/amandeepsingh/Projects/Dotnet6/OnlineStore/OnlineStore.AdminBlazorServer/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/amandeepsingh/Projects/Dotnet6/OnlineStore/OnlineStore.AdminBlazorServer/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/amandeepsingh/Projects/Dotnet6/OnlineStore/OnlineStore.AdminBlazorServer/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/amandeepsingh/Projects/Dotnet6/OnlineStore/OnlineStore.AdminBlazorServer/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/amandeepsingh/Projects/Dotnet6/OnlineStore/OnlineStore.AdminBlazorServer/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/amandeepsingh/Projects/Dotnet6/OnlineStore/OnlineStore.AdminBlazorServer/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/amandeepsingh/Projects/Dotnet6/OnlineStore/OnlineStore.AdminBlazorServer/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/amandeepsingh/Projects/Dotnet6/OnlineStore/OnlineStore.AdminBlazorServer/_Imports.razor"
using OnlineStore.AdminBlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/amandeepsingh/Projects/Dotnet6/OnlineStore/OnlineStore.AdminBlazorServer/_Imports.razor"
using OnlineStore.AdminBlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/amandeepsingh/Projects/Dotnet6/OnlineStore/OnlineStore.AdminBlazorServer/_Imports.razor"
using OnlineStore.Core;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/products")]
    public partial class ProductListPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container my-5");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row mt-4");
            __builder.AddMarkupContent(4, "<div class=\"col-8\"><h3>Products</h3></div>\n\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-3 offset-1");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(7);
            __builder.AddAttribute(8, "href", "product/create");
            __builder.AddAttribute(9, "class", "btn btn-info form-control");
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(11, "Add New Product");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "container my-5");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "row row-cols-1 row-cols-sm-2 row-cols-md-4");
#nullable restore
#line 16 "/Users/amandeepsingh/Projects/Dotnet6/OnlineStore/OnlineStore.AdminBlazorServer/Pages/ProductPages/ProductListPage.razor"
             if (Products != null && Products.Any())
            {
                foreach (var product in Products)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "card");
            __builder.AddAttribute(21, "style", "width: 18rem;");
            __builder.AddMarkupContent(22, "<img src=\"https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/iphone-12-family-select-2021?wid=940&hei=1112&fmt=jpeg&qlt=80&.v=1617135051000\" class=\"card-img-top\" alt=\"...\">\n                            ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "card-body");
            __builder.OpenElement(25, "h5");
            __builder.AddAttribute(26, "class", "card-title");
            __builder.AddContent(27, 
#nullable restore
#line 24 "/Users/amandeepsingh/Projects/Dotnet6/OnlineStore/OnlineStore.AdminBlazorServer/Pages/ProductPages/ProductListPage.razor"
                                                        product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n                                ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "row");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "col");
            __builder.OpenElement(33, "p");
            __builder.AddAttribute(34, "class", "fs-5");
            __builder.AddContent(35, "$ ");
            __builder.AddContent(36, 
#nullable restore
#line 27 "/Users/amandeepsingh/Projects/Dotnet6/OnlineStore/OnlineStore.AdminBlazorServer/Pages/ProductPages/ProductListPage.razor"
                                                           product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n                                        ");
            __builder.OpenElement(38, "p");
            __builder.AddContent(39, "Quantity: ");
            __builder.AddContent(40, 
#nullable restore
#line 28 "/Users/amandeepsingh/Projects/Dotnet6/OnlineStore/OnlineStore.AdminBlazorServer/Pages/ProductPages/ProductListPage.razor"
                                                      product.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n                                ");
            __builder.OpenElement(42, "p");
            __builder.AddAttribute(43, "class", "card-text");
            __builder.AddContent(44, 
#nullable restore
#line 31 "/Users/amandeepsingh/Projects/Dotnet6/OnlineStore/OnlineStore.AdminBlazorServer/Pages/ProductPages/ProductListPage.razor"
                                                      product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n                                ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "row");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "col");
            __builder.OpenElement(50, "a");
            __builder.AddAttribute(51, "href", "/product/edit/" + (
#nullable restore
#line 34 "/Users/amandeepsingh/Projects/Dotnet6/OnlineStore/OnlineStore.AdminBlazorServer/Pages/ProductPages/ProductListPage.razor"
                                                                product.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "class", "btn btn-primary");
            __builder.AddContent(53, "Edit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\n                                    ");
            __builder.AddMarkupContent(55, "<div class=\"col\"><a href=\"#\" class=\"btn btn-danger\">Delete</a></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 43 "/Users/amandeepsingh/Projects/Dotnet6/OnlineStore/OnlineStore.AdminBlazorServer/Pages/ProductPages/ProductListPage.razor"
                }
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(56, "<h5>No Products available!</h5>");
#nullable restore
#line 48 "/Users/amandeepsingh/Projects/Dotnet6/OnlineStore/OnlineStore.AdminBlazorServer/Pages/ProductPages/ProductListPage.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
