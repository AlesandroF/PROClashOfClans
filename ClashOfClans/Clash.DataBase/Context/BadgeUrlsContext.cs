using Clash.Domain.Entities.API;
using Microsoft.EntityFrameworkCore;
using static Clash.DataBase.Maps.BadgeUrlsMap;

namespace Clash.DataBase.Context
{
    public class BadgeUrlsContext : DbContext
    {
        public BadgeUrlsContext(DbContextOptions<BadgeUrlsContext> options) : base(options) { }

        public DbSet<BadgeUrls> BadgeUrls { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(BadgeUrlsMapBuilder.CreateInstance());
        }
    }
}