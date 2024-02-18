using Microsoft.Extensions.DependencyInjection;
using UiComponents.Interops;
using UiComponents.Theming;

namespace UiComponents;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddServerUiComponents(this IServiceCollection services)
    {
        return services.AddScoped<ThemeProvider>()
            .AddScoped<DrawerInterop>();
    }

    public static IServiceCollection AddWasmUiComponents(this IServiceCollection services)
    {
        return services.AddSingleton<ThemeProvider>()
            .AddSingleton<DrawerInterop>();
    }
}