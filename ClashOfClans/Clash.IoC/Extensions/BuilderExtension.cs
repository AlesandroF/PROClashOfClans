using Clash.Domain.Builders;
using Clash.Domain.Entities;
using Clash.Interfaces.Builders;
using Microsoft.Extensions.DependencyInjection;

namespace Clash.IoC.Extensions
{
    public static class BuilderExtension
    {
        public static IServiceCollection RegisterBuilders(this IServiceCollection services)
        {
            services.AddScoped<IUserBuilder<User>, UserBuilder>();
            return services;
        }
    }
}