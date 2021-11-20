using Microsoft.EntityFrameworkCore;
using SportStore.Models.Core;
using SportStore.Models.DAO.Interfaces;
using SportStore.Models.ProductModel;

namespace SportStore.Models.DAO
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { set; get; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<CartLine> CartLines { get; set; }
        public DbSet<ProductInfo> ProductInfos { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<LikeJunction> LikeJunctions { get; set; }
        
        // public DbSet<SportStore.Models.ViewModels.ProductPageViewModel> ProductPageViewModel { get; set; }
    }
}