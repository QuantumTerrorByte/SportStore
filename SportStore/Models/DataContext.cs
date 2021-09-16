using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SportStore.Models
{
    public class DataContext: DbContext, IProductRepository
    {
        protected DataContext()
        {
        }

        public DataContext(DbContextOptions options) : base(options)
        {
        }

        private DbSet<Product> Products { set; get; }
        public IQueryable<Product> GetProducts()
        {
            throw new System.NotImplementedException();
        }

        public void AddProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

    }
}