using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using UiComponents.Theming;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped<ThemeProvider>();

await builder.Build().RunAsync();