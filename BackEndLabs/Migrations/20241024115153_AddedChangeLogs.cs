using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackEndLabs.Migrations
{
    /// <inheritdoc />
    public partial class AddedChangeLogs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChangeLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EntityId = table.Column<int>(type: "integer", nullable: false),
                    EntityName = table.Column<string>(type: "text", nullable: false),
                    EntityColumn = table.Column<string>(type: "text", nullable: false),
                    OldValue = table.Column<string>(type: "text", nullable: true),
                    NewValue = table.Column<string>(type: "text", nullable: false),
                    Created_At = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Created_By = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChangeLogs", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 522, DateTimeKind.Utc).AddTicks(1934));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 522, DateTimeKind.Utc).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 522, DateTimeKind.Utc).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 522, DateTimeKind.Utc).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 522, DateTimeKind.Utc).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 522, DateTimeKind.Utc).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 522, DateTimeKind.Utc).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 522, DateTimeKind.Utc).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 522, DateTimeKind.Utc).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 522, DateTimeKind.Utc).AddTicks(2403));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 522, DateTimeKind.Utc).AddTicks(2404));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 522, DateTimeKind.Utc).AddTicks(2405));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 522, DateTimeKind.Utc).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 522, DateTimeKind.Utc).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 522, DateTimeKind.Utc).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 522, DateTimeKind.Utc).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 522, DateTimeKind.Utc).AddTicks(2489));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 522, DateTimeKind.Utc).AddTicks(2490));

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Code", "Created_At", "Created_By", "Deleted_At", "Deleted_By", "Description", "Name" },
                values: new object[,]
                {
                    { 19, "get_story_user", new DateTime(2024, 10, 24, 11, 51, 52, 522, DateTimeKind.Utc).AddTicks(2492), 1, null, null, null, "get_story_user" },
                    { 20, "get_story_role", new DateTime(2024, 10, 24, 11, 51, 52, 522, DateTimeKind.Utc).AddTicks(2493), 1, null, null, null, "get_story_role" },
                    { 21, "get_story_permission", new DateTime(2024, 10, 24, 11, 51, 52, 522, DateTimeKind.Utc).AddTicks(2494), 1, null, null, null, "get_story_permission" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 806, DateTimeKind.Utc).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 806, DateTimeKind.Utc).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 806, DateTimeKind.Utc).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 1, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 807, DateTimeKind.Utc).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 2, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 807, DateTimeKind.Utc).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 3, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 807, DateTimeKind.Utc).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 4, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 807, DateTimeKind.Utc).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 5, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 807, DateTimeKind.Utc).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 6, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 807, DateTimeKind.Utc).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 7, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 807, DateTimeKind.Utc).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 8, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 807, DateTimeKind.Utc).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 9, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 807, DateTimeKind.Utc).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 10, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 807, DateTimeKind.Utc).AddTicks(3358));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 11, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 807, DateTimeKind.Utc).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 12, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 807, DateTimeKind.Utc).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 13, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 807, DateTimeKind.Utc).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 14, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 807, DateTimeKind.Utc).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 15, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 807, DateTimeKind.Utc).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 16, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 807, DateTimeKind.Utc).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 17, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 807, DateTimeKind.Utc).AddTicks(3365));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 18, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 807, DateTimeKind.Utc).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 1, 2 },
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 807, DateTimeKind.Utc).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 4, 2 },
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 807, DateTimeKind.Utc).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 10, 2 },
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 807, DateTimeKind.Utc).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 1, 3 },
                column: "Created_At",
                value: new DateTime(2024, 10, 24, 11, 51, 52, 807, DateTimeKind.Utc).AddTicks(3373));

            migrationBuilder.InsertData(
                table: "RolesAndPermissions",
                columns: new[] { "PermissionId", "RoleId", "Created_At", "Created_By", "Deleted_At", "Deleted_By" },
                values: new object[,]
                {
                    { 19, 1, new DateTime(2024, 10, 24, 11, 51, 52, 807, DateTimeKind.Utc).AddTicks(3367), 1, null, null },
                    { 20, 1, new DateTime(2024, 10, 24, 11, 51, 52, 807, DateTimeKind.Utc).AddTicks(3368), 1, null, null },
                    { 21, 1, new DateTime(2024, 10, 24, 11, 51, 52, 807, DateTimeKind.Utc).AddTicks(3369), 1, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChangeLogs");

            migrationBuilder.DeleteData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 21, 1 });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 355, DateTimeKind.Utc).AddTicks(9114));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 355, DateTimeKind.Utc).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 355, DateTimeKind.Utc).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 355, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 355, DateTimeKind.Utc).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 355, DateTimeKind.Utc).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 355, DateTimeKind.Utc).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 355, DateTimeKind.Utc).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 355, DateTimeKind.Utc).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 355, DateTimeKind.Utc).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 355, DateTimeKind.Utc).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 355, DateTimeKind.Utc).AddTicks(9589));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 355, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 355, DateTimeKind.Utc).AddTicks(9591));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 355, DateTimeKind.Utc).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 355, DateTimeKind.Utc).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 355, DateTimeKind.Utc).AddTicks(9594));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 355, DateTimeKind.Utc).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 657, DateTimeKind.Utc).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 657, DateTimeKind.Utc).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 657, DateTimeKind.Utc).AddTicks(5796));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 1, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 2, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 3, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 4, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 5, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 6, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 7, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 8, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 9, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 10, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 11, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 12, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 13, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 14, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 15, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 16, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 17, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 18, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 1, 2 },
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 4, 2 },
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 10, 2 },
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 1, 3 },
                column: "Created_At",
                value: new DateTime(2024, 10, 22, 8, 17, 39, 658, DateTimeKind.Utc).AddTicks(2089));
        }
    }
}
