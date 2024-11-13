using BackEndLabs.Enum;
using BackEndLabs.Extensions;
using BackEndLabs.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security;

namespace BackEndLabs.Configuration
{
    public class PermissionConfiguration : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasIndex(p => p.Name);
            builder.HasIndex(p => p.Code);

            builder.HasMany(p => p.Roles)
                .WithMany(r => r.Permissions)
                .UsingEntity(typeof(RolesAndPermissions));

            //builder.HasData(PermissionsSeed.GetPermissions());

            builder.HasQueryFilter(p => 
                p.Deleted_By == null && 
                p.Deleted_At == null);
        }
    }
}
