using System.Linq;
using SportStore.Models.ProductModel;

namespace SportStore.Models.Interfaces
{
    public interface IProductRepository
    {
        IQueryable<Product> Products();
    }
}