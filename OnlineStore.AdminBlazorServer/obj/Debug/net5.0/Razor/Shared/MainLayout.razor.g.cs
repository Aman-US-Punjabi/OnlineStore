#pragma checksum "/Users/amandeepsingh/Projects/Dotnet6/OnlineStore/OnlineStore.AdminBlazorServer/Shared/MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43f29c4efde042fbda1ad6228bb259653f4a9014"
// <auto-generated/>
#pragma warning disable 1591
namespace OnlineStore.AdminBlazorServer.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-rc4a11dbur");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-rc4a11dbur");
            __builder.OpenComponent<OnlineStore.AdminBlazorServer.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-rc4a11dbur");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "top-row px-4 auth");
            __builder.AddAttribute(13, "b-rc4a11dbur");
            __builder.OpenComponent<OnlineStore.AdminBlazorServer.Shared.LoginDisplay>(14);
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.AddMarkupContent(16, "<a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\" b-rc4a11dbur>About</a>");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "content px-4");
            __builder.AddAttribute(20, "b-rc4a11dbur");
#nullable restore
#line 15 "/Users/amandeepsingh/Projects/Dotnet6/OnlineStore/OnlineStore.AdminBlazorServer/Shared/MainLayout.razor"
__builder.AddContent(21, Body);

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
