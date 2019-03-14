using Clash.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using static Clash.DataBase.Maps.UserMap;

namespace Clash.DataBase.Context
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(UserMapBuilder.CreateInstance());
        }
    }
}