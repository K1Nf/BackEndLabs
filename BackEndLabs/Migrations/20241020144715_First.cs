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
                    { 1, "0001", new DateTime(2024, 10, 20, 14, 47, 15, 104, DateTimeKind.Utc).AddTicks(9880), 1, null, null, null, "Get-list-users" },
                    { 2, "0002", new DateTime(2024, 10, 20, 14, 47, 15, 104, DateTimeKind.Utc).AddTicks(9883), 1, null, null, null, "Get-list-role" },
                    { 3, "0003", new DateTime(2024, 10, 20, 14, 47, 15, 104, DateTimeKind.Utc).AddTicks(9885), 1, null, null, null, "Get-list-permission" },
                    { 4, "0004", new DateTime(2024, 10, 20, 14, 47, 15, 104, DateTimeKind.Utc).AddTicks(9886), 1, null, null, null, "Read-users" },
                    { 5, "0005", new DateTime(2024, 10, 20, 14, 47, 15, 104, DateTimeKind.Utc).AddTicks(9888), 1, null, null, null, "Read-role" },
                    { 6, "0006", new DateTime(2024, 10, 20, 14, 47, 15, 104, DateTimeKind.Utc).AddTicks(9889), 1, null, null, null, "Read-permission" },
                    { 7, "0007", new DateTime(2024, 10, 20, 14, 47, 15, 104, DateTimeKind.Utc).AddTicks(9890), 1, null, null, null, "Create-users" },
                    { 8, "0008", new DateTime(2024, 10, 20, 14, 47, 15, 104, DateTimeKind.Utc).AddTicks(9891), 1, null, null, null, "Create-role" },
                    { 9, "0009", new DateTime(2024, 10, 20, 14, 47, 15, 104, DateTimeKind.Utc).AddTicks(9893), 1, null, null, null, "Create-permission" },
                    { 10, "0010", new DateTime(2024, 10, 20, 14, 47, 15, 104, DateTimeKind.Utc).AddTicks(9894), 1, null, null, null, "Update-users" },
                    { 11, "0011", new DateTime(2024, 10, 20, 14, 47, 15, 104, DateTimeKind.Utc).AddTicks(9895), 1, null, null, null, "Update-role" },
                    { 12, "0012", new DateTime(2024, 10, 20, 14, 47, 15, 104, DateTimeKind.Utc).AddTicks(9897), 1, null, null, null, "Update-permission" },
                    { 13, "0013", new DateTime(2024, 10, 20, 14, 47, 15, 104, DateTimeKind.Utc).AddTicks(9898), 1, null, null, null, "Delete-users" },
                    { 14, "0014", new DateTime(2024, 10, 20, 14, 47, 15, 104, DateTimeKind.Utc).AddTicks(9899), 1, null, null, null, "Delete-role" },
                    { 15, "0015", new DateTime(2024, 10, 20, 14, 47, 15, 104, DateTimeKind.Utc).AddTicks(9900), 1, null, null, null, "Delete-permission" },
                    { 16, "0016", new DateTime(2024, 10, 20, 14, 47, 15, 104, DateTimeKind.Utc).AddTicks(9902), 1, null, null, null, "Restore-users" },
                    { 17, "0017", new DateTime(2024, 10, 20, 14, 47, 15, 104, DateTimeKind.Utc).AddTicks(9903), 1, null, null, null, "Restore-role" },
                    { 18, "0018", new DateTime(2024, 10, 20, 14, 47, 15, 104, DateTimeKind.Utc).AddTicks(9904), 1, null, null, null, "Restore-permission" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Code", "Created_At", "Created_By", "Deleted_At", "Deleted_By", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "0001", new DateTime(2024, 10, 20, 14, 47, 15, 104, DateTimeKind.Utc).AddTicks(8071), 1, null, null, null, "Admin" },
                    { 2, "0002", new DateTime(2024, 10, 20, 14, 47, 15, 104, DateTimeKind.Utc).AddTicks(8075), 1, null, null, null, "User" },
                    { 3, "0003", new DateTime(2024, 10, 20, 14, 47, 15, 104, DateTimeKind.Utc).AddTicks(8076), 1, null, null, null, "Guest" }
                });

            migrationBuilder.InsertData(
                table: "RolesAndPermissions",
                columns: new[] { "PermissionId", "RoleId", "Created_At", "Created_By", "Deleted_At", "Deleted_By" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 10, 20, 14, 47, 15, 106, DateTimeKind.Utc).AddTicks(1328), 1, null, null },
                    { 2, 1, new DateTime(2024, 10, 20, 14, 47, 15, 106, DateTimeKind.Utc).AddTicks(1331), 1, null, null },
                    { 3, 1, new DateTime(2024, 10, 20, 14, 47, 15, 106, DateTimeKind.Utc).AddTicks(1332), 1, null, null },
                    { 4, 1, new DateTime(2024, 10, 20, 14, 47, 15, 106, DateTimeKind.Utc).AddTicks(1333), 1, null, null },
                    { 5, 1, new DateTime(2024, 10, 20, 14, 47, 15, 106, DateTimeKind.Utc).AddTicks(1334), 1, null, null },
                    { 6, 1, new DateTime(2024, 10, 20, 14, 47, 15, 106, DateTimeKind.Utc).AddTicks(1335), 1, null, null },
                    { 7, 1, new DateTime(2024, 10, 20, 14, 47, 15, 106, DateTimeKind.Utc).AddTicks(1336), 1, null, null },
                    { 8, 1, new DateTime(2024, 10, 20, 14, 47, 15, 106, DateTimeKind.Utc).AddTicks(1337), 1, null, null },
                    { 9, 1, new DateTime(2024, 10, 20, 14, 47, 15, 106, DateTimeKind.Utc).AddTicks(1338), 1, null, null },
                    { 10, 1, new DateTime(2024, 10, 20, 14, 47, 15, 106, DateTimeKind.Utc).AddTicks(1338), 1, null, null },
                    { 11, 1, new DateTime(2024, 10, 20, 14, 47, 15, 106, DateTimeKind.Utc).AddTicks(1339), 1, null, null },
                    { 12, 1, new DateTime(2024, 10, 20, 14, 47, 15, 106, DateTimeKind.Utc).AddTicks(1340), 1, null, null },
                    { 13, 1, new DateTime(2024, 10, 20, 14, 47, 15, 106, DateTimeKind.Utc).AddTicks(1341), 1, null, null },
                    { 14, 1, new DateTime(2024, 10, 20, 14, 47, 15, 106, DateTimeKind.Utc).AddTicks(1342), 1, null, null },
                    { 15, 1, new DateTime(2024, 10, 20, 14, 47, 15, 106, DateTimeKind.Utc).AddTicks(1343), 1, null, null },
                    { 16, 1, new DateTime(2024, 10, 20, 14, 47, 15, 106, DateTimeKind.Utc).AddTicks(1348), 1, null, null },
                    { 17, 1, new DateTime(2024, 10, 20, 14, 47, 15, 106, DateTimeKind.Utc).AddTicks(1354), 1, null, null },
                    { 18, 1, new DateTime(2024, 10, 20, 14, 47, 15, 106, DateTimeKind.Utc).AddTicks(1355), 1, null, null },
                    { 1, 2, new DateTime(2024, 10, 20, 14, 47, 15, 106, DateTimeKind.Utc).AddTicks(1356), 1, null, null },
                    { 4, 2, new DateTime(2024, 10, 20, 14, 47, 15, 106, DateTimeKind.Utc).AddTicks(1357), 1, null, null },
                    { 10, 2, new DateTime(2024, 10, 20, 14, 47, 15, 106, DateTimeKind.Utc).AddTicks(1359), 1, null, null },
                    { 1, 3, new DateTime(2024, 10, 20, 14, 47, 15, 106, DateTimeKind.Utc).AddTicks(1360), 1, null, null }
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
