using Clash.Domain.Entities.API;
using Microsoft.EntityFrameworkCore;
using static Clash.DataBase.Maps.MemberListMap;

namespace Clash.DataBase.Context
{
    public class MemberListContext : DbContext
    {
        public MemberListContext(DbContextOptions<MemberListContext> options) : base(options) { }

        public DbSet<MemberList> MemberList { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(MemberListMapBuilder.CreateInstance());
        }
    }
}