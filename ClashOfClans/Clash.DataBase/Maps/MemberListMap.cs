using Clash.Domain.Entities.API;
using Microsoft.EntityFrameworkCore;

namespace Clash.DataBase.Maps
{
    public class MemberListMap : IEntityTypeConfiguration<MemberList>
    {
        void IEntityTypeConfiguration<MemberList>.Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<MemberList> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Tag).HasColumnName("TAG");
            builder.Property(t => t.Name).HasColumnName("NOME");
            builder.Property(t => t.Role).HasColumnName("ROLE");
            builder.Property(t => t.ExpLevel).HasColumnName("EXP");
            builder.Property(t => t.Trophies).HasColumnName("TROFEUS");
            builder.Property(t => t.VersusTrophies).HasColumnName("VERSUS_TROFEUS");
            builder.Property(t => t.ClanRank).HasColumnName("CLAN_RANK");
            builder.Property(t => t.PreviousClanRank).HasColumnName("PREVIOUS_CLAN_RANK");
            builder.Property(t => t.Donation).HasColumnName("DONATION");
            builder.Property(t => t.DonationsReceived).HasColumnName("DONATION_RECEIVED");
        }

        internal static class MemberListMapBuilder
        {
            public static MemberListMap CreateInstance()
            {
                return new MemberListMap();
            }
        }
    }
}