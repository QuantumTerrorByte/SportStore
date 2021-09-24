using System.Collections.Generic;
using System.Linq;

namespace SportStore.Models
{
    public class EFProductRepository : IProductRepository
    {
        private readonly DataContext _dataContext;

        public EFProductRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IQueryable<Product> GetProducts()
            => _dataContext.Products;


        public void AddProduct(Product product)
        {
            _dataContext.Products.Add(product);
            _dataContext.SaveChanges();
        }
    }
}