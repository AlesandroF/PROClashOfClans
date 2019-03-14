using Clash.Domain.Entities.API;
using Microsoft.EntityFrameworkCore;
using static Clash.DataBase.Maps.ClanMap;

namespace Clash.DataBase.Context
{
    public class ClanContext : DbContext
    {
        public ClanContext(DbContextOptions<ClanContext> options) : base(options) { }

        public DbSet<Clan> Clan { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(ClanMapBuilder.CreateInstance());
        }
    }
}