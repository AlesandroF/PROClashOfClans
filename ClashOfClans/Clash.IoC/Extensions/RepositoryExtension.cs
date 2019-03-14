using Clash.DataBase.Repositories;
using Clash.Domain.Entities;
using Clash.Interfaces.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Clash.IoC.Extensions
{
    public static class RepositoryExtension
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository<User>, UserRepository>();

            return services;
        }
    }
}