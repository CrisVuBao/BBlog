using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BBlogApi.Migrations
{
    public partial class UpdateUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "PostZ",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9972), null });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 2,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9981), null });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 3,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9983), null });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 4,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9984), null });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 5,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9985), null });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 6,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9986), null });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 7,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9987), null });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 8,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9988), null });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 9,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9989), null });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 10,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9990), null });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 11,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9991), null });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 12,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9992), null });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 13,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9993), null });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 14,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9994), null });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 15,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9995), null });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 16,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9996), null });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 17,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9997), null });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 18,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9998), null });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 19,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 10, 14, 7, 28, 948, DateTimeKind.Local).AddTicks(9999), null });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 20,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 10, 14, 7, 28, 949, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 21,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 10, 14, 7, 28, 949, DateTimeKind.Local).AddTicks(1), null });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 22,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 10, 14, 7, 28, 949, DateTimeKind.Local).AddTicks(2), null });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 23,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 10, 14, 7, 28, 949, DateTimeKind.Local).AddTicks(3), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "PostZ",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "d602c827-bc23-4c9f-bc4e-f8aad9392154");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "76117046-3870-4ac7-89f1-a13800353ea0");

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 9, 20, 5, 10, 748, DateTimeKind.Local).AddTicks(6522), 0 });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 2,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 9, 20, 5, 10, 748, DateTimeKind.Local).AddTicks(6533), 0 });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 3,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 9, 20, 5, 10, 748, DateTimeKind.Local).AddTicks(6534), 0 });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 4,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 9, 20, 5, 10, 748, DateTimeKind.Local).AddTicks(6535), 0 });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 5,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 9, 20, 5, 10, 748, DateTimeKind.Local).AddTicks(6536), 0 });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 6,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 9, 20, 5, 10, 748, DateTimeKind.Local).AddTicks(6537), 0 });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 7,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 9, 20, 5, 10, 748, DateTimeKind.Local).AddTicks(6538), 0 });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 8,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 9, 20, 5, 10, 748, DateTimeKind.Local).AddTicks(6539), 0 });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 9,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 9, 20, 5, 10, 748, DateTimeKind.Local).AddTicks(6540), 0 });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 10,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 9, 20, 5, 10, 748, DateTimeKind.Local).AddTicks(6541), 0 });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 11,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 9, 20, 5, 10, 748, DateTimeKind.Local).AddTicks(6542), 0 });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 12,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 9, 20, 5, 10, 748, DateTimeKind.Local).AddTicks(6543), 0 });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 13,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 9, 20, 5, 10, 748, DateTimeKind.Local).AddTicks(6544), 0 });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 14,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 9, 20, 5, 10, 748, DateTimeKind.Local).AddTicks(6545), 0 });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 15,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 9, 20, 5, 10, 748, DateTimeKind.Local).AddTicks(6546), 0 });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 16,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 9, 20, 5, 10, 748, DateTimeKind.Local).AddTicks(6547), 0 });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 17,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 9, 20, 5, 10, 748, DateTimeKind.Local).AddTicks(6548), 0 });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 18,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 9, 20, 5, 10, 748, DateTimeKind.Local).AddTicks(6549), 0 });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 19,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 9, 20, 5, 10, 748, DateTimeKind.Local).AddTicks(6550), 0 });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 20,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 9, 20, 5, 10, 748, DateTimeKind.Local).AddTicks(6551), 0 });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 21,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 9, 20, 5, 10, 748, DateTimeKind.Local).AddTicks(6552), 0 });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 22,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 9, 20, 5, 10, 748, DateTimeKind.Local).AddTicks(6553), 0 });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 23,
                columns: new[] { "CreateDate", "UserId" },
                values: new object[] { new DateTime(2023, 10, 9, 20, 5, 10, 748, DateTimeKind.Local).AddTicks(6554), 0 });
        }
    }
}
