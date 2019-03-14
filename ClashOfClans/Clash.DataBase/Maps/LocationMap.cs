using Clash.Domain.Entities.API;
using Microsoft.EntityFrameworkCore;

namespace Clash.DataBase.Maps
{
    public class LocationMap : IEntityTypeConfiguration<Location>
    {
        void IEntityTypeConfiguration<Location>.Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Location> builder)
        {
            builder.HasKey(location => location.Id);
            builder.Property(t => t.Name).HasColumnName("NOME");
            builder.Property(t => t.IsCountry).HasColumnName("IS_COUNTRY");
            builder.Property(t => t.CountryCode).HasColumnName("CODE_COUNTRY");
        }

        internal static class LocationMapBuilder
        {
            public static LocationMap CreateInstance()
            {
                return new LocationMap();
            }
        }
    }
}