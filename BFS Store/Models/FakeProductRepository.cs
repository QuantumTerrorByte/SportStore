using System;
using System.Collections.Generic;
using System.Linq;

namespace SportStore.Models
{
    public class FaceProductRepository 
    {
        public List<Product> Products { set; get; }

        public FaceProductRepository()
        {
            Products = new List<Product>
            {
                new Product {Id = 1,Name = "Football", Price = 25, Description = "The best of the best football for young and not too smart children when parents want some chill", Category = "Balls"},
                new Product {Id = 2,Name = "Basketball", Price = 55, Description = "The best of the best football for young and not too smart children when parents want some chill The best of the best football for young and not too smart children when parents want some chill", Category = "Balls"},
                new Product {Id = 3,Name = "Volleyball", Price = 35, Description = "The best of the best football for young and not too smart children when parents want some chill", Category = "Balls"},
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