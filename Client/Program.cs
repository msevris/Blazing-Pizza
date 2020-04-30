using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;


namespace BlazingPizza.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            
            builder.Services.AddBaseAddressHttpClient();
            builder.Services.AddScoped<OrderState>();

            /* add auth service */
            builder.Services.AddRemoteAuthentication<PizzaAuthenticationState, ApiAuthorizationProviderOptions>();
            builder.Services.AddApiAuthorization(options =>
            {
                options.AuthenticationPaths.LogOutSucceededPath = "";
                options.ProviderOptions.ConfigurationEndpoint = "_configuration/BlazingPizza.Client"; // temp
            });

            await builder.Build().RunAsync();
        }
    }
}
