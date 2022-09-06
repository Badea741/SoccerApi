using AuthenticationServices.Models;
using AutoMapper;
using Soccer.Shared.AutoMapperProfiles;
using Soccer.Shared.Dtos;
using Soccer.Shared.Entities;

namespace Soccer.Api.ServiceConfigurations
{
    public static class AutoMapperConfiguration
    {
        public static IServiceCollection AddAutoMapperConfiguration(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(TeamProfile).Assembly);
            return services;
        }
    }
}