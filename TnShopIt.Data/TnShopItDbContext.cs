using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using TnShopIt.Model.Models;

namespace TnShopIt.Data
{
    public class TnShopItDbContext : IdentityDbContext<ApplicationUser>
    {
        public TnShopItDbContext() : base("TnShopItShopConnection")
        {
            //Khi load bảng cha sẽ không tự động Include bảng con.
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Footer> Footers { set; get; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<MenuGroup> MenuGroups { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }
        public DbSet<Page> Pages { set; get; }
        public DbSet<Post> Posts { set; get; }
        public DbSet<PostCategory> PostCategories { set; get; }
        public DbSet<PostTag> PostTags { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<ProductCategory> ProductCategories { set; get; }
        public DbSet<ProductTag> ProductTags { set; get; }
        public DbSet<Slide> Slides { set; get; }
        public DbSet<SupportOnline> SupportOnlines { set; get; }
        public DbSet<SystemConfig> SystemConfigs { set; get; }
        public DbSet<Tag> Tags { set; get; }
        public DbSet<VistorStatistic> VistorStatistics { set; get; }
        public DbSet<Error> Errors { set; get; }

        public static TnShopItDbContext Create()
        {
            return new TnShopItDbContext();
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserRole>().HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin>().HasKey(x => x.UserId);
        }
    }
}
