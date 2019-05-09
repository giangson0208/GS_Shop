using GS_Shop.Model.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GS_Shop.Data
{   //trái tim của Entity Framework code first
    public class GS_ShopDbContext : DbContext
    {
        public GS_ShopDbContext() : base("GS_ShopConnection")   //Lấy name trong GS_Shop.Data/App.congig
        {
            this.Configuration.LazyLoadingEnabled = false; //Khi ta load bảng cho thì sẽ k tự động load bảng con nữa
        }
        //cấu hình DbSet theo các bảng mà ta đã có
        public DbSet<Footer> Footers { set; get; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<MenuGroup> MenuGroups { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }
        public DbSet<Page> Pages { set; get; }
        public DbSet<Post> Posts { set; get; }
        public DbSet<PostCategory> PostCategorys { set; get; }
        public DbSet<PostTag> PostTags { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<ProductCategory> ProductCategorys { set; get; }
        public DbSet<ProductTag> ProductTags { set; get; }
        public DbSet<Slide> Slides { set; get; }
        public DbSet<SupportOnline> SupportOnlines { set; get; }
        public DbSet<SystemConfig> SystemConfigs { set; get; }
        public DbSet<Tag> Tags { set; get; }
        public DbSet<VisitorStatistic> VisitorStatistics { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) //trong quá trính làm cần ghi đè phương thức của DbContext
        {
        }
    }
}
