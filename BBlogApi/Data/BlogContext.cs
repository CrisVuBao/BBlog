using BBlogApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBlogApi.Data
{
    public class BlogContext : IdentityDbContext<Account, Role, int>
    {
        public BlogContext(DbContextOptions options) : base(options)
        {

        }

        #region Dbset
        public DbSet<Categories> CategorieZ { get; set; }
        public DbSet<Post> PostZ { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            // seed data cho table Product

            modelBuilder.Entity<Categories>().HasData(
                new Categories
                {
                    CategoryId = 1,
                    CategoryName = "Thủ Thuật IT",
                    
                  
                },
                new Categories
                {
                    CategoryId = 2,
                    CategoryName = "Phần Mềm",
                    
                  
                },
                new Categories
                {
                    CategoryId = 3,
                    CategoryName = "Tin Công Nghệ",
                    
                  
                },
                new Categories
                {
                    CategoryId = 4,
                    CategoryName = "Tâm Sự Cuộc Sống",
                    
                  
                },
                new Categories
                {
                    CategoryId = 5,
                    CategoryName = "Mở Mang",
                    
                  
                }
                    );

            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    PostId = 1,
                    Title = "Lộ benchmark Core i9-14900K mạnh hơn Core i7-14700K tới 14%",
                    BriefContent = "CPU Intel thế hệ thứ 14 “Raptor Lake Refresh” dự kiến sẽ được ra mắt vào tháng 10/2023, và chúng ta vừa mới có được những con số benchmark bị rò rỉ của Core i9-14900K và Core i7-14700K.",
                    Content = "Core i9-14900K có 24 nhân 32 luồng (8 P-core và 16 E-core). Con chip này sẽ thay thế cho con chip đầu bảng Core i9-13900K hiện tại. Còn Core i7-14700K thì sẽ kế nhiệm Core i7-13700K, và nó được nâng cấp số nhân lên thành 8 P-core và 12 E-core.",
                    PicturePostUrl = "/images/products/i9_banner.jpg",
                   
                    TagSearch = "i9",
                    CreateDate = DateTime.Now,
                    CategoryId = 2,
          
                    UserId = "1"

                },
                new Post
                {
                    PostId = 2,
                    Title = "Apple phát hành iOS 17 chính thức, hỗ trợ iPhone XS trở đi",
                    BriefContent = "Phiên bản hệ điều hành iOS 17 vừa mới được Apple chính thức phát hành vào sáng nay.",
                    Content = "Rạng sáng ngày 19/9, Apple phát hành phiên bản cập nhật chính thức của iOS 17 tới người dùng iPhone. iOS 17 mang đến các tính năng mới giúp giao tiếp thêm biểu cảm, chia sẻ trở nên đơn giản, cùng một trải nghiệm toàn màn hình mới cho iPhone.\r\n\r\nCụ thể, phiên bản cập nhật iOS 17 có dung lượng khoảng hơn 3GB (tuỳ model), mang số hiệu 21A329, được phát hành cho các thiết bị iPhone từ thế hệ iPhone XS và XR trở đi.",
                    PicturePostUrl = "/images/products/ios17_3.webp",
                   
                    TagSearch = "ios17",
                    CreateDate = DateTime.Now,
                    CategoryId = 2,
          
                    UserId = "1"
                },
                new Post
                {
                    PostId = 3,
                    Title = "Danh sách hội đồng thẩm định Better Choice Awards 2023: Sự kết hợp hoàn hảo của kiến thức, uy tín và tầm ảnh hưởng",
                    BriefContent = "Với sự tham gia của các chuyên gia hàng đầu, lãnh đạo doanh nghiệp và những người có tầm ảnh hưởng, giải thưởng này cam kết tôn vinh những đổi mới sáng tạo thực sự mang lại giá trị cho người tiêu dùng.",
                    Content = "Rạng sáng ngày 19/9, Apple phát hành phiên bản cập nhật chính thức của iOS 17 tới người dùng iPhone. iOS 17 mang đến các tính năng mới giúp giao tiếp thêm biểu cảm, chia sẻ trở nên đơn giản, cùng một trải nghiệm toàn màn hình mới cho iPhone.\r\n\r\nCụ thể, phiên bản cập nhật iOS 17 có dung lượng khoảng hơn 3GB (tuỳ model), mang số hiệu 21A329, được phát hành cho các thiết bị iPhone từ thế hệ iPhone XS và XR trở đi.",
                    PicturePostUrl = "/images/products/pewpew_3.webp",
                   
                    TagSearch = "pewpew",
                    CreateDate = DateTime.Now,
                    CategoryId = 2,
          
                    UserId = "1"
                },
                new Post
                {
                    PostId = 4,
                    Title = "Chiêu thức sáng tạo của Samsung nhằm lôi kéo người dùng iPhone lên đời điện thoại màn hình gập",
                    BriefContent = "Bằng cách sử dụng hai chiếc iPhone, người dùng có thể phần nào được trải nghiệm những lợi ích mà họ sẽ có được khi nâng cấp lên Galaxy Z Fold.",
                    Content = "So với những chiếc smartphone truyền thống với thiết kế phẳng, những chiếc điện thoại màn hình gập mang đến nhiều lợi thế. Với thiết kế gập ngang như Galaxy Z Fold, người dùng sẽ có được một chiếc tablet nằm gọn trong túi quần, khiến cho mọi trải nghiệm giải trí, học tập và làm việc trở nên hiệu quả hơn.",
                    PicturePostUrl = "/images/products/z-fold_3.webp",
                   
                    TagSearch = "zfold",
                    CreateDate = DateTime.Now,
                    CategoryId = 2,
          
                    UserId = "1"
                },
                new Post
                {
                    PostId = 5,
                    Title = "\"Thánh phá hoại\" làng công nghệ: Sáng tạo nhưng phải bền, tôi sẽ drop-test tất cả các sản phẩm tại Better Choice Awards",
                    BriefContent = "\r\nHải Triều, một trong những gương mặt đình đám chuyên “phá hoại” trong làng công nghệ, cho biết anh muốn droptest các sản phẩm tại BCA, vừa là để kiểm chứng độ bền, lại vừa được… thỏa mãn đam mê.",
                    Content = "Nếu bạn là một người yêu công nghệ, hay xem các video clip đánh giá sản phẩm công nghệ nổi bật tại Việt Nam thì chắc chắn sẽ cảm thấy quen thuộc với cái tên Hải Triều tới từ kênh AnhEm TV. Hải Triều là một trong những gương mặt đình đám trong làng công nghệ, bên cạnh các video đánh giá sản phẩm công tâm thì anh còn nổi tiếng với độ “phá hoại” bởi Hải Triều luôn muốn thử độ bền các sản phẩm công nghệ, tạo nên sự khác biệt và chất riêng cho bản thân.",
                    PicturePostUrl = "/images/products/haitrieu_3.webp",
                   
                    TagSearch = "haitrieu",
                    CreateDate = DateTime.Now,
                    CategoryId = 2,
          
                    UserId = "1"
                },
                // 
                new Post
                {
                    PostId = 6,
                    Title = "Lộ benchmark Core i9-14900K mạnh hơn Core i7-14700K tới 14%",
                    BriefContent = "CPU Intel thế hệ thứ 14 “Raptor Lake Refresh” dự kiến sẽ được ra mắt vào tháng 10/2023, và chúng ta vừa mới có được những con số benchmark bị rò rỉ của Core i9-14900K và Core i7-14700K.",
                    Content = "Core i9-14900K có 24 nhân 32 luồng (8 P-core và 16 E-core). Con chip này sẽ thay thế cho con chip đầu bảng Core i9-13900K hiện tại. Còn Core i7-14700K thì sẽ kế nhiệm Core i7-13700K, và nó được nâng cấp số nhân lên thành 8 P-core và 12 E-core.",
                    PicturePostUrl = "/images/products/i9_banner.jpg",
                   
                    TagSearch = "i9",
                    CreateDate = DateTime.Now,
                    CategoryId = 3,
               
                    UserId = "1"
                },
                new Post
                {
                    PostId = 7,
                    Title = "Apple phát hành iOS 17 chính thức, hỗ trợ iPhone XS trở đi",
                    BriefContent = "Phiên bản hệ điều hành iOS 17 vừa mới được Apple chính thức phát hành vào sáng nay.",
                    Content = "Rạng sáng ngày 19/9, Apple phát hành phiên bản cập nhật chính thức của iOS 17 tới người dùng iPhone. iOS 17 mang đến các tính năng mới giúp giao tiếp thêm biểu cảm, chia sẻ trở nên đơn giản, cùng một trải nghiệm toàn màn hình mới cho iPhone.\r\n\r\nCụ thể, phiên bản cập nhật iOS 17 có dung lượng khoảng hơn 3GB (tuỳ model), mang số hiệu 21A329, được phát hành cho các thiết bị iPhone từ thế hệ iPhone XS và XR trở đi.",
                    PicturePostUrl = "/images/products/ios17_3.webp",
                   
                    TagSearch = "ios17",
                    CreateDate = DateTime.Now,
                    CategoryId = 3,
               
                    UserId = "1"
                },
                new Post
                {
                    PostId = 8,
                    Title = "Danh sách hội đồng thẩm định Better Choice Awards 2023: Sự kết hợp hoàn hảo của kiến thức, uy tín và tầm ảnh hưởng",
                    BriefContent = "Với sự tham gia của các chuyên gia hàng đầu, lãnh đạo doanh nghiệp và những người có tầm ảnh hưởng, giải thưởng này cam kết tôn vinh những đổi mới sáng tạo thực sự mang lại giá trị cho người tiêu dùng.",
                    Content = "Rạng sáng ngày 19/9, Apple phát hành phiên bản cập nhật chính thức của iOS 17 tới người dùng iPhone. iOS 17 mang đến các tính năng mới giúp giao tiếp thêm biểu cảm, chia sẻ trở nên đơn giản, cùng một trải nghiệm toàn màn hình mới cho iPhone.\r\n\r\nCụ thể, phiên bản cập nhật iOS 17 có dung lượng khoảng hơn 3GB (tuỳ model), mang số hiệu 21A329, được phát hành cho các thiết bị iPhone từ thế hệ iPhone XS và XR trở đi.",
                    PicturePostUrl = "/images/products/pewpew_3.webp",
                   
                    TagSearch = "pewpew",
                    CreateDate = DateTime.Now,
                    CategoryId = 2,
          
                    UserId = "1"
                },
                new Post
                {
                    PostId = 9,
                    Title = "Chiêu thức sáng tạo của Samsung nhằm lôi kéo người dùng iPhone lên đời điện thoại màn hình gập",
                    BriefContent = "Bằng cách sử dụng hai chiếc iPhone, người dùng có thể phần nào được trải nghiệm những lợi ích mà họ sẽ có được khi nâng cấp lên Galaxy Z Fold.",
                    Content = "So với những chiếc smartphone truyền thống với thiết kế phẳng, những chiếc điện thoại màn hình gập mang đến nhiều lợi thế. Với thiết kế gập ngang như Galaxy Z Fold, người dùng sẽ có được một chiếc tablet nằm gọn trong túi quần, khiến cho mọi trải nghiệm giải trí, học tập và làm việc trở nên hiệu quả hơn.",
                    PicturePostUrl = "/images/products/z-fold_3.webp",
                   
                    TagSearch = "zfold",
                    CreateDate = DateTime.Now,
                    CategoryId = 2,
          
                    UserId = "1"
                },
                new Post
                {
                    PostId = 10,
                    Title = "\"Thánh phá hoại\" làng công nghệ: Sáng tạo nhưng phải bền, tôi sẽ drop-test tất cả các sản phẩm tại Better Choice Awards",
                    BriefContent = "\r\nHải Triều, một trong những gương mặt đình đám chuyên “phá hoại” trong làng công nghệ, cho biết anh muốn droptest các sản phẩm tại BCA, vừa là để kiểm chứng độ bền, lại vừa được… thỏa mãn đam mê.",
                    Content = "Nếu bạn là một người yêu công nghệ, hay xem các video clip đánh giá sản phẩm công nghệ nổi bật tại Việt Nam thì chắc chắn sẽ cảm thấy quen thuộc với cái tên Hải Triều tới từ kênh AnhEm TV. Hải Triều là một trong những gương mặt đình đám trong làng công nghệ, bên cạnh các video đánh giá sản phẩm công tâm thì anh còn nổi tiếng với độ “phá hoại” bởi Hải Triều luôn muốn thử độ bền các sản phẩm công nghệ, tạo nên sự khác biệt và chất riêng cho bản thân.",
                    PicturePostUrl = "/images/products/haitrieu_3.webp",
                   
                    TagSearch = "haitrieu",
                    CreateDate = DateTime.Now,
                    CategoryId = 2,
          
                    UserId = "1"
                },

                //
                new Post
                {
                    PostId = 11,
                    Title = "Lộ benchmark Core i9-14900K mạnh hơn Core i7-14700K tới 14%",
                    BriefContent = "CPU Intel thế hệ thứ 14 “Raptor Lake Refresh” dự kiến sẽ được ra mắt vào tháng 10/2023, và chúng ta vừa mới có được những con số benchmark bị rò rỉ của Core i9-14900K và Core i7-14700K.",
                    Content = "Core i9-14900K có 24 nhân 32 luồng (8 P-core và 16 E-core). Con chip này sẽ thay thế cho con chip đầu bảng Core i9-13900K hiện tại. Còn Core i7-14700K thì sẽ kế nhiệm Core i7-13700K, và nó được nâng cấp số nhân lên thành 8 P-core và 12 E-core.",
                    PicturePostUrl = "/images/products/i9_banner.jpg",
                    
                    TagSearch = "i9",
                    CreateDate = DateTime.Now,
                    CategoryId = 2,
          
                    UserId = "1"
                },
                new Post
                {
                    PostId = 12,
                    Title = "Apple phát hành iOS 17 chính thức, hỗ trợ iPhone XS trở đi",
                    BriefContent = "Phiên bản hệ điều hành iOS 17 vừa mới được Apple chính thức phát hành vào sáng nay.",
                    Content = "Rạng sáng ngày 19/9, Apple phát hành phiên bản cập nhật chính thức của iOS 17 tới người dùng iPhone. iOS 17 mang đến các tính năng mới giúp giao tiếp thêm biểu cảm, chia sẻ trở nên đơn giản, cùng một trải nghiệm toàn màn hình mới cho iPhone.\r\n\r\nCụ thể, phiên bản cập nhật iOS 17 có dung lượng khoảng hơn 3GB (tuỳ model), mang số hiệu 21A329, được phát hành cho các thiết bị iPhone từ thế hệ iPhone XS và XR trở đi.",
                    PicturePostUrl = "/images/products/ios17_3.webp",
                    
                    TagSearch = "ios17",
                    CreateDate = DateTime.Now,
                    CategoryId = 2,
          
                    UserId = "1"
                },
                new Post
                {
                    PostId = 13,
                    Title = "Danh sách hội đồng thẩm định Better Choice Awards 2023: Sự kết hợp hoàn hảo của kiến thức, uy tín và tầm ảnh hưởng",
                    BriefContent = "Với sự tham gia của các chuyên gia hàng đầu, lãnh đạo doanh nghiệp và những người có tầm ảnh hưởng, giải thưởng này cam kết tôn vinh những đổi mới sáng tạo thực sự mang lại giá trị cho người tiêu dùng.",
                    Content = "Rạng sáng ngày 19/9, Apple phát hành phiên bản cập nhật chính thức của iOS 17 tới người dùng iPhone. iOS 17 mang đến các tính năng mới giúp giao tiếp thêm biểu cảm, chia sẻ trở nên đơn giản, cùng một trải nghiệm toàn màn hình mới cho iPhone.\r\n\r\nCụ thể, phiên bản cập nhật iOS 17 có dung lượng khoảng hơn 3GB (tuỳ model), mang số hiệu 21A329, được phát hành cho các thiết bị iPhone từ thế hệ iPhone XS và XR trở đi.",
                    PicturePostUrl = "/images/products/pewpew_3.webp",
                    
                    TagSearch = "pewpew",
                    CreateDate = DateTime.Now,
                    CategoryId = 1,
              
                    UserId = "1"
                },
                new Post
                {
                    PostId = 14,
                    Title = "Chiêu thức sáng tạo của Samsung nhằm lôi kéo người dùng iPhone lên đời điện thoại màn hình gập",
                    BriefContent = "Bằng cách sử dụng hai chiếc iPhone, người dùng có thể phần nào được trải nghiệm những lợi ích mà họ sẽ có được khi nâng cấp lên Galaxy Z Fold.",
                    Content = "So với những chiếc smartphone truyền thống với thiết kế phẳng, những chiếc điện thoại màn hình gập mang đến nhiều lợi thế. Với thiết kế gập ngang như Galaxy Z Fold, người dùng sẽ có được một chiếc tablet nằm gọn trong túi quần, khiến cho mọi trải nghiệm giải trí, học tập và làm việc trở nên hiệu quả hơn.",
                    PicturePostUrl = "/images/products/z-fold_3.webp",
                    
                    TagSearch = "zfold",
                    CreateDate = DateTime.Now,
                    CategoryId = 1,
              
                    UserId = "1"
                },
                new Post
                {
                    PostId = 15,
                    Title = "\"Thánh phá hoại\" làng công nghệ: Sáng tạo nhưng phải bền, tôi sẽ drop-test tất cả các sản phẩm tại Better Choice Awards",
                    BriefContent = "\r\nHải Triều, một trong những gương mặt đình đám chuyên “phá hoại” trong làng công nghệ, cho biết anh muốn droptest các sản phẩm tại BCA, vừa là để kiểm chứng độ bền, lại vừa được… thỏa mãn đam mê.",
                    Content = "Nếu bạn là một người yêu công nghệ, hay xem các video clip đánh giá sản phẩm công nghệ nổi bật tại Việt Nam thì chắc chắn sẽ cảm thấy quen thuộc với cái tên Hải Triều tới từ kênh AnhEm TV. Hải Triều là một trong những gương mặt đình đám trong làng công nghệ, bên cạnh các video đánh giá sản phẩm công tâm thì anh còn nổi tiếng với độ “phá hoại” bởi Hải Triều luôn muốn thử độ bền các sản phẩm công nghệ, tạo nên sự khác biệt và chất riêng cho bản thân.",
                    PicturePostUrl = "/images/products/haitrieu_3.webp",
                    
                    TagSearch = "haitrieu",
                    CreateDate = DateTime.Now,
                    CategoryId = 1,
              
                    UserId = "1"
                },

                //
                new Post
                {
                    PostId = 16,
                    Title = "Lộ benchmark Core i9-14900K mạnh hơn Core i7-14700K tới 14%",
                    BriefContent = "CPU Intel thế hệ thứ 14 “Raptor Lake Refresh” dự kiến sẽ được ra mắt vào tháng 10/2023, và chúng ta vừa mới có được những con số benchmark bị rò rỉ của Core i9-14900K và Core i7-14700K.",
                    Content = "Core i9-14900K có 24 nhân 32 luồng (8 P-core và 16 E-core). Con chip này sẽ thay thế cho con chip đầu bảng Core i9-13900K hiện tại. Còn Core i7-14700K thì sẽ kế nhiệm Core i7-13700K, và nó được nâng cấp số nhân lên thành 8 P-core và 12 E-core.",
                    PicturePostUrl = "/images/products/i9_banner.jpg",
                    
                    TagSearch = "i9",
                    CreateDate = DateTime.Now,
                    CategoryId = 1,
              
                    UserId = "1"
                },
                new Post
                {
                    PostId = 17,
                    Title = "Apple phát hành iOS 17 chính thức, hỗ trợ iPhone XS trở đi",
                    BriefContent = "Phiên bản hệ điều hành iOS 17 vừa mới được Apple chính thức phát hành vào sáng nay.",
                    Content = "Rạng sáng ngày 19/9, Apple phát hành phiên bản cập nhật chính thức của iOS 17 tới người dùng iPhone. iOS 17 mang đến các tính năng mới giúp giao tiếp thêm biểu cảm, chia sẻ trở nên đơn giản, cùng một trải nghiệm toàn màn hình mới cho iPhone.\r\n\r\nCụ thể, phiên bản cập nhật iOS 17 có dung lượng khoảng hơn 3GB (tuỳ model), mang số hiệu 21A329, được phát hành cho các thiết bị iPhone từ thế hệ iPhone XS và XR trở đi.",
                    PicturePostUrl = "/images/products/ios17_3.webp",
                    
                    TagSearch = "ios17",
                    CreateDate = DateTime.Now,
                    CategoryId = 5,
         
                    UserId = "1"
                },
                new Post
                {
                    PostId = 18,
                    Title = "Danh sách hội đồng thẩm định Better Choice Awards 2023: Sự kết hợp hoàn hảo của kiến thức, uy tín và tầm ảnh hưởng",
                    BriefContent = "Với sự tham gia của các chuyên gia hàng đầu, lãnh đạo doanh nghiệp và những người có tầm ảnh hưởng, giải thưởng này cam kết tôn vinh những đổi mới sáng tạo thực sự mang lại giá trị cho người tiêu dùng.",
                    Content = "Rạng sáng ngày 19/9, Apple phát hành phiên bản cập nhật chính thức của iOS 17 tới người dùng iPhone. iOS 17 mang đến các tính năng mới giúp giao tiếp thêm biểu cảm, chia sẻ trở nên đơn giản, cùng một trải nghiệm toàn màn hình mới cho iPhone.\r\n\r\nCụ thể, phiên bản cập nhật iOS 17 có dung lượng khoảng hơn 3GB (tuỳ model), mang số hiệu 21A329, được phát hành cho các thiết bị iPhone từ thế hệ iPhone XS và XR trở đi.",
                    PicturePostUrl = "/images/products/pewpew_3.webp",
                    
                    TagSearch = "pewpew",
                    CreateDate = DateTime.Now,
                    CategoryId = 4,
                  
                    UserId = "1"
                },
                new Post
                {
                    PostId = 19,
                    Title = "Chiêu thức sáng tạo của Samsung nhằm lôi kéo người dùng iPhone lên đời điện thoại màn hình gập",
                    BriefContent = "Bằng cách sử dụng hai chiếc iPhone, người dùng có thể phần nào được trải nghiệm những lợi ích mà họ sẽ có được khi nâng cấp lên Galaxy Z Fold.",
                    Content = "So với những chiếc smartphone truyền thống với thiết kế phẳng, những chiếc điện thoại màn hình gập mang đến nhiều lợi thế. Với thiết kế gập ngang như Galaxy Z Fold, người dùng sẽ có được một chiếc tablet nằm gọn trong túi quần, khiến cho mọi trải nghiệm giải trí, học tập và làm việc trở nên hiệu quả hơn.",
                    PicturePostUrl = "/images/products/z-fold_3.webp",
                    
                    TagSearch = "zfold",
                    CreateDate = DateTime.Now,
                    CategoryId = 4,
                  
                    UserId = "1"
                },
                new Post
                {
                    PostId = 20,
                    Title = "\"Thánh phá hoại\" làng công nghệ: Sáng tạo nhưng phải bền, tôi sẽ drop-test tất cả các sản phẩm tại Better Choice Awards",
                    BriefContent = "\r\nHải Triều, một trong những gương mặt đình đám chuyên “phá hoại” trong làng công nghệ, cho biết anh muốn droptest các sản phẩm tại BCA, vừa là để kiểm chứng độ bền, lại vừa được… thỏa mãn đam mê.",
                    Content = "Nếu bạn là một người yêu công nghệ, hay xem các video clip đánh giá sản phẩm công nghệ nổi bật tại Việt Nam thì chắc chắn sẽ cảm thấy quen thuộc với cái tên Hải Triều tới từ kênh AnhEm TV. Hải Triều là một trong những gương mặt đình đám trong làng công nghệ, bên cạnh các video đánh giá sản phẩm công tâm thì anh còn nổi tiếng với độ “phá hoại” bởi Hải Triều luôn muốn thử độ bền các sản phẩm công nghệ, tạo nên sự khác biệt và chất riêng cho bản thân.",
                    PicturePostUrl = "/images/products/haitrieu_3.webp",
                    
                    TagSearch = "haitrieu",
                    CreateDate = DateTime.Now,
                    CategoryId = 4,
                  
                    UserId = "1"
                }
                ,
                new Post
                {
                    PostId = 21,
                    Title = "\"Thánh phá hoại\" làng công nghệ: Sáng tạo nhưng phải bền, tôi sẽ drop-test tất cả các sản phẩm tại Better Choice Awards",
                    BriefContent = "\r\nHải Triều, một trong những gương mặt đình đám chuyên “phá hoại” trong làng công nghệ, cho biết anh muốn droptest các sản phẩm tại BCA, vừa là để kiểm chứng độ bền, lại vừa được… thỏa mãn đam mê.",
                    Content = "Nếu bạn là một người yêu công nghệ, hay xem các video clip đánh giá sản phẩm công nghệ nổi bật tại Việt Nam thì chắc chắn sẽ cảm thấy quen thuộc với cái tên Hải Triều tới từ kênh AnhEm TV. Hải Triều là một trong những gương mặt đình đám trong làng công nghệ, bên cạnh các video đánh giá sản phẩm công tâm thì anh còn nổi tiếng với độ “phá hoại” bởi Hải Triều luôn muốn thử độ bền các sản phẩm công nghệ, tạo nên sự khác biệt và chất riêng cho bản thân.",
                    PicturePostUrl = "/images/products/haitrieu_3.webp",
                    
                    TagSearch = "haitrieu",
                    CreateDate = DateTime.Now,
                    CategoryId = 4,
                  
                    UserId = "1"
                },
                new Post
                {
                    PostId = 22,
                    Title = "\"Thánh phá hoại\" làng công nghệ: Sáng tạo nhưng phải bền, tôi sẽ drop-test tất cả các sản phẩm tại Better Choice Awards",
                    BriefContent = "\r\nHải Triều, một trong những gương mặt đình đám chuyên “phá hoại” trong làng công nghệ, cho biết anh muốn droptest các sản phẩm tại BCA, vừa là để kiểm chứng độ bền, lại vừa được… thỏa mãn đam mê.",
                    Content = "Nếu bạn là một người yêu công nghệ, hay xem các video clip đánh giá sản phẩm công nghệ nổi bật tại Việt Nam thì chắc chắn sẽ cảm thấy quen thuộc với cái tên Hải Triều tới từ kênh AnhEm TV. Hải Triều là một trong những gương mặt đình đám trong làng công nghệ, bên cạnh các video đánh giá sản phẩm công tâm thì anh còn nổi tiếng với độ “phá hoại” bởi Hải Triều luôn muốn thử độ bền các sản phẩm công nghệ, tạo nên sự khác biệt và chất riêng cho bản thân.",
                    PicturePostUrl = "/images/products/haitrieu_3.webp",
                    
                    TagSearch = "haitrieu",
                    CreateDate = DateTime.Now,
                    CategoryId = 4,
                  
                    UserId = "1"
                },
                new Post
                {
                    PostId = 23,
                    Title = "\"Thánh phá hoại\" làng công nghệ: Sáng tạo nhưng phải bền, tôi sẽ drop-test tất cả các sản phẩm tại Better Choice Awards",
                    BriefContent = "\r\nHải Triều, một trong những gương mặt đình đám chuyên “phá hoại” trong làng công nghệ, cho biết anh muốn droptest các sản phẩm tại BCA, vừa là để kiểm chứng độ bền, lại vừa được… thỏa mãn đam mê.",
                    Content = "Nếu bạn là một người yêu công nghệ, hay xem các video clip đánh giá sản phẩm công nghệ nổi bật tại Việt Nam thì chắc chắn sẽ cảm thấy quen thuộc với cái tên Hải Triều tới từ kênh AnhEm TV. Hải Triều là một trong những gương mặt đình đám trong làng công nghệ, bên cạnh các video đánh giá sản phẩm công tâm thì anh còn nổi tiếng với độ “phá hoại” bởi Hải Triều luôn muốn thử độ bền các sản phẩm công nghệ, tạo nên sự khác biệt và chất riêng cho bản thân.",
                    PicturePostUrl = "/images/products/haitrieu_3.webp",
                    
                    TagSearch = "haitrieu",
                    CreateDate = DateTime.Now,
                    CategoryId = 4,
                  
                    UserId = "1"
                }
                );

            modelBuilder.Entity<Role>()
                .HasData(
                    new Role { Id = 1, Name = "Admin", NormalizedName = "ADMIN" },
                    new Role { Id = 2, Name = "Member", NormalizedName = "MEMBER" }
                );
        }

    }
}
