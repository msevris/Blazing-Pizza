#pragma checksum "C:\Users\ntfx\source\repos\msevris\BLAZOR\_blazingPizza\BlazingPizza\Client\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e0218e230eb1a84da2f84846d3f17acd28397db"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingPizza.Client
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
#line 13 "C:\Users\ntfx\source\repos\msevris\BLAZOR\_blazingPizza\BlazingPizza\Client\_Imports.razor"
using BlazingPizza.ComponentsLibrary;

#line default
#line hidden
#line 14 "C:\Users\ntfx\source\repos\msevris\BLAZOR\_blazingPizza\BlazingPizza\Client\_Imports.razor"
using BlazingPizza.ComponentsLibrary.Map;

#line default
#line hidden
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(3);
                __builder2.AddAttribute(4, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#line 2 "C:\Users\ntfx\source\repos\msevris\BLAZOR\_blazingPizza\BlazingPizza\Client\App.razor"
                          typeof(Program).Assembly

#line default
#line hidden
                ));
                __builder2.AddAttribute(5, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder3) => {
                    __builder3.AddMarkupContent(6, "\r\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeRouteView>(7);
                    __builder3.AddAttribute(8, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#line 4 "C:\Users\ntfx\source\repos\msevris\BLAZOR\_blazingPizza\BlazingPizza\Client\App.razor"
                                            routeData

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(9, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#line 4 "C:\Users\ntfx\source\repos\msevris\BLAZOR\_blazingPizza\BlazingPizza\Client\App.razor"
                                                                       typeof(MainLayout)

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(10, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder4) => {
                        __builder4.AddMarkupContent(11, "\r\n                    ");
                        __builder4.OpenComponent<BlazingPizza.Client.Shared.RedirectToLogin>(12);
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(13, "\r\n                ");
                    }
                    ));
                    __builder3.AddAttribute(14, "Authorizing", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(15, "\r\n                    ");
                        __builder4.AddMarkupContent(16, "<div class=\"main\">Please wait ...</div>\r\n                ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(17, "\r\n        ");
                }
                ));
                __builder2.AddAttribute(18, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(19, "\r\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(20);
                    __builder3.AddAttribute(21, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#line 14 "C:\Users\ntfx\source\repos\msevris\BLAZOR\_blazingPizza\BlazingPizza\Client\App.razor"
                                 typeof(MainLayout)

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(23, "\r\n                ");
                        __builder4.AddMarkupContent(24, "<div class=\"main\">Sorry, there\'s nothing at this address.</div>\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(25, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
