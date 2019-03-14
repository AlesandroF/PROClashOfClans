using Clash.Domain.Entities.API;
using Microsoft.EntityFrameworkCore;
using static Clash.DataBase.Maps.IconUrlsMap;

namespace Clash.DataBase.Context
{
    public class IconUrlsContext : DbContext
    {
        public IconUrlsContext(DbContextOptions<IconUrlsContext> options) : base(options) { }

        public DbSet<IconUrls> IconUrls { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(IconUrlsMapBuilder.CreateInstance());
        }
    }
}