using Clash.Common.ValueObjects;
using Clash.DataBase.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Clash.IoC.Extensions
{
    public static class ContextExtension
    {
        public static IServiceCollection RegisterContexts(this IServiceCollection services, AppSettings appSettings)
        {
            services.AddDbContext<UserContext>(opt => opt.UseSqlServer(appSettings.ConnectionStrings));
            services.AddDbContext<ClanContext>(opt => opt.UseSqlServer(appSettings.ConnectionStrings));
            services.AddDbContext<IconUrlsContext>(opt => opt.UseSqlServer(appSettings.ConnectionStrings));
            services.AddDbContext<BadgeUrlsContext>(opt => opt.UseSqlServer(appSettings.ConnectionStrings));
            services.AddDbContext<LeagueContext>(opt => opt.UseSqlServer(appSettings.ConnectionStrings));
            services.AddDbContext<LocationContext>(opt => opt.UseSqlServer(appSettings.ConnectionStrings));
            services.AddDbContext<MemberListContext>(opt => opt.UseSqlServer(appSettings.ConnectionStrings));

            return services;
        }
    }
}