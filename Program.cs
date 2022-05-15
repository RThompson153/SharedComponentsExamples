using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SharedComponents.DragAndDrop;
using System.Threading.Tasks;

namespace BlazorComponents
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			var builder = WebAssemblyHostBuilder.CreateDefault(args);
			builder.RootComponents.Add<App>("#app");

			builder.Services.AddSingleton<IDragAndDropService, DragAndDropService>();

			await builder.Build().RunAsync();
		}
	}
}
