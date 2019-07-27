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
        //public static void Initialize(IServiceProvider service)
        //{
        //    using (var serviceScope = service.CreateScope())
        //    {
        //        var scopeServiceProvider = serviceScope.ServiceProvider;
        //        var db = scopeServiceProvider.GetService<ApplicationDbContext>();
        //        if (!db.Users.Any())
        //        {
        //            //db.Database.Migrate();
        //            AddAdminUser(db, service);
        //        }
        //    }
        //}

        public static async Task AssignAdminRole(IServiceProvider service, ApplicationDbContext context)
        {
            var roleManager = service.GetRequiredService<RoleManager<IdentityRole>>();
            await EnsureRolesAsync(roleManager);
            var userManager = service.GetRequiredService<UserManager<IdentityUser>>();
            await EnsureTestAdminAsync(userManager);

            //context.Database.EnsureCreated();

            //context.SaveChanges();

            //IdentityResult roleResult;
            //var roleCheck = await roleManager.RoleExistsAsync("Admin");
            //if (!roleCheck)
            //{
            //    roleResult = await roleManager.CreateAsync(new IdentityRole("Admin"));
            //}

            //var user = await userManager.FindByNameAsync("admin@ad.com");
            //if (user == null)
            //{
            //    user = new IdentityUser("admin@ad.com");
            //    await userManager.CreateAsync(user, "admin");
            //}
            //await userManager.AddToRoleAsync(user, "Admin");
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
