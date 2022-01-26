using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAO.DataTransferModel;
using DAO.Models;
using DAO.Models.ProductModel;

namespace DAO.Interfaces
{
    public interface IProductRepository
    {
        public static readonly object ProductsSyncObj  = new object();
        void AddOrEditProduct(Product products);
        Product RemoveProduct(int id);
        Task<Product> GetProduct(long id, bool includeInners = false);
        List<Product> GetProductsById(params long[] ids);
        Task<List<Product>> GetProductsByIdAsync(params long[] ids);
        Task<List<Product>> GetAllProductsListAsync(bool includeInners = false);
        IQueryable<ProductLine> GetLines();
        ProductInfo GetProductInfo(long prodId, Langs lang = Langs.US);
        ProductInfo RemoveProductInfo(long id);
        Task<bool> CheckContainsAsync(long[] ids);
        
        (IList<Product>, int) GetFilteredProducts(FilteredProductsRepoRequestModel requestModel);
        IList<string> GetBrands();
        public IEnumerable<Category> GetCategories(int lvl = 0);
        public IEnumerable<string> LangGetCategories(int categoryLvl, Langs lang = Langs.US);
        Task SaveChangesAsync();
        void SaveChanges();
    }
}