using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BackEndLabs.Migrations
{
    /// <inheritdoc />
    public partial class AddedRequestLog2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LogsRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Path = table.Column<string>(type: "text", nullable: false),
                    Method = table.Column<string>(type: "text", nullable: false),
                    ControllerName = table.Column<string>(type: "text", nullable: false),
                    ActionName = table.Column<string>(type: "text", nullable: false),
                    RequestBody = table.Column<string>(type: "text", nullable: false),
                    RequestHeaders = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    IpAddress = table.Column<string>(type: "text", nullable: false),
                    UserAgent = table.Column<string>(type: "text", nullable: false),
                    StatusCode = table.Column<int>(type: "integer", nullable: false),
                    ResponseBody = table.Column<string>(type: "text", nullable: false),
                    ResponseHeaders = table.Column<string>(type: "text", nullable: false),
                    Created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogsRequests", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 218, DateTimeKind.Utc).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 218, DateTimeKind.Utc).AddTicks(1175));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 218, DateTimeKind.Utc).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 218, DateTimeKind.Utc).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 218, DateTimeKind.Utc).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 218, DateTimeKind.Utc).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 218, DateTimeKind.Utc).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 218, DateTimeKind.Utc).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 218, DateTimeKind.Utc).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 218, DateTimeKind.Utc).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 218, DateTimeKind.Utc).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 218, DateTimeKind.Utc).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 218, DateTimeKind.Utc).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 218, DateTimeKind.Utc).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 218, DateTimeKind.Utc).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 218, DateTimeKind.Utc).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 218, DateTimeKind.Utc).AddTicks(1273));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 218, DateTimeKind.Utc).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 218, DateTimeKind.Utc).AddTicks(1276));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 218, DateTimeKind.Utc).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 218, DateTimeKind.Utc).AddTicks(1279));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 523, DateTimeKind.Utc).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 523, DateTimeKind.Utc).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 523, DateTimeKind.Utc).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 1, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 524, DateTimeKind.Utc).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 2, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 524, DateTimeKind.Utc).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 3, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 524, DateTimeKind.Utc).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 4, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 524, DateTimeKind.Utc).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 5, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 524, DateTimeKind.Utc).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 6, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 524, DateTimeKind.Utc).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 7, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 524, DateTimeKind.Utc).AddTicks(1495));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 8, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 524, DateTimeKind.Utc).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 9, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 524, DateTimeKind.Utc).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 10, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 524, DateTimeKind.Utc).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 11, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 524, DateTimeKind.Utc).AddTicks(1499));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 12, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 524, DateTimeKind.Utc).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 13, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 524, DateTimeKind.Utc).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 14, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 524, DateTimeKind.Utc).AddTicks(1503));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 15, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 524, DateTimeKind.Utc).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 16, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 524, DateTimeKind.Utc).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 17, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 524, DateTimeKind.Utc).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 18, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 524, DateTimeKind.Utc).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 19, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 524, DateTimeKind.Utc).AddTicks(1509));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 20, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 524, DateTimeKind.Utc).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 21, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 524, DateTimeKind.Utc).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 1, 2 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 524, DateTimeKind.Utc).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 4, 2 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 524, DateTimeKind.Utc).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 10, 2 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 524, DateTimeKind.Utc).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 1, 3 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 18, 26, 524, DateTimeKind.Utc).AddTicks(1514));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LogsRequests");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3348));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3358));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3365));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 258, DateTimeKind.Utc).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 563, DateTimeKind.Utc).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 563, DateTimeKind.Utc).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 563, DateTimeKind.Utc).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 1, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 2, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 3, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 4, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 5, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3314));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 6, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 7, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 8, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 9, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 10, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 11, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 12, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 13, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 14, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 15, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 16, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3329));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 17, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 18, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 19, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 20, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 21, 1 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 1, 2 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 4, 2 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 10, 2 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 1, 3 },
                column: "Created_At",
                value: new DateTime(2024, 10, 27, 10, 17, 0, 564, DateTimeKind.Utc).AddTicks(3340));
        }
    }
}
