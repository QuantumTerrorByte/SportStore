using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SportStore.Models
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { set; get; }
        public DbSet<Order> Orders { set; get; }

        public DbSet<CartLine> CartLines { get; set; }
        
    }
}