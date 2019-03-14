using Clash.Authentication.AuthService;
using Clash.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Clash.IoC.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}