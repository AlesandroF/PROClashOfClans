using Clash.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Clash.DataBase.Maps
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        void IEntityTypeConfiguration<User>.Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<User> builder)
        {
            builder.HasKey(user => user.Id);
            builder.Property(user => user.UserName);
            builder.Property(user => user.Password);
            builder.Property(user => user.Role);
        }

        internal static class UserMapBuilder
        {
            public static UserMap CreateInstance()
            {
                return new UserMap();
            }
        }
    }
}