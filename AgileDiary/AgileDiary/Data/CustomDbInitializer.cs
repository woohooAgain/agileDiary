using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace AgileDiary.Data
{
    public static class CustomDbInitializer
    {
        public static async Task AssignAdminRole(IServiceProvider service, ApplicationDbContext context)
        {
            var roleManager = service.GetRequiredService<RoleManager<IdentityRole>>();
            await EnsureRolesAsync(roleManager);
            var userManager = service.GetRequiredService<UserManager<IdentityUser>>();
            await EnsureTestAdminAsync(userManager);
        }

        private static async Task EnsureRolesAsync(
            RoleManager<IdentityRole> roleManager)
        {
            var alreadyExists = await roleManager
                .RoleExistsAsync("admin");

            if (alreadyExists) return;

            await roleManager.CreateAsync(
                new IdentityRole("admin"));
        }

        private static async Task EnsureTestAdminAsync(
            UserManager<IdentityUser> userManager)
        {
            var testAdmin = await userManager.Users
                .Where(x => x.UserName == "admin@ad.com")
                .SingleOrDefaultAsync();

            if (testAdmin != null) return;

            testAdmin = new IdentityUser
            {
                UserName = "admin@ad.com",
                Email = "admin@ad.com"
            };
            await userManager.CreateAsync(
                testAdmin, "52CnhIfnDsdDjh_");
            await userManager.AddToRoleAsync(
                testAdmin, "admin");
        }
    }
}
