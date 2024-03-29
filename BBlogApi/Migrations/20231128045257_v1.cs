﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BBlogApi.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InforUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategorieZ",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorieZ", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostZ",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BriefContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PicturePostUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TagSearch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublicId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostZ", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_PostZ_CategorieZ_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "CategorieZ",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "50127be5-31fc-4a09-af5d-90a62d697177", "Admin", "ADMIN" },
                    { 2, "aba25304-3ff6-424a-883d-caf7f0d45f6d", "Member", "MEMBER" }
                });

            migrationBuilder.InsertData(
                table: "CategorieZ",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Thủ Thuật IT" },
                    { 2, "Phần Mềm" },
                    { 3, "Tin Công Nghệ" },
                    { 4, "Tâm Sự Cuộc Sống" },
                    { 5, "Mở Mang" }
                });

            migrationBuilder.InsertData(
                table: "PostZ",
                columns: new[] { "PostId", "BriefContent", "CategoryId", "Content", "CreateDate", "PicturePostUrl", "PostStatus", "PublicId", "TagSearch", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { 1, "CPU Intel thế hệ thứ 14 “Raptor Lake Refresh” dự kiến sẽ được ra mắt vào tháng 10/2023, và chúng ta vừa mới có được những con số benchmark bị rò rỉ của Core i9-14900K và Core i7-14700K.", 2, "Core i9-14900K có 24 nhân 32 luồng (8 P-core và 16 E-core). Con chip này sẽ thay thế cho con chip đầu bảng Core i9-13900K hiện tại. Còn Core i7-14700K thì sẽ kế nhiệm Core i7-13700K, và nó được nâng cấp số nhân lên thành 8 P-core và 12 E-core.", new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6102), "/images/products/i9_banner.jpg", "Mới tạo", null, "i9", "Lộ benchmark Core i9-14900K mạnh hơn Core i7-14700K tới 14%", "1", 0 },
                    { 2, "Phiên bản hệ điều hành iOS 17 vừa mới được Apple chính thức phát hành vào sáng nay.", 2, "Rạng sáng ngày 19/9, Apple phát hành phiên bản cập nhật chính thức của iOS 17 tới người dùng iPhone. iOS 17 mang đến các tính năng mới giúp giao tiếp thêm biểu cảm, chia sẻ trở nên đơn giản, cùng một trải nghiệm toàn màn hình mới cho iPhone.\r\n\r\nCụ thể, phiên bản cập nhật iOS 17 có dung lượng khoảng hơn 3GB (tuỳ model), mang số hiệu 21A329, được phát hành cho các thiết bị iPhone từ thế hệ iPhone XS và XR trở đi.", new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6106), "/images/products/ios17_3.webp", "Mới tạo", null, "ios17", "Apple phát hành iOS 17 chính thức, hỗ trợ iPhone XS trở đi", "1", 0 },
                    { 3, "Với sự tham gia của các chuyên gia hàng đầu, lãnh đạo doanh nghiệp và những người có tầm ảnh hưởng, giải thưởng này cam kết tôn vinh những đổi mới sáng tạo thực sự mang lại giá trị cho người tiêu dùng.", 2, "Rạng sáng ngày 19/9, Apple phát hành phiên bản cập nhật chính thức của iOS 17 tới người dùng iPhone. iOS 17 mang đến các tính năng mới giúp giao tiếp thêm biểu cảm, chia sẻ trở nên đơn giản, cùng một trải nghiệm toàn màn hình mới cho iPhone.\r\n\r\nCụ thể, phiên bản cập nhật iOS 17 có dung lượng khoảng hơn 3GB (tuỳ model), mang số hiệu 21A329, được phát hành cho các thiết bị iPhone từ thế hệ iPhone XS và XR trở đi.", new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6107), "/images/products/pewpew_3.webp", "Mới tạo", null, "pewpew", "Danh sách hội đồng thẩm định Better Choice Awards 2023: Sự kết hợp hoàn hảo của kiến thức, uy tín và tầm ảnh hưởng", "1", 0 },
                    { 4, "Bằng cách sử dụng hai chiếc iPhone, người dùng có thể phần nào được trải nghiệm những lợi ích mà họ sẽ có được khi nâng cấp lên Galaxy Z Fold.", 2, "So với những chiếc smartphone truyền thống với thiết kế phẳng, những chiếc điện thoại màn hình gập mang đến nhiều lợi thế. Với thiết kế gập ngang như Galaxy Z Fold, người dùng sẽ có được một chiếc tablet nằm gọn trong túi quần, khiến cho mọi trải nghiệm giải trí, học tập và làm việc trở nên hiệu quả hơn.", new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6108), "/images/products/z-fold_3.webp", "Mới tạo", null, "zfold", "Chiêu thức sáng tạo của Samsung nhằm lôi kéo người dùng iPhone lên đời điện thoại màn hình gập", "1", 0 },
                    { 5, "\r\nHải Triều, một trong những gương mặt đình đám chuyên “phá hoại” trong làng công nghệ, cho biết anh muốn droptest các sản phẩm tại BCA, vừa là để kiểm chứng độ bền, lại vừa được… thỏa mãn đam mê.", 2, "Nếu bạn là một người yêu công nghệ, hay xem các video clip đánh giá sản phẩm công nghệ nổi bật tại Việt Nam thì chắc chắn sẽ cảm thấy quen thuộc với cái tên Hải Triều tới từ kênh AnhEm TV. Hải Triều là một trong những gương mặt đình đám trong làng công nghệ, bên cạnh các video đánh giá sản phẩm công tâm thì anh còn nổi tiếng với độ “phá hoại” bởi Hải Triều luôn muốn thử độ bền các sản phẩm công nghệ, tạo nên sự khác biệt và chất riêng cho bản thân.", new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6110), "/images/products/haitrieu_3.webp", "Mới tạo", null, "haitrieu", "\"Thánh phá hoại\" làng công nghệ: Sáng tạo nhưng phải bền, tôi sẽ drop-test tất cả các sản phẩm tại Better Choice Awards", "1", 0 },
                    { 6, "CPU Intel thế hệ thứ 14 “Raptor Lake Refresh” dự kiến sẽ được ra mắt vào tháng 10/2023, và chúng ta vừa mới có được những con số benchmark bị rò rỉ của Core i9-14900K và Core i7-14700K.", 3, "Core i9-14900K có 24 nhân 32 luồng (8 P-core và 16 E-core). Con chip này sẽ thay thế cho con chip đầu bảng Core i9-13900K hiện tại. Còn Core i7-14700K thì sẽ kế nhiệm Core i7-13700K, và nó được nâng cấp số nhân lên thành 8 P-core và 12 E-core.", new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6111), "/images/products/i9_banner.jpg", "Mới tạo", null, "i9", "Lộ benchmark Core i9-14900K mạnh hơn Core i7-14700K tới 14%", "1", 0 },
                    { 7, "Phiên bản hệ điều hành iOS 17 vừa mới được Apple chính thức phát hành vào sáng nay.", 3, "Rạng sáng ngày 19/9, Apple phát hành phiên bản cập nhật chính thức của iOS 17 tới người dùng iPhone. iOS 17 mang đến các tính năng mới giúp giao tiếp thêm biểu cảm, chia sẻ trở nên đơn giản, cùng một trải nghiệm toàn màn hình mới cho iPhone.\r\n\r\nCụ thể, phiên bản cập nhật iOS 17 có dung lượng khoảng hơn 3GB (tuỳ model), mang số hiệu 21A329, được phát hành cho các thiết bị iPhone từ thế hệ iPhone XS và XR trở đi.", new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6112), "/images/products/ios17_3.webp", "Mới tạo", null, "ios17", "Apple phát hành iOS 17 chính thức, hỗ trợ iPhone XS trở đi", "1", 0 },
                    { 8, "Với sự tham gia của các chuyên gia hàng đầu, lãnh đạo doanh nghiệp và những người có tầm ảnh hưởng, giải thưởng này cam kết tôn vinh những đổi mới sáng tạo thực sự mang lại giá trị cho người tiêu dùng.", 2, "Rạng sáng ngày 19/9, Apple phát hành phiên bản cập nhật chính thức của iOS 17 tới người dùng iPhone. iOS 17 mang đến các tính năng mới giúp giao tiếp thêm biểu cảm, chia sẻ trở nên đơn giản, cùng một trải nghiệm toàn màn hình mới cho iPhone.\r\n\r\nCụ thể, phiên bản cập nhật iOS 17 có dung lượng khoảng hơn 3GB (tuỳ model), mang số hiệu 21A329, được phát hành cho các thiết bị iPhone từ thế hệ iPhone XS và XR trở đi.", new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6113), "/images/products/pewpew_3.webp", "Mới tạo", null, "pewpew", "Danh sách hội đồng thẩm định Better Choice Awards 2023: Sự kết hợp hoàn hảo của kiến thức, uy tín và tầm ảnh hưởng", "1", 0 },
                    { 9, "Bằng cách sử dụng hai chiếc iPhone, người dùng có thể phần nào được trải nghiệm những lợi ích mà họ sẽ có được khi nâng cấp lên Galaxy Z Fold.", 2, "So với những chiếc smartphone truyền thống với thiết kế phẳng, những chiếc điện thoại màn hình gập mang đến nhiều lợi thế. Với thiết kế gập ngang như Galaxy Z Fold, người dùng sẽ có được một chiếc tablet nằm gọn trong túi quần, khiến cho mọi trải nghiệm giải trí, học tập và làm việc trở nên hiệu quả hơn.", new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6114), "/images/products/z-fold_3.webp", "Mới tạo", null, "zfold", "Chiêu thức sáng tạo của Samsung nhằm lôi kéo người dùng iPhone lên đời điện thoại màn hình gập", "1", 0 },
                    { 10, "\r\nHải Triều, một trong những gương mặt đình đám chuyên “phá hoại” trong làng công nghệ, cho biết anh muốn droptest các sản phẩm tại BCA, vừa là để kiểm chứng độ bền, lại vừa được… thỏa mãn đam mê.", 2, "Nếu bạn là một người yêu công nghệ, hay xem các video clip đánh giá sản phẩm công nghệ nổi bật tại Việt Nam thì chắc chắn sẽ cảm thấy quen thuộc với cái tên Hải Triều tới từ kênh AnhEm TV. Hải Triều là một trong những gương mặt đình đám trong làng công nghệ, bên cạnh các video đánh giá sản phẩm công tâm thì anh còn nổi tiếng với độ “phá hoại” bởi Hải Triều luôn muốn thử độ bền các sản phẩm công nghệ, tạo nên sự khác biệt và chất riêng cho bản thân.", new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6116), "/images/products/haitrieu_3.webp", "Mới tạo", null, "haitrieu", "\"Thánh phá hoại\" làng công nghệ: Sáng tạo nhưng phải bền, tôi sẽ drop-test tất cả các sản phẩm tại Better Choice Awards", "1", 0 },
                    { 11, "CPU Intel thế hệ thứ 14 “Raptor Lake Refresh” dự kiến sẽ được ra mắt vào tháng 10/2023, và chúng ta vừa mới có được những con số benchmark bị rò rỉ của Core i9-14900K và Core i7-14700K.", 2, "Core i9-14900K có 24 nhân 32 luồng (8 P-core và 16 E-core). Con chip này sẽ thay thế cho con chip đầu bảng Core i9-13900K hiện tại. Còn Core i7-14700K thì sẽ kế nhiệm Core i7-13700K, và nó được nâng cấp số nhân lên thành 8 P-core và 12 E-core.", new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6153), "/images/products/i9_banner.jpg", "Mới tạo", null, "i9", "Lộ benchmark Core i9-14900K mạnh hơn Core i7-14700K tới 14%", "1", 0 },
                    { 12, "Phiên bản hệ điều hành iOS 17 vừa mới được Apple chính thức phát hành vào sáng nay.", 2, "Rạng sáng ngày 19/9, Apple phát hành phiên bản cập nhật chính thức của iOS 17 tới người dùng iPhone. iOS 17 mang đến các tính năng mới giúp giao tiếp thêm biểu cảm, chia sẻ trở nên đơn giản, cùng một trải nghiệm toàn màn hình mới cho iPhone.\r\n\r\nCụ thể, phiên bản cập nhật iOS 17 có dung lượng khoảng hơn 3GB (tuỳ model), mang số hiệu 21A329, được phát hành cho các thiết bị iPhone từ thế hệ iPhone XS và XR trở đi.", new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6155), "/images/products/ios17_3.webp", "Mới tạo", null, "ios17", "Apple phát hành iOS 17 chính thức, hỗ trợ iPhone XS trở đi", "1", 0 },
                    { 13, "Với sự tham gia của các chuyên gia hàng đầu, lãnh đạo doanh nghiệp và những người có tầm ảnh hưởng, giải thưởng này cam kết tôn vinh những đổi mới sáng tạo thực sự mang lại giá trị cho người tiêu dùng.", 1, "Rạng sáng ngày 19/9, Apple phát hành phiên bản cập nhật chính thức của iOS 17 tới người dùng iPhone. iOS 17 mang đến các tính năng mới giúp giao tiếp thêm biểu cảm, chia sẻ trở nên đơn giản, cùng một trải nghiệm toàn màn hình mới cho iPhone.\r\n\r\nCụ thể, phiên bản cập nhật iOS 17 có dung lượng khoảng hơn 3GB (tuỳ model), mang số hiệu 21A329, được phát hành cho các thiết bị iPhone từ thế hệ iPhone XS và XR trở đi.", new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6156), "/images/products/pewpew_3.webp", "Mới tạo", null, "pewpew", "Danh sách hội đồng thẩm định Better Choice Awards 2023: Sự kết hợp hoàn hảo của kiến thức, uy tín và tầm ảnh hưởng", "1", 0 },
                    { 14, "Bằng cách sử dụng hai chiếc iPhone, người dùng có thể phần nào được trải nghiệm những lợi ích mà họ sẽ có được khi nâng cấp lên Galaxy Z Fold.", 1, "So với những chiếc smartphone truyền thống với thiết kế phẳng, những chiếc điện thoại màn hình gập mang đến nhiều lợi thế. Với thiết kế gập ngang như Galaxy Z Fold, người dùng sẽ có được một chiếc tablet nằm gọn trong túi quần, khiến cho mọi trải nghiệm giải trí, học tập và làm việc trở nên hiệu quả hơn.", new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6157), "/images/products/z-fold_3.webp", "Mới tạo", null, "zfold", "Chiêu thức sáng tạo của Samsung nhằm lôi kéo người dùng iPhone lên đời điện thoại màn hình gập", "1", 0 },
                    { 15, "\r\nHải Triều, một trong những gương mặt đình đám chuyên “phá hoại” trong làng công nghệ, cho biết anh muốn droptest các sản phẩm tại BCA, vừa là để kiểm chứng độ bền, lại vừa được… thỏa mãn đam mê.", 1, "Nếu bạn là một người yêu công nghệ, hay xem các video clip đánh giá sản phẩm công nghệ nổi bật tại Việt Nam thì chắc chắn sẽ cảm thấy quen thuộc với cái tên Hải Triều tới từ kênh AnhEm TV. Hải Triều là một trong những gương mặt đình đám trong làng công nghệ, bên cạnh các video đánh giá sản phẩm công tâm thì anh còn nổi tiếng với độ “phá hoại” bởi Hải Triều luôn muốn thử độ bền các sản phẩm công nghệ, tạo nên sự khác biệt và chất riêng cho bản thân.", new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6159), "/images/products/haitrieu_3.webp", "Mới tạo", null, "haitrieu", "\"Thánh phá hoại\" làng công nghệ: Sáng tạo nhưng phải bền, tôi sẽ drop-test tất cả các sản phẩm tại Better Choice Awards", "1", 0 },
                    { 16, "CPU Intel thế hệ thứ 14 “Raptor Lake Refresh” dự kiến sẽ được ra mắt vào tháng 10/2023, và chúng ta vừa mới có được những con số benchmark bị rò rỉ của Core i9-14900K và Core i7-14700K.", 1, "Core i9-14900K có 24 nhân 32 luồng (8 P-core và 16 E-core). Con chip này sẽ thay thế cho con chip đầu bảng Core i9-13900K hiện tại. Còn Core i7-14700K thì sẽ kế nhiệm Core i7-13700K, và nó được nâng cấp số nhân lên thành 8 P-core và 12 E-core.", new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6160), "/images/products/i9_banner.jpg", "Mới tạo", null, "i9", "Lộ benchmark Core i9-14900K mạnh hơn Core i7-14700K tới 14%", "1", 0 },
                    { 17, "Phiên bản hệ điều hành iOS 17 vừa mới được Apple chính thức phát hành vào sáng nay.", 5, "Rạng sáng ngày 19/9, Apple phát hành phiên bản cập nhật chính thức của iOS 17 tới người dùng iPhone. iOS 17 mang đến các tính năng mới giúp giao tiếp thêm biểu cảm, chia sẻ trở nên đơn giản, cùng một trải nghiệm toàn màn hình mới cho iPhone.\r\n\r\nCụ thể, phiên bản cập nhật iOS 17 có dung lượng khoảng hơn 3GB (tuỳ model), mang số hiệu 21A329, được phát hành cho các thiết bị iPhone từ thế hệ iPhone XS và XR trở đi.", new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6161), "/images/products/ios17_3.webp", "Mới tạo", null, "ios17", "Apple phát hành iOS 17 chính thức, hỗ trợ iPhone XS trở đi", "1", 0 },
                    { 18, "Với sự tham gia của các chuyên gia hàng đầu, lãnh đạo doanh nghiệp và những người có tầm ảnh hưởng, giải thưởng này cam kết tôn vinh những đổi mới sáng tạo thực sự mang lại giá trị cho người tiêu dùng.", 4, "Rạng sáng ngày 19/9, Apple phát hành phiên bản cập nhật chính thức của iOS 17 tới người dùng iPhone. iOS 17 mang đến các tính năng mới giúp giao tiếp thêm biểu cảm, chia sẻ trở nên đơn giản, cùng một trải nghiệm toàn màn hình mới cho iPhone.\r\n\r\nCụ thể, phiên bản cập nhật iOS 17 có dung lượng khoảng hơn 3GB (tuỳ model), mang số hiệu 21A329, được phát hành cho các thiết bị iPhone từ thế hệ iPhone XS và XR trở đi.", new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6162), "/images/products/pewpew_3.webp", "Mới tạo", null, "pewpew", "Danh sách hội đồng thẩm định Better Choice Awards 2023: Sự kết hợp hoàn hảo của kiến thức, uy tín và tầm ảnh hưởng", "1", 0 },
                    { 19, "Bằng cách sử dụng hai chiếc iPhone, người dùng có thể phần nào được trải nghiệm những lợi ích mà họ sẽ có được khi nâng cấp lên Galaxy Z Fold.", 4, "So với những chiếc smartphone truyền thống với thiết kế phẳng, những chiếc điện thoại màn hình gập mang đến nhiều lợi thế. Với thiết kế gập ngang như Galaxy Z Fold, người dùng sẽ có được một chiếc tablet nằm gọn trong túi quần, khiến cho mọi trải nghiệm giải trí, học tập và làm việc trở nên hiệu quả hơn.", new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6163), "/images/products/z-fold_3.webp", "Mới tạo", null, "zfold", "Chiêu thức sáng tạo của Samsung nhằm lôi kéo người dùng iPhone lên đời điện thoại màn hình gập", "1", 0 },
                    { 20, "\r\nHải Triều, một trong những gương mặt đình đám chuyên “phá hoại” trong làng công nghệ, cho biết anh muốn droptest các sản phẩm tại BCA, vừa là để kiểm chứng độ bền, lại vừa được… thỏa mãn đam mê.", 4, "Nếu bạn là một người yêu công nghệ, hay xem các video clip đánh giá sản phẩm công nghệ nổi bật tại Việt Nam thì chắc chắn sẽ cảm thấy quen thuộc với cái tên Hải Triều tới từ kênh AnhEm TV. Hải Triều là một trong những gương mặt đình đám trong làng công nghệ, bên cạnh các video đánh giá sản phẩm công tâm thì anh còn nổi tiếng với độ “phá hoại” bởi Hải Triều luôn muốn thử độ bền các sản phẩm công nghệ, tạo nên sự khác biệt và chất riêng cho bản thân.", new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6164), "/images/products/haitrieu_3.webp", "Mới tạo", null, "haitrieu", "\"Thánh phá hoại\" làng công nghệ: Sáng tạo nhưng phải bền, tôi sẽ drop-test tất cả các sản phẩm tại Better Choice Awards", "1", 0 },
                    { 21, "\r\nHải Triều, một trong những gương mặt đình đám chuyên “phá hoại” trong làng công nghệ, cho biết anh muốn droptest các sản phẩm tại BCA, vừa là để kiểm chứng độ bền, lại vừa được… thỏa mãn đam mê.", 4, "Nếu bạn là một người yêu công nghệ, hay xem các video clip đánh giá sản phẩm công nghệ nổi bật tại Việt Nam thì chắc chắn sẽ cảm thấy quen thuộc với cái tên Hải Triều tới từ kênh AnhEm TV. Hải Triều là một trong những gương mặt đình đám trong làng công nghệ, bên cạnh các video đánh giá sản phẩm công tâm thì anh còn nổi tiếng với độ “phá hoại” bởi Hải Triều luôn muốn thử độ bền các sản phẩm công nghệ, tạo nên sự khác biệt và chất riêng cho bản thân.", new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6165), "/images/products/haitrieu_3.webp", "Mới tạo", null, "haitrieu", "\"Thánh phá hoại\" làng công nghệ: Sáng tạo nhưng phải bền, tôi sẽ drop-test tất cả các sản phẩm tại Better Choice Awards", "1", 0 },
                    { 22, "\r\nHải Triều, một trong những gương mặt đình đám chuyên “phá hoại” trong làng công nghệ, cho biết anh muốn droptest các sản phẩm tại BCA, vừa là để kiểm chứng độ bền, lại vừa được… thỏa mãn đam mê.", 4, "Nếu bạn là một người yêu công nghệ, hay xem các video clip đánh giá sản phẩm công nghệ nổi bật tại Việt Nam thì chắc chắn sẽ cảm thấy quen thuộc với cái tên Hải Triều tới từ kênh AnhEm TV. Hải Triều là một trong những gương mặt đình đám trong làng công nghệ, bên cạnh các video đánh giá sản phẩm công tâm thì anh còn nổi tiếng với độ “phá hoại” bởi Hải Triều luôn muốn thử độ bền các sản phẩm công nghệ, tạo nên sự khác biệt và chất riêng cho bản thân.", new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6167), "/images/products/haitrieu_3.webp", "Mới tạo", null, "haitrieu", "\"Thánh phá hoại\" làng công nghệ: Sáng tạo nhưng phải bền, tôi sẽ drop-test tất cả các sản phẩm tại Better Choice Awards", "1", 0 },
                    { 23, "\r\nHải Triều, một trong những gương mặt đình đám chuyên “phá hoại” trong làng công nghệ, cho biết anh muốn droptest các sản phẩm tại BCA, vừa là để kiểm chứng độ bền, lại vừa được… thỏa mãn đam mê.", 4, "Nếu bạn là một người yêu công nghệ, hay xem các video clip đánh giá sản phẩm công nghệ nổi bật tại Việt Nam thì chắc chắn sẽ cảm thấy quen thuộc với cái tên Hải Triều tới từ kênh AnhEm TV. Hải Triều là một trong những gương mặt đình đám trong làng công nghệ, bên cạnh các video đánh giá sản phẩm công tâm thì anh còn nổi tiếng với độ “phá hoại” bởi Hải Triều luôn muốn thử độ bền các sản phẩm công nghệ, tạo nên sự khác biệt và chất riêng cho bản thân.", new DateTime(2023, 11, 28, 11, 52, 57, 483, DateTimeKind.Local).AddTicks(6168), "/images/products/haitrieu_3.webp", "Mới tạo", null, "haitrieu", "\"Thánh phá hoại\" làng công nghệ: Sáng tạo nhưng phải bền, tôi sẽ drop-test tất cả các sản phẩm tại Better Choice Awards", "1", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PostZ_CategoryId",
                table: "PostZ",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "PostZ");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CategorieZ");
        }
    }
}
