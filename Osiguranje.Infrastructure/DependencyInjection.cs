using Microsoft.Extensions.DependencyInjection;
using Osiguranje.Application.Common.Interfaces.Authentication;
using Osiguranje.Application.Common.Interfaces.Services;
using Osiguranje.Infrastructure.Authentication;
using Osiguranje.Infrastructure.Services;

namespace Osiguranje.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, Microsoft.Extensions.Configuration.ConfigurationManager configuration)
        {
            services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));

            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
            services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

            return services;
        }
    }
}
