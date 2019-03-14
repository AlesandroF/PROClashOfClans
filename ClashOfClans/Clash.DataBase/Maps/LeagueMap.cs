using Clash.Domain.Entities.API;
using Microsoft.EntityFrameworkCore;

namespace Clash.DataBase.Maps
{
    public class LeagueMap : IEntityTypeConfiguration<League>
    {
        void IEntityTypeConfiguration<League>.Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<League> builder)
        {
            builder.HasKey(league => league.Id);
            builder.Property(t => t.Name).HasColumnName("NOME");
        }

        internal static class LeagueMapBuilder
        {
            public static LeagueMap CreateInstance()
            {
                return new LeagueMap();
            }
        }
    }
}