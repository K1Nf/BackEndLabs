using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackEndLabs.Migrations
{
    /// <inheritdoc />
    public partial class AddedPermissionsForRollback : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 369, DateTimeKind.Utc).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 369, DateTimeKind.Utc).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 369, DateTimeKind.Utc).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 369, DateTimeKind.Utc).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 369, DateTimeKind.Utc).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 369, DateTimeKind.Utc).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 369, DateTimeKind.Utc).AddTicks(3376));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 369, DateTimeKind.Utc).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 369, DateTimeKind.Utc).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 369, DateTimeKind.Utc).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 369, DateTimeKind.Utc).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 369, DateTimeKind.Utc).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 369, DateTimeKind.Utc).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 369, DateTimeKind.Utc).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 369, DateTimeKind.Utc).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 369, DateTimeKind.Utc).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 369, DateTimeKind.Utc).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 369, DateTimeKind.Utc).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 369, DateTimeKind.Utc).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 369, DateTimeKind.Utc).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 369, DateTimeKind.Utc).AddTicks(3399));

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Code", "Created_At", "Created_By", "Deleted_At", "Deleted_By", "Description", "Name" },
                values: new object[,]
                {
                    { 22, "rollback_permission", new DateTime(2024, 11, 4, 7, 25, 29, 369, DateTimeKind.Utc).AddTicks(3400), 1, null, null, null, "rollback_permission" },
                    { 23, "rollback_role", new DateTime(2024, 11, 4, 7, 25, 29, 369, DateTimeKind.Utc).AddTicks(3402), 1, null, null, null, "rollback_role" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 638, DateTimeKind.Utc).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 638, DateTimeKind.Utc).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 638, DateTimeKind.Utc).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 1, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 639, DateTimeKind.Utc).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 2, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 639, DateTimeKind.Utc).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 3, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 639, DateTimeKind.Utc).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 4, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 639, DateTimeKind.Utc).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 5, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 639, DateTimeKind.Utc).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 6, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 639, DateTimeKind.Utc).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 7, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 639, DateTimeKind.Utc).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 8, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 639, DateTimeKind.Utc).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 9, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 639, DateTimeKind.Utc).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 10, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 639, DateTimeKind.Utc).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 11, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 639, DateTimeKind.Utc).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 12, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 639, DateTimeKind.Utc).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 13, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 639, DateTimeKind.Utc).AddTicks(4686));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 14, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 639, DateTimeKind.Utc).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 15, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 639, DateTimeKind.Utc).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 16, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 639, DateTimeKind.Utc).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 17, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 639, DateTimeKind.Utc).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 18, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 639, DateTimeKind.Utc).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 19, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 639, DateTimeKind.Utc).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 20, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 639, DateTimeKind.Utc).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 21, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 639, DateTimeKind.Utc).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 1, 2 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 639, DateTimeKind.Utc).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 4, 2 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 639, DateTimeKind.Utc).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 10, 2 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 639, DateTimeKind.Utc).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 1, 3 },
                column: "Created_At",
                value: new DateTime(2024, 11, 4, 7, 25, 29, 639, DateTimeKind.Utc).AddTicks(4709));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23);

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
    }
}
