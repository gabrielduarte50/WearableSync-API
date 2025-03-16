using Microsoft.Extensions.DependencyInjection;
using WearableSyncAPI.Infra.Persistence;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using WearableSyncAPI.Infra.Repository;
using WearableSyncAPI.Application.Interface.Repository;

namespace WearableSyncAPI.Infra.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Config PostgreSQL
            services.AddDbContext<DatabaseContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            // Register repos
            services.AddScoped<ISmartbandDataRepository, SmartbandDataRepository>();

            return services;
        }
    }
}
