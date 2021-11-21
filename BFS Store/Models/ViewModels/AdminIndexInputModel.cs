
using DAO.Models.ProductModel;

namespace SportStore.Models.ViewModels
{
    public class AdminIndexInputModel
    {
        public Product[] Products { get; set; }
        public int LastEditedId { get; set; }
    }
}