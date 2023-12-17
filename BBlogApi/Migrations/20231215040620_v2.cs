using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BBlogApi.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostStatus",
                table: "PostZ");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "f2646f5a-3c75-4a5c-b1a1-41a1bda8f9c4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "54c7598e-e00c-46e9-9ce0-5e96fb889a57");

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 12, 15, 11, 6, 20, 185, DateTimeKind.Local).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 12, 15, 11, 6, 20, 185, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 12, 15, 11, 6, 20, 185, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 12, 15, 11, 6, 20, 185, DateTimeKind.Local).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 12, 15, 11, 6, 20, 185, DateTimeKind.Local).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 12, 15, 11, 6, 20, 185, DateTimeKind.Local).AddTicks(5357));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 12, 15, 11, 6, 20, 185, DateTimeKind.Local).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 12, 15, 11, 6, 20, 185, DateTimeKind.Local).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 12, 15, 11, 6, 20, 185, DateTimeKind.Local).AddTicks(5361));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2023, 12, 15, 11, 6, 20, 185, DateTimeKind.Local).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2023, 12, 15, 11, 6, 20, 185, DateTimeKind.Local).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2023, 12, 15, 11, 6, 20, 185, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2023, 12, 15, 11, 6, 20, 185, DateTimeKind.Local).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2023, 12, 15, 11, 6, 20, 185, DateTimeKind.Local).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2023, 12, 15, 11, 6, 20, 185, DateTimeKind.Local).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2023, 12, 15, 11, 6, 20, 185, DateTimeKind.Local).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2023, 12, 15, 11, 6, 20, 185, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2023, 12, 15, 11, 6, 20, 185, DateTimeKind.Local).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2023, 12, 15, 11, 6, 20, 185, DateTimeKind.Local).AddTicks(5372));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2023, 12, 15, 11, 6, 20, 185, DateTimeKind.Local).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2023, 12, 15, 11, 6, 20, 185, DateTimeKind.Local).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2023, 12, 15, 11, 6, 20, 185, DateTimeKind.Local).AddTicks(5375));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2023, 12, 15, 11, 6, 20, 185, DateTimeKind.Local).AddTicks(5376));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PostStatus",
                table: "PostZ",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "50127be5-31fc-4a09-af5d-90a62d697177");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "aba25304-3ff6-424a-883d-caf7f0d45f6d");

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "CreateDate", "PostStatus" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6102), "Mới tạo" });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 2,
                columns: new[] { "CreateDate", "PostStatus" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6106), "Mới tạo" });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 3,
                columns: new[] { "CreateDate", "PostStatus" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6107), "Mới tạo" });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 4,
                columns: new[] { "CreateDate", "PostStatus" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6108), "Mới tạo" });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 5,
                columns: new[] { "CreateDate", "PostStatus" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6110), "Mới tạo" });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 6,
                columns: new[] { "CreateDate", "PostStatus" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6111), "Mới tạo" });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 7,
                columns: new[] { "CreateDate", "PostStatus" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6112), "Mới tạo" });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 8,
                columns: new[] { "CreateDate", "PostStatus" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6113), "Mới tạo" });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 9,
                columns: new[] { "CreateDate", "PostStatus" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6114), "Mới tạo" });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 10,
                columns: new[] { "CreateDate", "PostStatus" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6116), "Mới tạo" });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 11,
                columns: new[] { "CreateDate", "PostStatus" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6153), "Mới tạo" });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 12,
                columns: new[] { "CreateDate", "PostStatus" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6155), "Mới tạo" });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 13,
                columns: new[] { "CreateDate", "PostStatus" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6156), "Mới tạo" });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 14,
                columns: new[] { "CreateDate", "PostStatus" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6157), "Mới tạo" });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 15,
                columns: new[] { "CreateDate", "PostStatus" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6159), "Mới tạo" });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 16,
                columns: new[] { "CreateDate", "PostStatus" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6160), "Mới tạo" });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 17,
                columns: new[] { "CreateDate", "PostStatus" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6161), "Mới tạo" });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 18,
                columns: new[] { "CreateDate", "PostStatus" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6162), "Mới tạo" });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 19,
                columns: new[] { "CreateDate", "PostStatus" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6163), "Mới tạo" });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 20,
                columns: new[] { "CreateDate", "PostStatus" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6164), "Mới tạo" });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 21,
                columns: new[] { "CreateDate", "PostStatus" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6165), "Mới tạo" });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 22,
                columns: new[] { "CreateDate", "PostStatus" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6167), "Mới tạo" });

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 23,
                columns: new[] { "CreateDate", "PostStatus" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6168), "Mới tạo" });
        }
    }
}
