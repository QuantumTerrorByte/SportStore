using System.Collections.Generic;
using System.Linq;
using SportStore.Models.ProductModel;

namespace SportStore.Models.Interfaces
{
    public interface IProductRepository
    {
        void AddEditProduct(Product products);
        void EditProducts(Product[] products);
        void RemoveProduct(int id);

        IEnumerable<Product> Products(bool includeInners = false);
        IQueryable<CartLine> GetLines();
        public IEnumerable<string> GetCategoriesByLang(int lvl, Lang lang = Lang.ENG);
        public IEnumerable<Category> GetCategories(int lvl = 0);
        public IEnumerable<Category> GetCategoriesTest(int lvl = 0);
    }
}