using BBlogApi.Models;
using Microsoft.AspNetCore.Identity;

namespace BBlogApi.Data
{
    public class DbInitializer
    {
        public static async Task Inittialize(UserManager<Account> userManager)
        {
            if (!userManager.Users.Any())
            {
                var admin = new Account
                {
                    UserName = "admin@gmail.com",
                    Email = "admin@gmail.com",
                    MemberName = "Người quản trị",
                    InforUser = "Admin",
                    Avatar = "/images/avatar/admin.webp",
                };
                await userManager.CreateAsync(admin, "Pa$$w0d");
                await userManager.AddToRolesAsync(admin, new[] { "Member", "Admin" });

                var member = new Account
                {
                    UserName = "test",
                    Email = "test@gmail.com",
                    MemberName = "Người dùng",
                    InforUser = "Người dùng web",
                    Avatar = "/images/avatar/test.png",
                };
                await userManager.CreateAsync(member, "Pa$$w0d");
                await userManager.AddToRoleAsync(member, "Member");
            };
		}
    }
}
