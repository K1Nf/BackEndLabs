using BackEndLabs.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace BackEndLabs.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(r => r.Id);
            builder.HasIndex(p => p.Name);
            builder.HasIndex(p => p.Code);

            builder.HasMany(r => r.Users)
                .WithMany(u => u.Roles)
                .UsingEntity(typeof(UsersAndRoles));


            builder.HasMany(r => r.Permissions)
                .WithMany(p => p.Roles)
                .UsingEntity(typeof(RolesAndPermissions));

            builder.HasQueryFilter(r => 
                r.Deleted_By == null &&
                r.Deleted_At == null);

            builder.HasData(new Role()
            {
                Id = 1,
                Name = "Admin",
                Code = "0001",
                Created_At = DateTime.UtcNow,
                Created_By = 1,

            }, new Role()
            {
                Id = 2,
                Name = "User",
                Code = "0002",
                Created_At = DateTime.UtcNow,
                Created_By = 1,
            },
            new Role()
            {
                Id = 3,
                Name = "Guest",
                Code = "0003",
                Created_At = DateTime.UtcNow,
                Created_By = 1,
            });
        }
    }
}
