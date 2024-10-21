using BackEndLabs.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BackEndLabs.Configuration
{
    public class PermissionConfiguration : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            //builder.HasKey(p => p.Id);

            builder.HasIndex(p => p.Name);
            builder.HasIndex(p => p.Code);

            builder.HasMany(p => p.Roles)
                .WithMany(r => r.Permissions)
                .UsingEntity(typeof(RolesAndPermissions));

            builder.HasData(new Permission()
            {
                Id = 1,
                Name = "Get-list-users",
                Code = "0001",
                Created_At = DateTime.UtcNow,
                Created_By = 1,

            }, new Permission()
            {
                Id = 2,
                Name = "Get-list-role",
                Code = "0002",
                Created_At = DateTime.UtcNow,
                Created_By = 1,
            },
            new Permission()
            {
                Id = 3,
                Name = "Get-list-permission",
                Code = "0003",
                Created_At = DateTime.UtcNow,
                Created_By = 1,
            }, 
            

            new Permission()
            {
                Id = 4,
                Name = "Read-users",
                Code = "0004",
                Created_At = DateTime.UtcNow,
                Created_By = 1,

            }, new Permission()
            {
                Id = 5,
                Name = "Read-role",
                Code = "0005",
                Created_At = DateTime.UtcNow,
                Created_By = 1,
            },
            new Permission()
            {
                Id = 6,
                Name = "Read-permission",
                Code = "0006",
                Created_At = DateTime.UtcNow,
                Created_By = 1,
            }, 
            

            new Permission()
            {
                Id = 7,
                Name = "Create-users",
                Code = "0007",
                Created_At = DateTime.UtcNow,
                Created_By = 1,

            }, new Permission()
            {
                Id = 8,
                Name = "Create-role",
                Code = "0008",
                Created_At = DateTime.UtcNow,
                Created_By = 1,
            },
            new Permission()
            {
                Id = 9,
                Name = "Create-permission",
                Code = "0009",
                Created_At = DateTime.UtcNow,
                Created_By = 1,
            }, 
            

            new Permission()
            {
                Id = 10,
                Name = "Update-users",
                Code = "0010",
                Created_At = DateTime.UtcNow,
                Created_By = 1,

            }, new Permission()
            {
                Id = 11,
                Name = "Update-role",
                Code = "0011",
                Created_At = DateTime.UtcNow,
                Created_By = 1,
            },
            new Permission()
            {
                Id = 12,
                Name = "Update-permission",
                Code = "0012",
                Created_At = DateTime.UtcNow,
                Created_By = 1,
            }, 
            

            new Permission()
            {
                Id = 13,
                Name = "Delete-users",
                Code = "0013",
                Created_At = DateTime.UtcNow,
                Created_By = 1,

            }, new Permission()
            {
                Id = 14,
                Name = "Delete-role",
                Code = "0014",
                Created_At = DateTime.UtcNow,
                Created_By = 1,
            },
            new Permission()
            {
                Id = 15,
                Name = "Delete-permission",
                Code = "0015",
                Created_At = DateTime.UtcNow,
                Created_By = 1,
            },


            new Permission()
            {
                Id = 16,
                Name = "Restore-users",
                Code = "0016",
                Created_At = DateTime.UtcNow,
                Created_By = 1,

            }, new Permission()
            {
                Id = 17,
                Name = "Restore-role",
                Code = "0017",
                Created_At = DateTime.UtcNow,
                Created_By = 1,
            },
            new Permission()
            {
                Id = 18,
                Name = "Restore-permission",
                Code = "0018",
                Created_At = DateTime.UtcNow,
                Created_By = 1,
            });


            builder.HasQueryFilter(p => 
                p.Deleted_By == null && 
                p.Deleted_At == null);
        }
    }
}
