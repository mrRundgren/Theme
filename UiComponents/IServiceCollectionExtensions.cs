using Microsoft.Extensions.DependencyInjection;
using UiComponents.Theming;

namespace UiComponents;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddUiComponents(this IServiceCollection services)
    {
        return services.AddScoped<ThemeProvider>();
        ;
    }
}