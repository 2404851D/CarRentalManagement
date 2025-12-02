using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "bea77bd9-0b49-4e62-91ae-7a854fd51728", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEE+o3INpjp8JbW3q7Rq0j296kalW5q/Q8GKDum8XHrzRWMg7+1OdxVbYdKDv0rxFWw==", null, false, "1bf44935-cea7-4b38-bb97-dc32a755925d", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 29, 21, 5, 28, 584, DateTimeKind.Local).AddTicks(399), new DateTime(2025, 11, 29, 21, 5, 28, 584, DateTimeKind.Local).AddTicks(411) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 29, 21, 5, 28, 584, DateTimeKind.Local).AddTicks(413), new DateTime(2025, 11, 29, 21, 5, 28, 584, DateTimeKind.Local).AddTicks(414) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 29, 21, 5, 28, 584, DateTimeKind.Local).AddTicks(563), new DateTime(2025, 11, 29, 21, 5, 28, 584, DateTimeKind.Local).AddTicks(563) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 29, 21, 5, 28, 584, DateTimeKind.Local).AddTicks(565), new DateTime(2025, 11, 29, 21, 5, 28, 584, DateTimeKind.Local).AddTicks(565) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 29, 21, 5, 28, 584, DateTimeKind.Local).AddTicks(636), new DateTime(2025, 11, 29, 21, 5, 28, 584, DateTimeKind.Local).AddTicks(636) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 29, 21, 5, 28, 584, DateTimeKind.Local).AddTicks(638), new DateTime(2025, 11, 29, 21, 5, 28, 584, DateTimeKind.Local).AddTicks(638) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 29, 21, 5, 28, 584, DateTimeKind.Local).AddTicks(640), new DateTime(2025, 11, 29, 21, 5, 28, 584, DateTimeKind.Local).AddTicks(640) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 29, 21, 5, 28, 584, DateTimeKind.Local).AddTicks(641), new DateTime(2025, 11, 29, 21, 5, 28, 584, DateTimeKind.Local).AddTicks(642) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 29, 20, 38, 19, 87, DateTimeKind.Local).AddTicks(1679), new DateTime(2025, 11, 29, 20, 38, 19, 87, DateTimeKind.Local).AddTicks(1699) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 29, 20, 38, 19, 87, DateTimeKind.Local).AddTicks(1701), new DateTime(2025, 11, 29, 20, 38, 19, 87, DateTimeKind.Local).AddTicks(1702) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 29, 20, 38, 19, 87, DateTimeKind.Local).AddTicks(1845), new DateTime(2025, 11, 29, 20, 38, 19, 87, DateTimeKind.Local).AddTicks(1845) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 29, 20, 38, 19, 87, DateTimeKind.Local).AddTicks(1846), new DateTime(2025, 11, 29, 20, 38, 19, 87, DateTimeKind.Local).AddTicks(1847) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 29, 20, 38, 19, 87, DateTimeKind.Local).AddTicks(1933), new DateTime(2025, 11, 29, 20, 38, 19, 87, DateTimeKind.Local).AddTicks(1934) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 29, 20, 38, 19, 87, DateTimeKind.Local).AddTicks(1935), new DateTime(2025, 11, 29, 20, 38, 19, 87, DateTimeKind.Local).AddTicks(1936) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 29, 20, 38, 19, 87, DateTimeKind.Local).AddTicks(1936), new DateTime(2025, 11, 29, 20, 38, 19, 87, DateTimeKind.Local).AddTicks(1937) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 29, 20, 38, 19, 87, DateTimeKind.Local).AddTicks(1938), new DateTime(2025, 11, 29, 20, 38, 19, 87, DateTimeKind.Local).AddTicks(1938) });
        }
    }
}
