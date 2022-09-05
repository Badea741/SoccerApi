using FluentValidation;
using Soccer.Shared.Entities;
using Soccer.Shared.Validations;

namespace Soccer.Api.ServiceConfigurations
{
    public static class FluentValidationConfiguration
    {
        public static void AddFluentValidation(this IServiceCollection services)
        {
            services.AddScoped<AbstractValidator<Player>, PlayerValidator>();
            services.AddScoped<AbstractValidator<Team>, TeamValidator>();
        }
    }
}