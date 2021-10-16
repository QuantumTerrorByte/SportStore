using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SportStore.Models.Interfaces;
using SportStore.Models.ProductModel;
using SportStore.Models.ViewModels;

namespace SportStore.Models
{
    public class IProductPageDbContext : DbContext  , Interfaces.IProductPageDbContext
    {
        public IProductPageDbContext(DbContextOptions options) : base(options)
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