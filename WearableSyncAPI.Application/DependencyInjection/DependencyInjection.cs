using Microsoft.Extensions.DependencyInjection;

namespace WearableSyncAPI.Application.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        //services.AddScoped<IUsuarioService, UsuarioService>();
        return services;
    }
}
