using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gillian2204799G.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbc43947-b94e-456f-a745-97b0f2e9e813", "AQAAAAIAAYagAAAAEFH6nU1DgPIsGhUDqziAnw4ZhD0SgIGQGvZ+d+E7HFMRxCxnEYCMPzgGyEtHeqahHQ==", "a6bb62ee-8186-420d-af19-c19485ba20c4" });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 3, 4, 43, 18, DateTimeKind.Local).AddTicks(4866), new DateTime(2024, 2, 14, 3, 4, 43, 18, DateTimeKind.Local).AddTicks(4875) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 3, 4, 43, 18, DateTimeKind.Local).AddTicks(4877), new DateTime(2024, 2, 14, 3, 4, 43, 18, DateTimeKind.Local).AddTicks(4877) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 3, 4, 43, 18, DateTimeKind.Local).AddTicks(5125), new DateTime(2024, 2, 14, 3, 4, 43, 18, DateTimeKind.Local).AddTicks(5125) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 3, 4, 43, 18, DateTimeKind.Local).AddTicks(5127), new DateTime(2024, 2, 14, 3, 4, 43, 18, DateTimeKind.Local).AddTicks(5127) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d707e999-3a93-46c1-abbf-f09e0fa39414", "AQAAAAIAAYagAAAAED6hS5x+WMLfcPhrzY+pNiET/5+GW/soxiaFVrc3etWK0Z/M+tp2x6FGDDqtlvk7Tg==", "70d16a6b-328f-4839-8d4d-4a0c6c178be8" });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 3, 4, 14, 189, DateTimeKind.Local).AddTicks(1258), new DateTime(2024, 2, 14, 3, 4, 14, 189, DateTimeKind.Local).AddTicks(1269) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 3, 4, 14, 189, DateTimeKind.Local).AddTicks(1272), new DateTime(2024, 2, 14, 3, 4, 14, 189, DateTimeKind.Local).AddTicks(1273) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 3, 4, 14, 189, DateTimeKind.Local).AddTicks(1594), new DateTime(2024, 2, 14, 3, 4, 14, 189, DateTimeKind.Local).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 3, 4, 14, 189, DateTimeKind.Local).AddTicks(1596), new DateTime(2024, 2, 14, 3, 4, 14, 189, DateTimeKind.Local).AddTicks(1596) });
        }
    }
}
