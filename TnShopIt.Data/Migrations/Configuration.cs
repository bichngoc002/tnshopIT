namespace TnShopIt.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Model.Models;
    using static System.Net.Mime.MediaTypeNames;
    internal sealed class Configuration : DbMigrationsConfiguration<TnShopIt.Data.TnShopItDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TnShopIt.Data.TnShopItDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new TnShopItDbContext()));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new TnShopItDbContext()));

            var user = new ApplicationUser()
            {
                UserName = "tedu",
                Email = "tthnhanit@gmail.com",
                EmailConfirmed = true,
                BirthDay = DateTime.Now,
                FullName = "Thanh Nhan",
            };

            manager.Create(user, "123456$");

            if(!roleManager.Roles.Any())
            {
                roleManager.Create(new IdentityRole { Name = "Admin" });
                roleManager.Create(new IdentityRole { Name = "User" });
            }

            var adminUser = manager.FindByEmail("tthnhanit@gmail.com");

            manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
        }
    }
}
