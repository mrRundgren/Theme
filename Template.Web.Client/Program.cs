using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using UiComponents;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddWasmUiComponents();

await builder.Build().RunAsync();