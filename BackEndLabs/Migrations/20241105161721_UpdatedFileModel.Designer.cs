﻿// <auto-generated />
using System;
using BackEndLabs.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BackEndLabs.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241105161721_UpdatedFileModel")]
    partial class UpdatedFileModel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BackEndLabs.Models.ChangeLogs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Created_By")
                        .HasColumnType("integer");

                    b.Property<int>("EntityId")
                        .HasColumnType("integer");

                    b.Property<string>("EntityName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NewValue")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OldValue")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ChangeLogs");
                });

            modelBuilder.Entity("BackEndLabs.Models.File", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Created_By")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Deleted_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Deleted_By")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Format")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Created_By");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("BackEndLabs.Models.LogsRequests", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ActionName")
                        .HasColumnType("text");

                    b.Property<string>("ControllerName")
                        .HasColumnType("text");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("IpAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Method")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RequestBody")
                        .HasColumnType("text");

                    b.Property<string>("RequestHeaders")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ResponseBody")
                        .HasColumnType("text");

                    b.Property<string>("ResponseHeaders")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("StatusCode")
                        .HasColumnType("integer");

                    b.Property<string>("UserAgent")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("LogsRequests");
                });

            modelBuilder.Entity("BackEndLabs.Models.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Created_By")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("Deleted_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("Deleted_By")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Code");

                    b.HasIndex("Name");

                    b.ToTable("Permissions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "get_list_user",
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 19, 989, DateTimeKind.Utc).AddTicks(9241),
                            Created_By = 1,
                            Name = "get_list_user"
                        },
                        new
                        {
                            Id = 7,
                            Code = "get_list_role",
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 19, 989, DateTimeKind.Utc).AddTicks(9752),
                            Created_By = 1,
                            Name = "get_list_role"
                        },
                        new
                        {
                            Id = 13,
                            Code = "get_list_permission",
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 19, 989, DateTimeKind.Utc).AddTicks(9761),
                            Created_By = 1,
                            Name = "get_list_permission"
                        },
                        new
                        {
                            Id = 2,
                            Code = "read_user",
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 19, 989, DateTimeKind.Utc).AddTicks(9745),
                            Created_By = 1,
                            Name = "read_user"
                        },
                        new
                        {
                            Id = 8,
                            Code = "read_role",
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 19, 989, DateTimeKind.Utc).AddTicks(9754),
                            Created_By = 1,
                            Name = "read_role"
                        },
                        new
                        {
                            Id = 14,
                            Code = "read_permission",
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 19, 989, DateTimeKind.Utc).AddTicks(9763),
                            Created_By = 1,
                            Name = "read_permission"
                        },
                        new
                        {
                            Id = 3,
                            Code = "create_user",
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 19, 989, DateTimeKind.Utc).AddTicks(9747),
                            Created_By = 1,
                            Name = "create_user"
                        },
                        new
                        {
                            Id = 9,
                            Code = "create_role",
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 19, 989, DateTimeKind.Utc).AddTicks(9755),
                            Created_By = 1,
                            Name = "create_role"
                        },
                        new
                        {
                            Id = 15,
                            Code = "create_permission",
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 19, 989, DateTimeKind.Utc).AddTicks(9764),
                            Created_By = 1,
                            Name = "create_permission"
                        },
                        new
                        {
                            Id = 4,
                            Code = "update_user",
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 19, 989, DateTimeKind.Utc).AddTicks(9748),
                            Created_By = 1,
                            Name = "update_user"
                        },
                        new
                        {
                            Id = 10,
                            Code = "update_role",
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 19, 989, DateTimeKind.Utc).AddTicks(9757),
                            Created_By = 1,
                            Name = "update_role"
                        },
                        new
                        {
                            Id = 16,
                            Code = "update_permission",
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 19, 989, DateTimeKind.Utc).AddTicks(9765),
                            Created_By = 1,
                            Name = "update_permission"
                        },
                        new
                        {
                            Id = 5,
                            Code = "delete_user",
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 19, 989, DateTimeKind.Utc).AddTicks(9750),
                            Created_By = 1,
                            Name = "delete_user"
                        },
                        new
                        {
                            Id = 11,
                            Code = "delete_role",
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 19, 989, DateTimeKind.Utc).AddTicks(9758),
                            Created_By = 1,
                            Name = "delete_role"
                        },
                        new
                        {
                            Id = 17,
                            Code = "delete_permission",
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 19, 989, DateTimeKind.Utc).AddTicks(9767),
                            Created_By = 1,
                            Name = "delete_permission"
                        },
                        new
                        {
                            Id = 6,
                            Code = "restore_user",
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 19, 989, DateTimeKind.Utc).AddTicks(9751),
                            Created_By = 1,
                            Name = "restore_user"
                        },
                        new
                        {
                            Id = 12,
                            Code = "restore_role",
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 19, 989, DateTimeKind.Utc).AddTicks(9759),
                            Created_By = 1,
                            Name = "restore_role"
                        },
                        new
                        {
                            Id = 18,
                            Code = "restore_permission",
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 19, 989, DateTimeKind.Utc).AddTicks(9768),
                            Created_By = 1,
                            Name = "restore_permission"
                        },
                        new
                        {
                            Id = 19,
                            Code = "get_story_user",
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 19, 989, DateTimeKind.Utc).AddTicks(9770),
                            Created_By = 1,
                            Name = "get_story_user"
                        },
                        new
                        {
                            Id = 20,
                            Code = "get_story_role",
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 19, 989, DateTimeKind.Utc).AddTicks(9771),
                            Created_By = 1,
                            Name = "get_story_role"
                        },
                        new
                        {
                            Id = 21,
                            Code = "get_story_permission",
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 19, 989, DateTimeKind.Utc).AddTicks(9773),
                            Created_By = 1,
                            Name = "get_story_permission"
                        },
                        new
                        {
                            Id = 23,
                            Code = "rollback_role",
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 19, 989, DateTimeKind.Utc).AddTicks(9776),
                            Created_By = 1,
                            Name = "rollback_role"
                        },
                        new
                        {
                            Id = 22,
                            Code = "rollback_permission",
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 19, 989, DateTimeKind.Utc).AddTicks(9775),
                            Created_By = 1,
                            Name = "rollback_permission"
                        });
                });

            modelBuilder.Entity("BackEndLabs.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Created_By")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("Deleted_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("Deleted_By")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Code");

                    b.HasIndex("Name");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "0001",
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 20, 411, DateTimeKind.Utc).AddTicks(2212),
                            Created_By = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Code = "0002",
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 20, 411, DateTimeKind.Utc).AddTicks(2216),
                            Created_By = 1,
                            Name = "User"
                        },
                        new
                        {
                            Id = 3,
                            Code = "0003",
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 20, 411, DateTimeKind.Utc).AddTicks(2218),
                            Created_By = 1,
                            Name = "Guest"
                        });
                });

            modelBuilder.Entity("BackEndLabs.Models.RolesAndPermissions", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<int>("PermissionId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Created_By")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("Deleted_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("Deleted_By")
                        .HasColumnType("integer");

                    b.HasKey("RoleId", "PermissionId");

                    b.HasIndex("PermissionId");

                    b.ToTable("RolesAndPermissions");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            PermissionId = 1,
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 20, 412, DateTimeKind.Utc).AddTicks(68),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 2,
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 20, 412, DateTimeKind.Utc).AddTicks(71),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 3,
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 20, 412, DateTimeKind.Utc).AddTicks(72),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 4,
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 20, 412, DateTimeKind.Utc).AddTicks(73),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 5,
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 20, 412, DateTimeKind.Utc).AddTicks(74),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 6,
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 20, 412, DateTimeKind.Utc).AddTicks(75),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 7,
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 20, 412, DateTimeKind.Utc).AddTicks(76),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 8,
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 20, 412, DateTimeKind.Utc).AddTicks(77),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 9,
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 20, 412, DateTimeKind.Utc).AddTicks(78),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 10,
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 20, 412, DateTimeKind.Utc).AddTicks(79),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 11,
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 20, 412, DateTimeKind.Utc).AddTicks(80),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 12,
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 20, 412, DateTimeKind.Utc).AddTicks(81),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 13,
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 20, 412, DateTimeKind.Utc).AddTicks(82),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 14,
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 20, 412, DateTimeKind.Utc).AddTicks(83),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 15,
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 20, 412, DateTimeKind.Utc).AddTicks(84),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 16,
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 20, 412, DateTimeKind.Utc).AddTicks(85),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 17,
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 20, 412, DateTimeKind.Utc).AddTicks(86),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 18,
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 20, 412, DateTimeKind.Utc).AddTicks(87),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 19,
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 20, 412, DateTimeKind.Utc).AddTicks(88),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 20,
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 20, 412, DateTimeKind.Utc).AddTicks(89),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 21,
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 20, 412, DateTimeKind.Utc).AddTicks(90),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 2,
                            PermissionId = 1,
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 20, 412, DateTimeKind.Utc).AddTicks(92),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 2,
                            PermissionId = 4,
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 20, 412, DateTimeKind.Utc).AddTicks(93),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 2,
                            PermissionId = 10,
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 20, 412, DateTimeKind.Utc).AddTicks(94),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 3,
                            PermissionId = 1,
                            Created_At = new DateTime(2024, 11, 5, 16, 17, 20, 412, DateTimeKind.Utc).AddTicks(95),
                            Created_By = 1
                        });
                });

            modelBuilder.Entity("BackEndLabs.Models.Token", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("ExpiresAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Name");

                    b.ToTable("Tokens");
                });

            modelBuilder.Entity("BackEndLabs.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("BirthDay")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BackEndLabs.Models.UsersAndRoles", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Created_By")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("Deleted_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("Deleted_By")
                        .HasColumnType("integer");

                    b.HasKey("RoleId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UsersAndRoles");
                });

            modelBuilder.Entity("BackEndLabs.Models.File", b =>
                {
                    b.HasOne("BackEndLabs.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("Created_By")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BackEndLabs.Models.RolesAndPermissions", b =>
                {
                    b.HasOne("BackEndLabs.Models.Permission", "Permission")
                        .WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("BackEndLabs.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("BackEndLabs.Models.UsersAndRoles", b =>
                {
                    b.HasOne("BackEndLabs.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("BackEndLabs.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
