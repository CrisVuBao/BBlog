using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BBlogApi.Migrations
{
    public partial class AddViewCount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ViewCount",
                table: "PostZ",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "5bce3d31-8684-4e65-91d5-2d1f4b56f87f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "1759a29a-7a24-4cf8-b505-b4be0961bf6e");

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 17, 6, 58, 575, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 17, 6, 58, 575, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 17, 6, 58, 575, DateTimeKind.Local).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 17, 6, 58, 575, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 17, 6, 58, 575, DateTimeKind.Local).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 17, 6, 58, 575, DateTimeKind.Local).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 17, 6, 58, 575, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 17, 6, 58, 575, DateTimeKind.Local).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 17, 6, 58, 575, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 17, 6, 58, 575, DateTimeKind.Local).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 17, 6, 58, 575, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 17, 6, 58, 575, DateTimeKind.Local).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 17, 6, 58, 575, DateTimeKind.Local).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 17, 6, 58, 575, DateTimeKind.Local).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 17, 6, 58, 575, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 17, 6, 58, 575, DateTimeKind.Local).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 17, 6, 58, 575, DateTimeKind.Local).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 17, 6, 58, 575, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 17, 6, 58, 575, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 17, 6, 58, 575, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 17, 6, 58, 575, DateTimeKind.Local).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 17, 6, 58, 575, DateTimeKind.Local).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 17, 6, 58, 575, DateTimeKind.Local).AddTicks(8704));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ViewCount",
                table: "PostZ");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "59d32a82-b431-40af-a6e8-afdc0265588f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "1e469a32-899f-42c8-a1ba-b421b681d3c3");

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9983));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9984));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9986));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9987));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9988));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9991));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9992));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9996));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 14, 7, 28, 949, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 14, 7, 28, 949, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 14, 7, 28, 949, DateTimeKind.Local).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 14, 7, 28, 949, DateTimeKind.Local).AddTicks(3));
        }
    }
}
