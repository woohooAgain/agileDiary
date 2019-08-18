using System;
using System.Linq;
using AgileDiary.Helpers.MagicConstants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AgileDiary.Data
{
    public static class CustomDbInitializer
    {
        public static void AssignAdminRole(IServiceProvider service)
        {
            var roleManager = service.GetRequiredService<RoleManager<IdentityRole>>();
            EnsureRolesAsync(roleManager);
            var userManager = service.GetRequiredService<UserManager<IdentityUser>>();
            EnsureTestAdminAsync(userManager);
        }

        private static void EnsureRolesAsync(
            RoleManager<IdentityRole> roleManager)
        {
            RoleSetter(roleManager, MagicStrings.AdminRole);
            RoleSetter(roleManager, MagicStrings.SprinterRole);
        }

        private static void RoleSetter(RoleManager<IdentityRole> roleManager, string roleName)
        {
            var sprinterRoleExists = roleManager
                .RoleExistsAsync(roleName).Result;

            if (!sprinterRoleExists)
            {
                roleManager.CreateAsync(
                    new IdentityRole(roleName)).Wait();
            }
        }

        private static void EnsureTestAdminAsync(UserManager<IdentityUser> userManager)
        {
            var testAdmin = userManager.Users
                .Where(x => x.UserName == "admin@ad.com")
                .SingleOrDefaultAsync().Result;

            if (testAdmin != null) return;

            testAdmin = new IdentityUser
            {
                UserName = "admin@ad.com",
                Email = "admin@ad.com"
            };
            userManager.CreateAsync(
                testAdmin, "52CnhIfnDsdDjh_").Wait();
            userManager.AddToRoleAsync(
                testAdmin, "admin").Wait();
        }
    }
}
