using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using DeathwatchMobile;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) }); // Register HttpClient for making HTTP requests to the server
builder.Services.AddScoped<DeathwatchMobile.Services.CharacterStore>(); // Register the CharacterStore service for dependency injection

await builder.Build().RunAsync();
