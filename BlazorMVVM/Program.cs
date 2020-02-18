using Microsoft.AspNetCore.Blazor.Hosting;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using BlazorMVVM.Models;

namespace BlazorMVVM
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault();
            builder.RootComponents.Add<App>("app");
            builder.Services.AddSingleton<NumberViewModel>();
            builder.Services.AddSingleton<ToggleViewModel>();
            await builder.Build().RunAsync();
        }        
    }
}
