using System.Collections.Generic;
using System.Linq;
using SportStore.Models;
using SportStore.Models.ProductModel;

namespace SportStore.Deprecated
{
    public interface IProductRepository
    {
        IQueryable<Product> GetProducts(bool includeInners);
        void AddProduct(Product product);

        void EditProduct(Product products);
        void EditProducts(Product[] products);
        void RemoveProduct(int id);

        IQueryable<Product> Products(bool includeInners = false);
        IQueryable<CartLine> GetLines();
        public IEnumerable<string> GetCategoriesByLang(int lvl, Lang lang = Lang.ENG);
        public IQueryable<Category> GetCategories(int lvl);
    }
}