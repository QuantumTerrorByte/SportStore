using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportStore.Models.ProductModel;
using SportStore.Models.ViewModels;

namespace SportStore.Models.Interfaces
{
    public interface IProductRepository
    {
        void AddEditProduct(Product products);
        Product RemoveProduct(int id);
        Product GetProduct(int id, bool includeInners = false);
        IEnumerable<Product> GetProducts(bool includeInners = false);
        IQueryable<CartLine> GetLines();
        IEnumerable<Category> GetCategories(int lvl = 0);

        ProductInfo GetProductInfo(long prodId, Lang lang = Lang.US);
        ProductInfo RemoveProductInfo(long id);
        
    }
}