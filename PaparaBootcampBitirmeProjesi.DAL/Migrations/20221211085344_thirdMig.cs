using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PaparaBootcampBitirmeProjesi.DAL.Migrations
{
    public partial class thirdMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6534301d-25d7-4f44-9338-8d88f4e147bf");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8da8ad13-b14a-458b-9b29-b07015c3b3d0",
                column: "ConcurrencyStamp",
                value: "ec6a088c-13f4-471e-a08b-d7b3fa718e4c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b0d8eb99-624b-481d-b521-42959f53ce71", "c76326be-78e6-46d0-b864-8d812b6f3c43", "user", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a0d3776-5392-456c-8f81-42a1811d5129",
                columns: new[] { "ConcurrencyStamp", "CreationDate", "SecurityStamp" },
                values: new object[] { "c25fe287-0408-4967-9d9b-06f2466da769", new DateTime(2022, 12, 11, 11, 53, 43, 55, DateTimeKind.Local).AddTicks(1915), "173a2e70-a53d-4a7d-9d97-2ae2c6c7a020" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0d8eb99-624b-481d-b521-42959f53ce71");

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "AspNetUsers",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8da8ad13-b14a-458b-9b29-b07015c3b3d0",
                column: "ConcurrencyStamp",
                value: "2de023ba-246b-4639-be95-1d50531595c3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6534301d-25d7-4f44-9338-8d88f4e147bf", "b050fd2e-4b73-4441-8d55-b6f183167614", "user", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a0d3776-5392-456c-8f81-42a1811d5129",
                columns: new[] { "ConcurrencyStamp", "CreationDate", "SecurityStamp" },
                values: new object[] { "91a6bf49-ab8b-4f21-be25-a1cf89fda449", new DateTime(2022, 12, 11, 11, 49, 24, 190, DateTimeKind.Local).AddTicks(9748), "90e87f50-02e6-4655-89d7-9b3c34b78fd8" });
        }
    }
}
