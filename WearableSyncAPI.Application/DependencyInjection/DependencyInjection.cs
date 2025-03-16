using Microsoft.Extensions.DependencyInjection;
using WearableSyncAPI.Application.Interface;
using WearableSyncAPI.Application.Service;

namespace WearableSyncAPI.Application.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IManagerSmartbandData, ManagerSmartbandDataMI4>();
        return services;
    }
}
