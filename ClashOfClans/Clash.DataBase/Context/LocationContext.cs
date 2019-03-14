using Clash.Domain.Entities.API;
using Microsoft.EntityFrameworkCore;
using static Clash.DataBase.Maps.LocationMap;

namespace Clash.DataBase.Context
{
    public class LocationContext : DbContext
    {
        public LocationContext(DbContextOptions<LocationContext> options) : base(options) { }

        public DbSet<Location> Location { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(LocationMapBuilder.CreateInstance());
        }
    }
}