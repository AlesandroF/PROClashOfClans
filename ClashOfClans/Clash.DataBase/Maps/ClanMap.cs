using Clash.Domain.Entities.API;
using Microsoft.EntityFrameworkCore;

namespace Clash.DataBase.Maps
{
    public class ClanMap : IEntityTypeConfiguration<Clan>
    {
        void IEntityTypeConfiguration<Clan>.Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Clan> builder)
        {
            builder.HasKey(clan => clan.Id);

            builder.Property(t => t.Id).HasColumnName("ID_CLAN");
            builder.Property(t => t.ClanLevel).HasColumnName("CLAN_LEVEL");
            builder.Property(t => t.ClanPoint).HasColumnName("CLAN_PONTOS");
            builder.Property(t => t.ClanVersusPoints).HasColumnName("CLAN_VERSUS_POINTS");
            builder.Property(t => t.Description).HasColumnName("CLAN_DESCRICAO");
            builder.Property(t => t.IsWarLogPublic).HasColumnName("CLAN_WAR_LOG");
            builder.Property(t => t.Members).HasColumnName("CLAN_QNTD_MEMBERS");
            builder.Property(t => t.Name).HasColumnName("CLAN_NOME");
            builder.Property(t => t.RequiredTrophies).HasColumnName("CLAN_TROFEUS_NECESSARIOS");
            builder.Property(t => t.Tag).HasColumnName("CLAN_TAG");
            builder.Property(t => t.Type).HasColumnName("CLAN_TYPE");
            builder.Property(t => t.WarFrequency).HasColumnName("CLAN_FREQUENCIA_WAR");
            builder.Property(t => t.WarWins).HasColumnName("CLAN_WAR_WINS");
            builder.Property(t => t.WarWinStreak).HasColumnName("CLAN_WAR_STREAK");
        }

        internal static class ClanMapBuilder
        {
            public static ClanMap CreateInstance()
            {
                return new ClanMap();
            }
        }
    }
}