using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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

        public void EditProduct(Product product)
        {
            Product currentProduct = _dataContext.Products.FirstOrDefault(p => p.Id == product.Id);
            if (currentProduct != null)
            {
                currentProduct.Id = product.Id;
                currentProduct.Name = product.Name;
                currentProduct.Category = product.Category;
                currentProduct.Description = product.Description;
                currentProduct.Price = product.Price;
            }

            _dataContext.SaveChanges();
        }

        public void EditProducts(Product[] products)
        {
            Dictionary<long, Product> idDictionary = products.ToDictionary(p => p.Id);
            var changingItems = _dataContext.Products.Where(p => idDictionary.Keys.Contains(p.Id));
            foreach (Product changingItem in changingItems)
            {
                Product modifiedProduct = idDictionary[changingItem.Id];
                changingItem.Name = modifiedProduct.Name;
                changingItem.Category = modifiedProduct.Category;
                changingItem.Description = modifiedProduct.Description;
                changingItem.Price = modifiedProduct.Price;
            }

            _dataContext.SaveChanges();
        }

        public void RemoveProduct(int id)
        {
            Product product = _dataContext.Products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _dataContext.Remove(product);
            }

            _dataContext.SaveChanges();
        }

        public IQueryable<CartLine> GetLines()
        {
            return _dataContext.CartLines.Include(l=>l.Product);
        }
    }
}