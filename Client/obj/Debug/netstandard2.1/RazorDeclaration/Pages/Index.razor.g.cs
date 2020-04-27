#pragma checksum "C:\Users\ntfx\source\repos\msevris\BLAZOR\_blazingPizza\BlazingPizza\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87b911c5f3135782f933c63da7f6947d7a1d5b76"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazingPizza.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 3 "C:\Users\ntfx\source\repos\msevris\BLAZOR\_blazingPizza\BlazingPizza\Client\Pages\Index.razor"
      
    #region -- code ---

    List<PizzaSpecial> specials;
    Pizza configuringPizza;
    bool showingConfigureDialog;
    Order order = new Order();

    void RemoveConfiguredPizza(Pizza pizza)
    {
        order.Pizzas.Remove(pizza);
    }

    async Task PlaceOrder()
    {
        await HttpClient.PostAsJsonAsync("orders", order);
        order = new Order();
    }

    void ConfirmConfigurePizzaDialog()
    {
        order.Pizzas.Add(configuringPizza);
        configuringPizza = null;
        showingConfigureDialog = false;
    }

    void CancelConfigurePizzaDialog()
    {
        configuringPizza = null;
        showingConfigureDialog = false;
    }

    void ShowConfigurePizzaDialog(PizzaSpecial special)
    {
        configuringPizza = new Pizza()
        {
            Special = special,
            SpecialId = special.Id,
            Size = Pizza.DefaultSize,
            Toppings = new List<PizzaTopping>(),
        };

        showingConfigureDialog = true;
    }

    protected override async Task OnInitializedAsync()
    {
        specials = await HttpClient.GetFromJsonAsync<List<PizzaSpecial>>("specials");
    }
    #endregion

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591
