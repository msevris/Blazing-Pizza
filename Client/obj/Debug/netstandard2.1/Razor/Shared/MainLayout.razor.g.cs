#pragma checksum "C:\Users\ntfx\source\repos\msevris\BLAZOR\_blazingPizza\BlazingPizza\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c388f75455e289aaf44d466bddb656e0bff3fd0"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingPizza.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\ntfx\source\repos\msevris\BLAZOR\_blazingPizza\BlazingPizza\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\ntfx\source\repos\msevris\BLAZOR\_blazingPizza\BlazingPizza\Client\_Imports.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#line 3 "C:\Users\ntfx\source\repos\msevris\BLAZOR\_blazingPizza\BlazingPizza\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#line 4 "C:\Users\ntfx\source\repos\msevris\BLAZOR\_blazingPizza\BlazingPizza\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 5 "C:\Users\ntfx\source\repos\msevris\BLAZOR\_blazingPizza\BlazingPizza\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 6 "C:\Users\ntfx\source\repos\msevris\BLAZOR\_blazingPizza\BlazingPizza\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 7 "C:\Users\ntfx\source\repos\msevris\BLAZOR\_blazingPizza\BlazingPizza\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 8 "C:\Users\ntfx\source\repos\msevris\BLAZOR\_blazingPizza\BlazingPizza\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 9 "C:\Users\ntfx\source\repos\msevris\BLAZOR\_blazingPizza\BlazingPizza\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#line 10 "C:\Users\ntfx\source\repos\msevris\BLAZOR\_blazingPizza\BlazingPizza\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 11 "C:\Users\ntfx\source\repos\msevris\BLAZOR\_blazingPizza\BlazingPizza\Client\_Imports.razor"
using BlazingPizza.Client;

#line default
#line hidden
#line 12 "C:\Users\ntfx\source\repos\msevris\BLAZOR\_blazingPizza\BlazingPizza\Client\_Imports.razor"
using BlazingPizza.Client.Shared;

#line default
#line hidden
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-bar");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.AddMarkupContent(3, "<a class=\"logo\" href>\r\n            <img src=\"img/logo.svg\" class=\"logo\">\r\n        </a>\r\n\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(4);
            __builder.AddAttribute(5, "href", "");
            __builder.AddAttribute(6, "class", "nav-tab");
            __builder.AddAttribute(7, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#line 8 "C:\Users\ntfx\source\repos\msevris\BLAZOR\_blazingPizza\BlazingPizza\Client\Shared\MainLayout.razor"
                                                NavLinkMatch.All

#line default
#line hidden
            ));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n            <img src=\"img/pizza-slice.svg\">\r\n            ");
                __builder2.AddMarkupContent(10, "<div>Get Pizza</div>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n\r\n        ");
            __builder.AddMarkupContent(12, "<a href=\"myorders\" class=\"nav-tab\">\r\n            <img src=\"img/bike.svg\">\r\n            <div>My Orders</div>\r\n        </a>\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "content");
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.AddContent(17, 
#line 21 "C:\Users\ntfx\source\repos\msevris\BLAZOR\_blazingPizza\BlazingPizza\Client\Shared\MainLayout.razor"
     Body

#line default
#line hidden
            );
            __builder.AddMarkupContent(18, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
