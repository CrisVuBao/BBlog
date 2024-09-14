using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BBlogApi.Migrations
{
    /// <inheritdoc />
    public partial class AddCmt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Commentz",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    BlogUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commentz", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: null);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: null);

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 3, 5, 8, 47, 34, 832, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 3, 5, 8, 47, 34, 832, DateTimeKind.Local).AddTicks(2603));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 3, 5, 8, 47, 34, 832, DateTimeKind.Local).AddTicks(2605));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 3, 5, 8, 47, 34, 832, DateTimeKind.Local).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 3, 5, 8, 47, 34, 832, DateTimeKind.Local).AddTicks(2608));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 3, 5, 8, 47, 34, 832, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 3, 5, 8, 47, 34, 832, DateTimeKind.Local).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 3, 5, 8, 47, 34, 832, DateTimeKind.Local).AddTicks(2613));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 3, 5, 8, 47, 34, 832, DateTimeKind.Local).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 3, 5, 8, 47, 34, 832, DateTimeKind.Local).AddTicks(2617));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 3, 5, 8, 47, 34, 832, DateTimeKind.Local).AddTicks(2618));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 3, 5, 8, 47, 34, 832, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 3, 5, 8, 47, 34, 832, DateTimeKind.Local).AddTicks(2622));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 3, 5, 8, 47, 34, 832, DateTimeKind.Local).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2024, 3, 5, 8, 47, 34, 832, DateTimeKind.Local).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2024, 3, 5, 8, 47, 34, 832, DateTimeKind.Local).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2024, 3, 5, 8, 47, 34, 832, DateTimeKind.Local).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2024, 3, 5, 8, 47, 34, 832, DateTimeKind.Local).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2024, 3, 5, 8, 47, 34, 832, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2024, 3, 5, 8, 47, 34, 832, DateTimeKind.Local).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2024, 3, 5, 8, 47, 34, 832, DateTimeKind.Local).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2024, 3, 5, 8, 47, 34, 832, DateTimeKind.Local).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "PostZ",
                keyColumn: "PostId",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2024, 3, 5, 8, 47, 34, 832, DateTimeKind.Local).AddTicks(2667));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commentz");

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
    }
}
