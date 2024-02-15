using Microsoft.Extensions.DependencyInjection;
using UiComponents.Theming;

namespace UiComponents;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddServerUiComponents(this IServiceCollection services)
    {
        return services.AddScoped<ThemeProvider>();
    }
    
    public static IServiceCollection AddWasmUiComponents(this IServiceCollection services)
    {
        return services.AddSingleton<ThemeProvider>();
    }
}