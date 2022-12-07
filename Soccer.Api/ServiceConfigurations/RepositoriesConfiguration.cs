using Soccer.Shared.Repositories;
namespace Soccer.Api.ServiceConfigurations
{
    public static class RepositoriesConfiguration
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<TeamRepository>();
            services.AddScoped<PlayerRepository>();
            services.AddScoped<ITeamRepository, CachedTeamRepository>();
            services.AddScoped<IPlayerRepository, CachedPlayerRepository>();
            return services;
        }
    }
}