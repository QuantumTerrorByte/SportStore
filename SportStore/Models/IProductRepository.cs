using System.Collections.Generic;
using System.Linq;

namespace SportStore.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        void AddProduct(Product product);
    }
}