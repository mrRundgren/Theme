using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using UiComponents.Theming;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddSingleton<ThemeProvider>();

await builder.Build().RunAsync();