using Clash.Domain.Entities.API;
using Microsoft.EntityFrameworkCore;

namespace Clash.DataBase.Maps
{
    public class IconUrlsMap : IEntityTypeConfiguration<IconUrls>
    {
        void IEntityTypeConfiguration<IconUrls>.Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<IconUrls> builder)
        {
            builder.HasKey(iconUrls => iconUrls.Id);

            builder.Property(t => t.Small).HasColumnName("SMALL");
            builder.Property(t => t.Tiny).HasColumnName("TINY");
            builder.Property(t => t.Medium).HasColumnName("MEDIUM");
        }

        internal static class IconUrlsMapBuilder
        {
            public static IconUrlsMap CreateInstance()
            {
                return new IconUrlsMap();
            }
        }
    }
}