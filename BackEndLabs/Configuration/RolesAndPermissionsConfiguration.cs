﻿using BackEndLabs.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BackEndLabs.Configuration
{
    public class RolesAndPermissionsConfiguration : IEntityTypeConfiguration<RolesAndPermissions>
    {
        public void Configure(EntityTypeBuilder<RolesAndPermissions> builder)
        {
            builder.HasKey(rp => new { rp.RoleId, rp.PermissionId});

            builder.HasOne(rp => rp.Role)
                .WithMany()
                .OnDelete(DeleteBehavior.SetNull);



            builder.HasOne(rp => rp.Permission)
                .WithMany()
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasQueryFilter(rp =>
                rp.Deleted_By == null &&
                rp.Deleted_At == null);


            builder.HasData(new RolesAndPermissions()
            {
                RoleId = 1,
                PermissionId = 1,
                Created_At = DateTime.UtcNow,
                Created_By = 1
            }, new RolesAndPermissions() 
            {
                RoleId = 1,
                PermissionId = 2,
                Created_At = DateTime.UtcNow,
                Created_By = 1
            }, new RolesAndPermissions()
            {
                RoleId = 1,
                PermissionId = 3,
                Created_At = DateTime.UtcNow,
                Created_By = 1
            }, new RolesAndPermissions()
            {
                RoleId = 1,
                PermissionId = 4,
                Created_At = DateTime.UtcNow,
                Created_By = 1
            }, new RolesAndPermissions()
            {
                RoleId = 1,
                PermissionId = 5,
                Created_At = DateTime.UtcNow,
                Created_By = 1
            }, new RolesAndPermissions()
            {
                RoleId = 1,
                PermissionId = 6,
                Created_At = DateTime.UtcNow,
                Created_By = 1
            }, new RolesAndPermissions()
            {
                RoleId = 1,
                PermissionId = 7,
                Created_At = DateTime.UtcNow,
                Created_By = 1
            }, new RolesAndPermissions()
            {
                RoleId = 1,
                PermissionId = 8,
                Created_At = DateTime.UtcNow,
                Created_By = 1
            }, new RolesAndPermissions()
            {
                RoleId = 1,
                PermissionId = 9,
                Created_At = DateTime.UtcNow,
                Created_By = 1
            }, new RolesAndPermissions()
            {
                RoleId = 1,
                PermissionId = 10,
                Created_At = DateTime.UtcNow,
                Created_By = 1
            }, new RolesAndPermissions()
            {
                RoleId = 1,
                PermissionId = 11,
                Created_At = DateTime.UtcNow,
                Created_By = 1
            }, new RolesAndPermissions()
            {
                RoleId = 1,
                PermissionId = 12,
                Created_At = DateTime.UtcNow,
                Created_By = 1
            }, new RolesAndPermissions()
            {
                RoleId = 1,
                PermissionId = 13,
                Created_At = DateTime.UtcNow,
                Created_By = 1
            }, new RolesAndPermissions()
            {
                RoleId = 1,
                PermissionId = 14,
                Created_At = DateTime.UtcNow,
                Created_By = 1
            }, new RolesAndPermissions()
            {
                RoleId = 1,
                PermissionId = 15,
                Created_At = DateTime.UtcNow,
                Created_By = 1
            }, new RolesAndPermissions()
            {
                RoleId = 1,
                PermissionId = 16,
                Created_At = DateTime.UtcNow,
                Created_By = 1
            }, new RolesAndPermissions()
            {
                RoleId = 1,
                PermissionId = 17,
                Created_At = DateTime.UtcNow,
                Created_By = 1
            }, new RolesAndPermissions()
            {
                RoleId = 1,
                PermissionId = 18,
                Created_At = DateTime.UtcNow,
                Created_By = 1
            }, 
            
            
            new RolesAndPermissions()
            {
                RoleId = 2,
                PermissionId = 1,
                Created_At = DateTime.UtcNow,
                Created_By = 1
            }, new RolesAndPermissions()
            {
                RoleId = 2,
                PermissionId = 4,
                Created_At = DateTime.UtcNow,
                Created_By = 1
            }, new RolesAndPermissions()
            {
                RoleId = 2,
                PermissionId = 10,
                Created_At = DateTime.UtcNow,
                Created_By = 1
            }, 
            
            
            new RolesAndPermissions()
            {
                RoleId = 3,
                PermissionId = 1,
                Created_At = DateTime.UtcNow,
                Created_By = 1
            }
            );
        }
    }
}