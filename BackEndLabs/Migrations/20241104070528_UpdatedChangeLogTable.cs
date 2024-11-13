using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEndLabs.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedChangeLogTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EntityColumn",
                table: "ChangeLogs");

            migrationBuilder.AlterColumn<string>(
                name: "ResponseBody",
                table: "LogsRequests",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "RequestBody",
                table: "LogsRequests",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "ControllerName",
                table: "LogsRequests",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "ActionName",
                table: "LogsRequests",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "OldValue",
                table: "ChangeLogs",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 603, DateTimeKind.Utc).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 603, DateTimeKind.Utc).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 603, DateTimeKind.Utc).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 603, DateTimeKind.Utc).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 603, DateTimeKind.Utc).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 603, DateTimeKind.Utc).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 603, DateTimeKind.Utc).AddTicks(9519));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 603, DateTimeKind.Utc).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 603, DateTimeKind.Utc).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 603, DateTimeKind.Utc).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 603, DateTimeKind.Utc).AddTicks(9524));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 603, DateTimeKind.Utc).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 603, DateTimeKind.Utc).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 603, DateTimeKind.Utc).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 603, DateTimeKind.Utc).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 603, DateTimeKind.Utc).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 603, DateTimeKind.Utc).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 603, DateTimeKind.Utc).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 603, DateTimeKind.Utc).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 603, DateTimeKind.Utc).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 603, DateTimeKind.Utc).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 867, DateTimeKind.Utc).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 867, DateTimeKind.Utc).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 867, DateTimeKind.Utc).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 1, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 868, DateTimeKind.Utc).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 2, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 868, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 3, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 868, DateTimeKind.Utc).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 4, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 868, DateTimeKind.Utc).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 5, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 868, DateTimeKind.Utc).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 6, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 868, DateTimeKind.Utc).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 7, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 868, DateTimeKind.Utc).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 8, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 868, DateTimeKind.Utc).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 9, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 868, DateTimeKind.Utc).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 10, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 868, DateTimeKind.Utc).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 11, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 868, DateTimeKind.Utc).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 12, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 868, DateTimeKind.Utc).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 13, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 868, DateTimeKind.Utc).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 14, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 868, DateTimeKind.Utc).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 15, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 868, DateTimeKind.Utc).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 16, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 868, DateTimeKind.Utc).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 17, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 868, DateTimeKind.Utc).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 18, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 868, DateTimeKind.Utc).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 19, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 868, DateTimeKind.Utc).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 20, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 868, DateTimeKind.Utc).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 21, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 868, DateTimeKind.Utc).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 1, 2 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 868, DateTimeKind.Utc).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 4, 2 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 868, DateTimeKind.Utc).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 10, 2 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 868, DateTimeKind.Utc).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 1, 3 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 5, 27, 868, DateTimeKind.Utc).AddTicks(5495));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ResponseBody",
                table: "LogsRequests",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RequestBody",
                table: "LogsRequests",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ControllerName",
                table: "LogsRequests",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ActionName",
                table: "LogsRequests",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OldValue",
                table: "ChangeLogs",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "EntityColumn",
                table: "ChangeLogs",
                type: "text",
                nullable: false,
                defaultValue: "");

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
    }
}
