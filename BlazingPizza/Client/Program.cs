using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;


namespace BlazingPizza.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            #region // Default Implementation
            //builder.Services.AddHttpClient("BlazingPizza.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
            //    .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

            //// Supply HttpClient instances that include access tokens when making requests to the server project
            //builder.Services.AddTransient(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("BlazingPizza.ServerAPI"));

            //builder.Services.AddApiAuthorization();
            #endregion

            builder.Services.AddBaseAddressHttpClient();

            await builder.Build().RunAsync();
        }
    }
}
