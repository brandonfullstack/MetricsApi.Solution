using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MetricsApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Value",
                table: "Metrics",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Interactions",
                columns: new[] { "InteractionId", "InteractionName" },
                values: new object[,]
                {
                    { 1, "Calls Made" },
                    { 2, "Calls Received" },
                    { 3, "Emails Received" },
                    { 4, "Emails Sent" },
                    { 5, "Meetings" }
                });

            migrationBuilder.InsertData(
                table: "Metrics",
                columns: new[] { "MetricId", "Date", "InteractionId", "PortalId", "UserId", "Value" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 6, 3, 15, 1, 0, DateTimeKind.Unspecified), 1, 1, 1, 2 },
                    { 2, new DateTime(2024, 3, 6, 4, 15, 0, 0, DateTimeKind.Unspecified), 2, 2, 2, 7 },
                    { 3, new DateTime(2024, 3, 6, 20, 15, 0, 0, DateTimeKind.Unspecified), 3, 3, 3, 9 },
                    { 4, new DateTime(2024, 3, 6, 6, 15, 0, 0, DateTimeKind.Unspecified), 4, 4, 4, 23 },
                    { 5, new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 5, 5, 15 }
                });

            migrationBuilder.InsertData(
                table: "Portals",
                columns: new[] { "PortalId", "PortalName" },
                values: new object[,]
                {
                    { 1, "CAREWare" },
                    { 2, "AIMS2.0" },
                    { 3, "CTLS" },
                    { 4, "HIVD2C" },
                    { 5, "STARS" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Brad", "Ross" },
                    { 2, "John", "Smith" },
                    { 3, "Beth", "Baily" },
                    { 4, "Steve", "Nash" },
                    { 5, "Mark", "Brown" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Interactions",
                keyColumn: "InteractionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Interactions",
                keyColumn: "InteractionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Interactions",
                keyColumn: "InteractionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Interactions",
                keyColumn: "InteractionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Interactions",
                keyColumn: "InteractionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Metrics",
                keyColumn: "MetricId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Metrics",
                keyColumn: "MetricId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Metrics",
                keyColumn: "MetricId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Metrics",
                keyColumn: "MetricId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Metrics",
                keyColumn: "MetricId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Portals",
                keyColumn: "PortalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Portals",
                keyColumn: "PortalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Portals",
                keyColumn: "PortalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Portals",
                keyColumn: "PortalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Portals",
                keyColumn: "PortalId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5);

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Metrics",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
