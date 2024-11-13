using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackEndLabs.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Created_At = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Created_By = table.Column<int>(type: "integer", nullable: false),
                    Deleted_At = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Deleted_By = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Created_At = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Created_By = table.Column<int>(type: "integer", nullable: false),
                    Deleted_At = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Deleted_By = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tokens",
                columns: table => new
                {
                    Name = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ExpiresAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tokens", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    BirthDay = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RolesAndPermissions",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    PermissionId = table.Column<int>(type: "integer", nullable: false),
                    Created_At = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Created_By = table.Column<int>(type: "integer", nullable: false),
                    Deleted_At = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Deleted_By = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolesAndPermissions", x => new { x.RoleId, x.PermissionId });
                    table.ForeignKey(
                        name: "FK_RolesAndPermissions_Permissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_RolesAndPermissions_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "UsersAndRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    Created_At = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Created_By = table.Column<int>(type: "integer", nullable: false),
                    Deleted_At = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Deleted_By = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersAndRoles", x => new { x.RoleId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UsersAndRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_UsersAndRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Code", "Created_At", "Created_By", "Deleted_At", "Deleted_By", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "get_list_user", new DateTime(2024, 10, 22, 8, 17, 39, 355, DateTimeKind.Utc).AddTicks(9114), 1, null, null, null, "get_list_user" },
                    { 2, "read_user", new DateTime(2024, 10, 22, 8, 17, 39, 355, DateTimeKind.Utc).AddTicks(9577), 1, null, null, null, "read_user" },
                    { 3, "create_user", new DateTime(2024, 10, 22, 8, 17, 39, 355, DateTimeKind.Utc).AddTicks(9579), 1, null, null, null, "create_user" },
                    { 4, "update_user", new DateTime(2024, 10, 22, 8, 17, 39, 355, DateTimeKind.Utc).AddTicks(9580), 1, null, null, null, "update_user" },
                    { 5, "delete_user", new DateTime(2024, 10, 22, 8, 17, 39, 355, DateTimeKind.Utc).AddTicks(9581), 1, null, null, null, "delete_user" },
                    { 6, "restore_user", new DateTime(2024, 10, 22, 8, 17, 39, 355, DateTimeKind.Utc).AddTicks(9582), 1, null, null, null, "restore_user" },
                    { 7, "get_list_role", new DateTime(2024, 10, 22, 8, 17, 39, 355, DateTimeKind.Utc).AddTicks(9583), 1, null, null, null, "get_list_role" },
                    { 8, "read_role", new DateTime(2024, 10, 22, 8, 17, 39, 355, DateTimeKind.Utc).AddTicks(9584), 1, null, null, null, "read_role" },
                    { 9, "create_role", new DateTime(2024, 10, 22, 8, 17, 39, 355, DateTimeKind.Utc).AddTicks(9586), 1, null, null, null, "create_role" },
                    { 10, "update_role", new DateTime(2024, 10, 22, 8, 17, 39, 355, DateTimeKind.Utc).AddTicks(9587), 1, null, null, null, "update_role" },
                    { 11, "delete_role", new DateTime(2024, 10, 22, 8, 17, 39, 355, DateTimeKind.Utc).AddTicks(9588), 1, null, null, null, "delete_role" },
                    { 12, "restore_role", new DateTime(2024, 10, 22, 8, 17, 39, 355, DateTimeKind.Utc).AddTicks(9589), 1, null, null, null, "restore_role" },
                    { 13, "get_list_permission", new DateTime(2024, 10, 22, 8, 17, 39, 355, DateTimeKind.Utc).AddTicks(9590), 1, null, null, null, "get_list_permission" },
                    { 14, "read_permission", new DateTime(2024, 10, 22, 8, 17, 39, 355, DateTimeKind.Utc).AddTicks(9591), 1, null, null, null, "read_permission" },
                    { 15, "create_permission", new DateTime(2024, 10, 22, 8, 17, 39, 355, DateTimeKind.Utc).AddTicks(9592), 1, null, null, null, "create_permission" },
                    { 16, "update_permission", new DateTime(2024, 10, 22, 8, 17, 39, 355, DateTimeKind.Utc).AddTicks(9593), 1, null, null, null, "update_permission" },
                    { 17, "delete_permission", new DateTime(2024, 10, 22, 8, 17, 39, 355, DateTimeKind.Utc).AddTicks(9594), 1, null, null, null, "delete_permission" },
                    { 18, "restore_permission", new DateTime(2024, 10, 22, 8, 17, 39, 355, DateTimeKind.Utc).AddTicks(9595), 1, null, null, null, "restore_permission" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Code", "Created_At", "Created_By", "Deleted_At", "Deleted_By", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "0001", new DateTime(2024, 10, 22, 8, 17, 39, 657, DateTimeKind.Utc).AddTicks(5788), 1, null, null, null, "Admin" },
                    { 2, "0002", new DateTime(2024, 10, 22, 8, 17, 39, 657, DateTimeKind.Utc).AddTicks(5795), 1, null, null, null, "User" },
                    { 3, "0003", new DateTime(2024, 10, 22, 8, 17, 39, 657, DateTimeKind.Utc).AddTicks(5796), 1, null, null, null, "Guest" }
                });

            migrationBuilder.InsertData(
                table: "RolesAndPermissions",
                columns: new[] { "PermissionId", "RoleId", "Created_At", "Created_By", "Deleted_At", "Deleted_By" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2068), 1, null, null },
                    { 2, 1, new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2069), 1, null, null },
                    { 3, 1, new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2070), 1, null, null },
                    { 4, 1, new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2071), 1, null, null },
                    { 5, 1, new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2072), 1, null, null },
                    { 6, 1, new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2073), 1, null, null },
                    { 7, 1, new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2074), 1, null, null },
                    { 8, 1, new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2075), 1, null, null },
                    { 9, 1, new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2077), 1, null, null },
                    { 10, 1, new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2078), 1, null, null },
                    { 11, 1, new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2079), 1, null, null },
                    { 12, 1, new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2080), 1, null, null },
                    { 13, 1, new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2081), 1, null, null },
                    { 14, 1, new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2082), 1, null, null },
                    { 15, 1, new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2083), 1, null, null },
                    { 16, 1, new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2084), 1, null, null },
                    { 17, 1, new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2084), 1, null, null },
                    { 18, 1, new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2085), 1, null, null },
                    { 1, 2, new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2086), 1, null, null },
                    { 4, 2, new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2087), 1, null, null },
                    { 10, 2, new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2088), 1, null, null },
                    { 1, 3, new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2089), 1, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_Code",
                table: "Permissions",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_Name",
                table: "Permissions",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Code",
                table: "Roles",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Name",
                table: "Roles",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_RolesAndPermissions_PermissionId",
                table: "RolesAndPermissions",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersAndRoles_UserId",
                table: "UsersAndRoles",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RolesAndPermissions");

            migrationBuilder.DropTable(
                name: "Tokens");

            migrationBuilder.DropTable(
                name: "UsersAndRoles");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
