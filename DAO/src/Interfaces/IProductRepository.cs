using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAO.DataTransferModel;
using DAO.Models;
using DAO.Models.Core;
using DAO.Models.ProductModel;

namespace DAO.Interfaces
{
    public interface IProductRepository
    {
        void AddEditProduct(Product products);
        Product RemoveProduct(int id);
        Task<Product> GetProduct(long id, bool includeInners = false);
        IEnumerable<Product> GetProducts(bool includeInners = false);
        IQueryable<CartLine> GetLines();
        ProductInfo GetProductInfo(long prodId, Langs lang = Langs.US);
        ProductInfo RemoveProductInfo(long id);

        (IList<Product>, int) GetFilteredProducts(FilteredProductsRepoRequestModel requestModel);
        IList<string> GetBrands();
        public IEnumerable<Category> GetCategories(int lvl = 0);
        public IEnumerable<string> LangGetCategories(int categoryLvl, Langs lang = Langs.US);
    }
}