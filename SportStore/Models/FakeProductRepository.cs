using System.Collections.Generic;
using System.Linq;

namespace SportStore.Models
{
    public class FaceProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
            {
                new Product {Name = "Football", Price = 25},
                new Product {Name = "Running shoes", Price = 175},
                new Product {Name = "Surf board", Price = 95},
            }.AsQueryable();

        public void AddProduct(Product product)
        {
        }
    }
}