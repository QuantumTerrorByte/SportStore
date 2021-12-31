using System;
using DAO.Models;
using DAO.Models.ProductModel;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public class AppDataContext : DbContext
    {
        protected AppDataContext()
        {
        }

        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
        {
            
        }

        public DbSet<AppUser> AppUsers { set; get; }
        public DbSet<Address> Addresses { set; get; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<LikeJunction> LikeJunctions { get; set; }
        
        public DbSet<Product> Products { set; get; }
        public DbSet<ProductInfo> ProductInfos { get; set; }
        public DbSet<Description> Descriptions { set; get; }
        public DbSet<ProductIngredientsTableRow> ProductIngredientsTableRows { set; get; }
        public DbSet<Category> Categories { get; set; }
        
        public DbSet<Cart> Carts { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<ProductLine> ProductLines { get; set; }
        
        // public DbSet<SportStore.Models.ViewModels.ProductPageViewModel> ProductPageViewModel { get; set; }
    }
}