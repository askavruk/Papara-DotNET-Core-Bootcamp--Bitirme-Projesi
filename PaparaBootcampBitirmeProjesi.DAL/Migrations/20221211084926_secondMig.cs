using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PaparaBootcampBitirmeProjesi.DAL.Migrations
{
    public partial class secondMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e9843a8-623e-40b2-b74f-b9e6fd273ac7");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: "81ad34de-9069-43df-8b1b-e21bcc12b6b6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4e9843a8-623e-40b2-b74f-b9e6fd273ac7", "05259670-052e-4e31-88f9-edd961e3bf3e", "user", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a0d3776-5392-456c-8f81-42a1811d5129",
                columns: new[] { "ConcurrencyStamp", "CreationDate", "SecurityStamp" },
                values: new object[] { "889c6142-52ae-4b84-96a5-5f7e86a8a181", new DateTime(2022, 12, 10, 22, 21, 34, 78, DateTimeKind.Local).AddTicks(6335), "7bb840c8-fc45-4f5e-81b6-04732f9361bb" });
        }
    }
}
