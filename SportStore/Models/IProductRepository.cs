using System.Collections.Generic;
using System.Linq;

namespace SportStore.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> GetProducts();
        void AddProduct(Product product);

        void EditProduct(Product products);
        void EditProducts(Product[] products);
        void RemoveProduct(int id);
    }
}