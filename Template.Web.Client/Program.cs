using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Pico;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped<ThemeManager>();

await builder.Build().RunAsync();