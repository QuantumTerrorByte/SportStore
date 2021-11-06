using Microsoft.EntityFrameworkCore;
using SportStore.Models.Core;
using SportStore.Models.ProductModel;

namespace SportStore.Models.DAO
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { set; get; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<CartLine> CartLines { get; set; }
        public DbSet<ProductInfo> ProductInfo { get; set; }
        public DbSet<SportStore.Models.ViewModels.ProductPageViewModel> ProductPageViewModel { get; set; }
    }
}