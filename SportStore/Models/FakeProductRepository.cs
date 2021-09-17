using System;
using System.Collections.Generic;
using System.Linq;

namespace SportStore.Models
{
    public class FaceProductRepository : IProductRepository
    {
        public List<Product> Products { set; get; }

        public FaceProductRepository()
        {
            Products = new List<Product>
            {
                new Product {Name = "Football", Price = 25},
                new Product {Name = "Running shoes", Price = 175},
                new Product {Name = "Surf board", Price = 95},
            };
        }

        public IEnumerable<Product> GetProducts()
        {
            return Products;
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
            Console.WriteLine($@"Product {product.Name} was add products count{Products.Count}");
            
        }
    }
}