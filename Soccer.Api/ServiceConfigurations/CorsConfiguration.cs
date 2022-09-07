namespace Soccer.Api.ServiceConfigurations;
public static class CorsConfiguration
{
    public static string CorsPolicyName = "CorsPolicy";
    public static IServiceCollection AddCorsConfiguration(this IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddPolicy(CorsPolicyName, builder =>
            {
                builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
            });
        });
        return services;
    }
}