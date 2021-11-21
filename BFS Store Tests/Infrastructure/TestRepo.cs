using System.Collections.Generic;
using System.Linq;
using DAO.Models.ProductModel;

namespace SportStoreTests.Infrastructure
{
    public class TestRepo 
    {
        public QueryableList<Product> Products { get; set; }

        public IQueryable<Product> GetProducts()
            => Products;

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void EditProduct(Product id)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveProduct(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}