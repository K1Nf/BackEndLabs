using BackEndLabs.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BackEndLabs.Configuration
{
    public class UsersAndRolesConfiguration : IEntityTypeConfiguration<UsersAndRoles>
    {
        public void Configure(EntityTypeBuilder<UsersAndRoles> builder)
        {
            builder.HasKey(ur => new { ur.RoleId, ur.UserId });

            builder.HasOne(rp => rp.Role)
                .WithMany()
                .OnDelete(DeleteBehavior.SetNull);


            builder.HasQueryFilter(ur =>
                ur.Deleted_By == null &&
                ur.Deleted_At == null);


            builder.HasOne(rp => rp.User)
                .WithMany()
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
