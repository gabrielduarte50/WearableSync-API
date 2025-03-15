using Microsoft.Extensions.DependencyInjection;
using WearableSyncAPI.Infra.Persistence;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;


namespace WearableSyncAPI.Infra.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Configuração do PostgreSQL
            services.AddDbContext<DatabaseContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            // Registro de repositórios
            //services.AddScoped<IUsuarioRepository, UsuarioRepository>();

            return services;
        }
    }
}
