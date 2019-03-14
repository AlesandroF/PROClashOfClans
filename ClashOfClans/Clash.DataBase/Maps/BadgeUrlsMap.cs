using Clash.Domain.Entities.API;
using Microsoft.EntityFrameworkCore;

namespace Clash.DataBase.Maps
{
    public class BadgeUrlsMap : IEntityTypeConfiguration<BadgeUrls>
    {
        void IEntityTypeConfiguration<BadgeUrls>.Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<BadgeUrls> builder)
        {
            builder.HasKey(badge => badge.Id);

            builder.Property(t => t.Small).HasColumnName("SMALL");
            builder.Property(t => t.Large).HasColumnName("LARGE");
            builder.Property(t => t.Medium).HasColumnName("MEDIUM");
        }

        internal static class BadgeUrlsMapBuilder
        {
            public static BadgeUrlsMap CreateInstance()
            {
                return new BadgeUrlsMap();
            }
        }
    }
}