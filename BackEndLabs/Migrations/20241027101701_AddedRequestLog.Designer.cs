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
    [Migration("20241027101701_AddedRequestLog")]
    partial class AddedRequestLog
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

                    b.Property<string>("EntityColumn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("EntityId")
                        .HasColumnType("integer");

                    b.Property<string>("EntityName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NewValue")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OldValue")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ChangeLogs");
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
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(2884),
                            Created_By = 1,
                            Name = "get_list_user"
                        },
                        new
                        {
                            Id = 7,
                            Code = "get_list_role",
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3351),
                            Created_By = 1,
                            Name = "get_list_role"
                        },
                        new
                        {
                            Id = 13,
                            Code = "get_list_permission",
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3358),
                            Created_By = 1,
                            Name = "get_list_permission"
                        },
                        new
                        {
                            Id = 2,
                            Code = "read_user",
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3344),
                            Created_By = 1,
                            Name = "read_user"
                        },
                        new
                        {
                            Id = 8,
                            Code = "read_role",
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3352),
                            Created_By = 1,
                            Name = "read_role"
                        },
                        new
                        {
                            Id = 14,
                            Code = "read_permission",
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3359),
                            Created_By = 1,
                            Name = "read_permission"
                        },
                        new
                        {
                            Id = 3,
                            Code = "create_user",
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3346),
                            Created_By = 1,
                            Name = "create_user"
                        },
                        new
                        {
                            Id = 9,
                            Code = "create_role",
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3353),
                            Created_By = 1,
                            Name = "create_role"
                        },
                        new
                        {
                            Id = 15,
                            Code = "create_permission",
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3360),
                            Created_By = 1,
                            Name = "create_permission"
                        },
                        new
                        {
                            Id = 4,
                            Code = "update_user",
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3347),
                            Created_By = 1,
                            Name = "update_user"
                        },
                        new
                        {
                            Id = 10,
                            Code = "update_role",
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3354),
                            Created_By = 1,
                            Name = "update_role"
                        },
                        new
                        {
                            Id = 16,
                            Code = "update_permission",
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3361),
                            Created_By = 1,
                            Name = "update_permission"
                        },
                        new
                        {
                            Id = 5,
                            Code = "delete_user",
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3348),
                            Created_By = 1,
                            Name = "delete_user"
                        },
                        new
                        {
                            Id = 11,
                            Code = "delete_role",
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3355),
                            Created_By = 1,
                            Name = "delete_role"
                        },
                        new
                        {
                            Id = 17,
                            Code = "delete_permission",
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3362),
                            Created_By = 1,
                            Name = "delete_permission"
                        },
                        new
                        {
                            Id = 6,
                            Code = "restore_user",
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3349),
                            Created_By = 1,
                            Name = "restore_user"
                        },
                        new
                        {
                            Id = 12,
                            Code = "restore_role",
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3356),
                            Created_By = 1,
                            Name = "restore_role"
                        },
                        new
                        {
                            Id = 18,
                            Code = "restore_permission",
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3364),
                            Created_By = 1,
                            Name = "restore_permission"
                        },
                        new
                        {
                            Id = 19,
                            Code = "get_story_user",
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3365),
                            Created_By = 1,
                            Name = "get_story_user"
                        },
                        new
                        {
                            Id = 20,
                            Code = "get_story_role",
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3366),
                            Created_By = 1,
                            Name = "get_story_role"
                        },
                        new
                        {
                            Id = 21,
                            Code = "get_story_permission",
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3367),
                            Created_By = 1,
                            Name = "get_story_permission"
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
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 563, DateTimeKind.Utc).AddTicks(745),
                            Created_By = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Code = "0002",
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 563, DateTimeKind.Utc).AddTicks(749),
                            Created_By = 1,
                            Name = "User"
                        },
                        new
                        {
                            Id = 3,
                            Code = "0003",
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 563, DateTimeKind.Utc).AddTicks(750),
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
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3305),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 2,
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3310),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 3,
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3312),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 4,
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3313),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 5,
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3314),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 6,
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3315),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 7,
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3316),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 8,
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3317),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 9,
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3319),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 10,
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3323),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 11,
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3324),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 12,
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3325),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 13,
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3326),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 14,
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3327),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 15,
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3328),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 16,
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3329),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 17,
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3330),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 18,
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3331),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 19,
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3332),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 20,
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3333),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 21,
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3334),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 2,
                            PermissionId = 1,
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3337),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 2,
                            PermissionId = 4,
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3338),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 2,
                            PermissionId = 10,
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3339),
                            Created_By = 1
                        },
                        new
                        {
                            RoleId = 3,
                            PermissionId = 1,
                            Created_At = new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3340),
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
