#pragma checksum "C:\Users\ntfx\source\repos\msevris\BLAZOR\_blazingPizza\BlazingPizza\Client\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d069d744381113aa571b0c53d5ca0a9a9c2ec1b6"
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
#line 1 "C:\Users\ntfx\source\repos\msevris\BLAZOR\_blazingPizza\BlazingPizza\Client\Shared\LoginDisplay.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 2 "C:\Users\ntfx\source\repos\msevris\BLAZOR\_blazingPizza\BlazingPizza\Client\Shared\LoginDisplay.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "user-info");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(3);
            __builder.AddAttribute(4, "Authorizing", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n                ");
                __builder2.AddMarkupContent(6, "<text>...</text>\r\n            ");
            }
            ));
            __builder.AddAttribute(7, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n                <img src=\"/img/user.svg\">\r\n                ");
                __builder2.OpenElement(9, "div");
                __builder2.AddMarkupContent(10, "\r\n                    ");
                __builder2.OpenElement(11, "a");
                __builder2.AddAttribute(12, "class", "username");
                __builder2.AddAttribute(13, "href", "authentication/profile");
                __builder2.AddContent(14, 
#line 15 "C:\Users\ntfx\source\repos\msevris\BLAZOR\_blazingPizza\BlazingPizza\Client\Shared\LoginDisplay.razor"
                                                                       context.User.Identity.Name

#line default
#line hidden
                );
                __builder2.AddContent(15, "!");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n                    ");
                __builder2.OpenElement(17, "button");
                __builder2.AddAttribute(18, "class", "btn btn-link sign-out");
                __builder2.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 16 "C:\Users\ntfx\source\repos\msevris\BLAZOR\_blazingPizza\BlazingPizza\Client\Shared\LoginDisplay.razor"
                                                                    BeginSignOut

#line default
#line hidden
                ));
                __builder2.AddContent(20, "Sign out");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n            ");
            }
            ));
            __builder.AddAttribute(23, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(24, "\r\n                ");
                __builder2.AddMarkupContent(25, "<a href=\"authentication/register\" class=\"sign-in\">Register</a>\r\n                ");
                __builder2.AddMarkupContent(26, "<a href=\"authentication/login\" class=\"sign-in\">Log in</a>\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 26 "C:\Users\ntfx\source\repos\msevris\BLAZOR\_blazingPizza\BlazingPizza\Client\Shared\LoginDisplay.razor"
      
    private async Task BeginSignOut(MouseEventArgs args)
    {
        await SignOutManager.SetSignOutState();
        Navigation.NavigateTo("authentication/logout");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignOutSessionStateManager SignOutManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591
